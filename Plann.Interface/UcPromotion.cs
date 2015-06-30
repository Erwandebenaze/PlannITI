using System;
using System.Linq;
using System.Windows.Forms;
using Plann.Core;

namespace Plann.Interface
{
    public partial class UcPromotion : UserControl
    {
        public delegate void SelectionPromotionChanged();
        public event SelectionPromotionChanged PromotionChanged;

        public delegate void SelectionSectorChanged();
        public event SelectionSectorChanged SectorChanged;

        public UcPromotion()
        {
            InitializeComponent();
            InitializeComboBox();
        }      
        IPlannContext SoftContext
        {
            get { return (IPlannContext)TopLevelControl; }
        }

        public void OnPromotionChanged()
        {
            if( PromotionChanged != null )
                PromotionChanged();
        }

        public void OnSectorChanged()
        {
            if( SectorChanged != null )
                SectorChanged();
        }

        internal void InitializeComboBox()
        {
            #region ClearComboBox
            promotionComboBox.Text = "";
            teacherComboBox.Text = "";
            subjectComboBox.Text = "";
            roomComboBox.Text = "";
            promotionComboBox.Items.Clear();
            teacherComboBox.Items.Clear();
            subjectComboBox.Items.Clear();
            roomComboBox.Items.Clear();
            #endregion
            try
            {
                #region FillComboBox
                foreach( Promotion p in SoftContext.CurrentPeriod.ListPromotion )
                {
                    promotionComboBox.Items.Add( p.Name );
                }
                foreach( Teacher t in SoftContext.CurrentPeriod.ListTeachers )
                {
                    teacherComboBox.Items.Add( t.Name );
                }
                foreach( Subject s in SoftContext.CurrentPeriod.ListSubjects )
                {
                    subjectComboBox.Items.Add( s.Name );
                }
                foreach( Room r in SoftContext.CurrentPeriod.ListRooms )
                {
                    roomComboBox.Items.Add( r.Name );
                }
                #endregion
            }
            catch( NullReferenceException e )
            {
                Console.Write( e );
            }
        }
        #region LinkClicked
        private void manageSubjectsLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls["ucMgtSubject1"].Visible = true;
        }
        private void manageRoomsLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls["ucMgtRoom1"].Visible = true;
        }
        private void manageTeachersLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls["ucMgtTeacher1"].Visible = true;
        }
        private void managePromotionsLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls["ucMgtPromotion1"].Visible = true;
        } 
        #endregion
        private void subjectComboBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            if(subjectComboBox.Text != null)
            {
                if (SoftContext.CurrentPeriod.ListSubjects.Where( su => su.Name == subjectComboBox.Text ).Where( te => te.ReferentTeacher != null ).Select( te => te.ReferentTeacher ).Any())
                {
                  Teacher t = SoftContext.CurrentPeriod.ListSubjects.Where( su => su.Name == subjectComboBox.Text ).Where( te => te.ReferentTeacher != null ).Select( te => te.ReferentTeacher ).Single(); 
                  teacherComboBox.SelectedItem = t.Name;
                } else
                {
                    teacherComboBox.Text = "";
                }
            }
        }

        private void promotionComboBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            OnPromotionChanged();
        }

        private void sectorComboBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            OnSectorChanged();
        }

        private void subjectComboBox_Click( object sender, EventArgs e )
        {
            if( promotionComboBox.Items.Count == 0 && roomComboBox.Items.Count == 0 && subjectComboBox.Items.Count == 0 )
                InitializeComboBox();
            }

        private void roomComboBox_Click( object sender, EventArgs e )
        {
            if( promotionComboBox.Items.Count == 0 && roomComboBox.Items.Count == 0 && subjectComboBox.Items.Count == 0 )
            InitializeComboBox();
        }

        private void teacherComboBox_Click( object sender, EventArgs e )
        {
            if( promotionComboBox.Items.Count == 0 && roomComboBox.Items.Count == 0 && subjectComboBox.Items.Count == 0 )
            InitializeComboBox();
        }

        private void promotionComboBox_Click( object sender, EventArgs e )
        {
            if( promotionComboBox.Items.Count == 0 && roomComboBox.Items.Count == 0 && subjectComboBox.Items.Count == 0 )
                InitializeComboBox();
        }
    }
}
