using System;
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
        internal delegate void MyEventHandler();
        internal event MyEventHandler reload;
        internal void OnReload()
        {
            if( reload != null )
            {
                reload();
            }
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
                this.objectListView1.SetObjects( SoftContext.CurrentPeriod.ListTeachers );
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
                } else if(SoftContext.CurrentPeriod.ListTeachers.Contains(new Teacher(nameTextBox.Text, mailTextBox.Text)))
                {
                    MessageBox.Show( "Ce professeur a déjà été créé" );
                } else
                {
                    SoftContext.CurrentPeriod.addTeacher( new Teacher( nameTextBox.Text, mailTextBox.Text ) );
                    InitializeOlv();
                }
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
