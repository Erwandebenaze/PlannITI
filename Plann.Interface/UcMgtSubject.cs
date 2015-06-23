using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Plann.Core;


namespace Plann.Interface
{
    public partial class UcMgtSubject : UserControl
    {
        public UcMgtSubject()
        {
            InitializeComponent();
            InitializeComboBox();
        }
        private void InitializeComboBox()
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
                int color = colorDialog1.Color.A;
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
                if (SoftContext.CurrentPeriod.ListSubjects.Contains(new Subject(nameTextBox.Text, Color.Red)))
                {
                    MessageBox.Show( "Cette matière a déjà été entrée." );
                } else
                {
                    Subject tmpSubject = null;
                    if( teacherNameComboBox.SelectedItem == null )
                    {
                        tmpSubject = new Subject( nameTextBox.Text, button1.BackColor );
                    }
                    else
                    {
                        Teacher t = SoftContext.CurrentPeriod.ListTeachers.Where( th => th.Name == teacherNameComboBox.SelectedItem.ToString() ).Single();
                        tmpSubject = new Subject( nameTextBox.Text, t, button1.BackColor );
                    }
                    SoftContext.CurrentPeriod.addSubject( tmpSubject );
                    InitializeOlv();
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
        }
    }
}
