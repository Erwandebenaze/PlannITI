using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plann.Core;


namespace Plann.Interface
{
    public partial class UcMgtSubject : UserControl
    {
        public UcMgtSubject()
        {
            InitializeComponent();

            
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
            }
            catch (NullReferenceException e) 
            {
                Console.Write( e );
            }

            try
            {
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
            // Load UcMgtTeacher
           
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
                        // Erreur probable sur la récupération du professeur
                        // Récupérer le professeur selon son nom.
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
    }
}
