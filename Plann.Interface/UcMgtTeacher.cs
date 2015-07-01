using System;
using System.Windows.Forms;
using Plann.Core;

namespace Plann.Interface
{
    public partial class UcMgtTeacher : UserControl
    {
        Teacher _tTmp;
        public UcMgtTeacher()
        {
            InitializeComponent();
        }
        private void reinitialisation()
        {
            nameTextBox.Text = "";
            mailTextBox.Text = "";
            validateButton.Text = "Valider";
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
                }
                else if( SoftContext.CurrentPeriod.ListTeachers.Contains( new Teacher( nameTextBox.Text, mailTextBox.Text ) ) && validateButton.Text == "Valider" )
                {
                    MessageBox.Show( "Ce professeur a déjà été créé" );
                } else if (validateButton.Text == "Modifier" )
                {
                    SoftContext.CurrentPeriod.editTeacher( _tTmp, new Teacher( nameTextBox.Text, mailTextBox.Text ) );
                    InitializeOlv();
                    validateButton.Text = "Valider";
                    delete.Visible = false;
                    reinitialisation();
                }
                else
                {
                    SoftContext.CurrentPeriod.addTeacher( new Teacher( nameTextBox.Text, mailTextBox.Text ) );
                    InitializeOlv();
                    reinitialisation();
                }
            }  
        }
        private void returnLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls[SoftContext.CurrentPeriod.CurrentUcFilter].Visible = true;
            OnReload();
            reinitialisation();
        }

        private void objectListView1_CellClick( object sender, BrightIdeasSoftware.CellClickEventArgs e )
        {
            if( e.Model != null )
            {
                _tTmp = (Teacher)e.Model;
                nameTextBox.Text = _tTmp.Name;
                mailTextBox.Text = _tTmp.Mail;
                validateButton.Text = "Modifier";
                delete.Visible = true;
            }
        }

        private void delete_Click( object sender, EventArgs e )
        {
            SoftContext.CurrentPeriod.ListTeachers.Remove( _tTmp );
            InitializeOlv();
            delete.Visible = false;
            reinitialisation();
        }
    }
}
