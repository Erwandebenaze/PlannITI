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
            this.objectListView1.SetObjects( SoftContext.CurrentSoft.GetSubjects() );

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
            if(nameTextBox == null && button1.BackColor != Color.White)
            {
                MessageBox.Show( "Vous ne pouvez pas valider le formulaire. Vous devez au moins entrer un intitulé et une couleur." );
            } else
            {
                Subject tmpSubject = null;
                if(teacherNameComboBox == null)
                {
                    tmpSubject = new Subject(nameTextBox.Text, button1.BackColor);
                } else
                {
                    // Erreur probable sur la récupération du professeur
                    // Récupérer le professeur selon son nom.
                    MessageBox.Show( teacherNameComboBox.SelectedItem.ToString());
                    tmpSubject = new Subject(nameTextBox.Text,(Teacher)teacherNameComboBox.SelectedItem, button1.BackColor);
                }

                SoftContext.CurrentSoft.addSubject( tmpSubject );
            }
        }
    }
}
