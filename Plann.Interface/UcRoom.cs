using System;
using System.Linq;
using System.Windows.Forms;
using Plann.Core;

namespace Plann.Interface
{
    public partial class UcRoom : UserControl
    {
        public UcRoom()
        {
            InitializeComponent();
        }
        IPlannContext SoftContext
        {
            get { return (IPlannContext)TopLevelControl; }
        }
        internal void InitializeComboBox()
        {
            #region ClearComboBox
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
        private void manageRoomsLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls["ucMgtRoom1"].Visible = true;
        }
        private void manageSubjectsLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls["ucMgtSubject1"].Visible = true;
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
            if( subjectComboBox.Text != null )
            {
                Teacher t = SoftContext.CurrentPeriod.ListSubjects.Where( su => su.Name == subjectComboBox.Text ).Select( te => te.ReferentTeacher ).Single();
                teacherComboBox.SelectedItem = t.Name;
            }
        }
    }
}
