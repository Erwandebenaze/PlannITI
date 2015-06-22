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
    public partial class UcMgtPromotion : UserControl
    {
        public UcMgtPromotion()
        {
            InitializeComponent();
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
                else if( SoftContext.CurrentPeriod.ListPromotion.Contains( new Promotion( nameTextBox.Text, mailTextBox.Text, 5 ) ) )
                {
                    MessageBox.Show( "Cette promotion a déjà été créée" );

                }
                else
                {
                     int numberOfStudents;
                    if (int.TryParse(numberOfStudentsTextBox.Text, out numberOfStudents))
                    {
                        SoftContext.CurrentPeriod.addPromotion( new Promotion( nameTextBox.Text,mailTextBox.Text , numberOfStudents ) );
                        InitializeOlv();
                    } else
                    {
                        MessageBox.Show( "Le nombre d'élèves entré n'est pas un nombre entier." );
                    }
                }
            }

        }

        private void returnLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls[SoftContext.CurrentPeriod.CurrentUcFilter].Visible = true;
        }

        private void retour_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls[SoftContext.CurrentPeriod.CurrentUcFilter].Visible = true;
        }
    }
}
