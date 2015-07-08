using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Plann.Core;
using BrightIdeasSoftware;


namespace Plann.Interface
{
    public partial class UcMgtSubject : UserControl
    {
        Subject _sTmp;
        Color _cTmp;
        public UcMgtSubject()
        {
            InitializeComponent();
            InitializeComboBox();
        }
        private void reinitialisation()
        {
            nameTextBox.Text = "";
            teacherNameComboBox.Text = "";
            InitializeComboBox();
            button1.BackColor= Color.White;
            validateButton.Text = "Valider";
        }
        public void LoadPage()
        {
            InitializeOlv();
        }
        internal void InitializeComboBox()
        {
            teacherNameComboBox.Items.Clear();
            try
            {
                foreach( Teacher t in SoftContext.CurrentPeriod.ListTeachers )
                {
                    teacherNameComboBox.Items.Add( t.Name );
                }
            }
            catch( NullReferenceException e )
            {
                Console.Write( e );
            }
        }
        internal delegate void MyEventHandler();
        internal event MyEventHandler reload;
        internal void OnReload()
        {
            if(reload != null)
            {
                reload();
            }
        }
        IPlannContext SoftContext
        {
            get { return (IPlannContext)TopLevelControl; }
        }
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad( e );
            InitializeOlv();
        }
        private void InitializeOlv()
        {
            objectListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;            
            try
            {
                this.objectListView1.SetObjects( SoftContext.CurrentPeriod.ListSubjects );
                foreach( Teacher t in SoftContext.CurrentPeriod.ListTeachers )
                {
                    teacherNameComboBox.Items.Add( t.Name );
                }
            }
            catch (NullReferenceException e)
            {
                Console.Write( e );
            }
        }
        private void button1_Click( object sender, EventArgs e )
        {
            if( colorDialog1.ShowDialog() == DialogResult.OK )
            {
                button1.BackColor = colorDialog1.Color;
            //    int color = colorDialog1.Color.A;
            }
        }
        private void manageTeachersLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls["ucMgtTeacher1"].Visible = true;       
        }
        private void validateButton_Click( object sender, EventArgs e )
        {
            if(String.IsNullOrWhiteSpace(nameTextBox.Text)|| button1.BackColor == null)
            {
                MessageBox.Show( "Vous ne pouvez pas valider le formulaire. Vous devez au moins entrer un intitulé et une couleur." );
            } else
            {
                if( SoftContext.CurrentPeriod.ListSubjects.Contains( new Subject( nameTextBox.Text, Color.Red ) ) )
                {
                    MessageBox.Show( "Cette matière a déjà été entrée." );
                } else
                {
                    Subject tmpSubject = null;
                    if( teacherNameComboBox.SelectedItem == null )
                    {
                        tmpSubject = new Subject( nameTextBox.Text, button1.BackColor );
                        SoftContext.CurrentPeriod.addSubject( tmpSubject );
                        reinitialisation();
                    }
                    else if( teacherNameComboBox.SelectedItem == null )
                    {
                        SoftContext.CurrentPeriod.editSubject( _sTmp, new Subject(nameTextBox.Text, button1.BackColor ));
                        InitializeOlv();
                        validateButton.Text = "Valider";
                        reinitialisation();
                    }
                    else
                    {
                        Teacher t = SoftContext.CurrentPeriod.ListTeachers.Where( th => th.Name == teacherNameComboBox.SelectedItem.ToString() ).Single();
                        tmpSubject = new Subject( nameTextBox.Text, t, button1.BackColor );
                        SoftContext.CurrentPeriod.addSubject( tmpSubject );
                        reinitialisation();
                    }
               
                    InitializeOlv();
                    InitializeComboBox();
                }
            }
        }
        private void objectListView1_FormatCell( object sender, BrightIdeasSoftware.FormatCellEventArgs e )
        {
           if( e.Column.AspectName == "Color")
           {
               Color c = (Color)e.CellValue;
               e.SubItem.BackColor = c;
               e.SubItem.Text = "";
           }
        }
        private void returnLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls[SoftContext.CurrentPeriod.CurrentUcFilter].Visible = true;
            OnReload();
            reinitialisation();
        }
        private void objectListView1_CellEditStarting( object sender, CellEditEventArgs e )
        {
            if( e.Value is Color )
            {
                ColorCellEditor cce = new ColorCellEditor( (Color)e.Value );
                _cTmp = cce.Value;
                e.Control = cce;
            }
        }
        private void objectListView1_CellEditFinishing( object sender, CellEditEventArgs e )
        {
            if(e.Cancel == false && e.Value is Color )
            {
                e.NewValue = _cTmp;
            }
        }

        private void supprimerMatièreToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if( SoftContext.CurrentPeriod.ListSlots.Where(sl => sl.AssociatedSubject == _sTmp).Any() )
            {
                MessageBox.Show( "Vous ne pouvez pas supprimer cette matière. Supprimer d'abord le créneau où elle est affectée." );
            } else
            {
                SoftContext.CurrentPeriod.removeSubject( _sTmp );
                InitializeOlv();
                reinitialisation();
            }

        }

        private void objectListView1_CellRightClick( object sender, CellRightClickEventArgs e )
        {
            contextMenuStrip1.Show( new System.Drawing.Point( Cursor.Position.X, Cursor.Position.Y - 30 ) );
            _sTmp = (Subject)e.Model;
        }
    }
}
