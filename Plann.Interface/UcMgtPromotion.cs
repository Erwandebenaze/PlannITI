using System;
using System.Windows.Forms;
using Plann.Core;

namespace Plann.Interface
{
    public partial class UcMgtPromotion : UserControl
    {
        Promotion _pTmp;
        public UcMgtPromotion()
        {
            InitializeComponent();
        }
        public void LoadPage()
        {
            InitializeOlv();
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
                this.objectListView1.SetObjects( SoftContext.CurrentPeriod.ListPromotion );
            }
            catch( NullReferenceException e )
            {
                Console.Write( e );
            }
        }
        private void validate_Click( object sender, EventArgs e )
        {
            if( !String.IsNullOrWhiteSpace( nameTextBox.Text ) && !String.IsNullOrWhiteSpace( mailTextBox.Text ) )
            {
                if( !IsValidEmail( mailTextBox.Text ) )
                {
                    MessageBox.Show( "L'adresse email n'est pas valide." );
                }
                else if( SoftContext.CurrentPeriod.ListPromotion.Contains( new Promotion( nameTextBox.Text, mailTextBox.Text, 5 ) ) && validate.Text =="Valider" )
                {
                    MessageBox.Show( "Cette promotion a déjà été créée." );
                }
                else
                {
                    int numberOfStudents;
                    if (int.TryParse(numberOfStudentsTextBox.Text, out numberOfStudents) && validate.Text == "Valider")
                    {
                        SoftContext.CurrentPeriod.addPromotion( new Promotion( nameTextBox.Text,mailTextBox.Text , numberOfStudents ) );
                        InitializeOlv();
                    } else if (int.TryParse(numberOfStudentsTextBox.Text, out numberOfStudents) && validate.Text == "Modifier")
                    {
                        SoftContext.CurrentPeriod.editPromotion( _pTmp, new Promotion( nameTextBox.Text, mailTextBox.Text, numberOfStudents ) );
                        InitializeOlv();
                        validate.Text = "Valider";
                        delete.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show( "Le nombre d'élèves entré n'est pas un nombre entier." );
                    }
                }
            }
        }
        private void retour_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls[SoftContext.CurrentPeriod.CurrentUcFilter].Visible = true;
        }
        private void objectListView1_CellClick( object sender, BrightIdeasSoftware.CellClickEventArgs e )
        {
            if(e.Model != null)
            {
                _pTmp = (Promotion)e.Model;
                nameTextBox.Text = _pTmp.Name;
                numberOfStudentsTextBox.Text = _pTmp.NumberOfStudents.ToString();
                mailTextBox.Text = _pTmp.Mail;
                validate.Text = "Modifier";
                delete.Visible = true;
            }

        }

        private void delete_Click( object sender, EventArgs e )
        {
            SoftContext.CurrentPeriod.ListPromotion.Remove( _pTmp );
            InitializeOlv();
            delete.Visible = false;

        }
    }
}
