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
    public partial class UcMgtTeacher : UserControl
    {
        public UcMgtTeacher()
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
                this.objectListView1.SetObjects( SoftContext.CurrentSoft.ListTeachers );
            }
            catch( NullReferenceException e )
            {
                Console.Write( e );
            }
        
        }

        private bool IsValidEmail( string email )
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress( email );
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }
        private void validateButton_Click( object sender, EventArgs e )
        {
            if( !String.IsNullOrWhiteSpace( nameTextBox.Text ) && !String.IsNullOrWhiteSpace( mailTextBox.Text ) )
            {
                if(!IsValidEmail(mailTextBox.Text))
                {
                    MessageBox.Show( "L'adresse email n'est pas valide." );
                }
                if(SoftContext.CurrentSoft.ListTeachers.Contains(new Teacher(nameTextBox.Text, mailTextBox.Text)))
                {
                    MessageBox.Show( "Ce professeur a déjà été créé" );

                } else
                {
                    SoftContext.CurrentSoft.addTeacher( new Teacher( nameTextBox.Text, mailTextBox.Text ) );
                    InitializeOlv();
                }
            }
            
        }
    }
}
