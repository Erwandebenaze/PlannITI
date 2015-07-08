using System;
using System.Windows.Forms;
using Plann.Core;
using System.Linq;

namespace Plann.Interface
{
    public partial class UcMgtPromotion : UserControl
    {
        Promotion _pTmp;
        public UcMgtPromotion()
        {
            InitializeComponent();
            reinitialisation();
        }
        private void reinitialisation()
        {
            nameTextBox.Text = "";
            mailTextBox.Text = "";
            numberOfILTextBox.Text = "0";
            numberOfSRTextBox.Text = "0";
            numberOfStudentsTextBox.Text = "0";
            validate.Text = "Valider";
        }
        public void LoadPage()
        {
            InitializeOlv();
        }
        internal delegate void MyEventHandler();
        internal event MyEventHandler reload;
        internal void OnReload()
        {
            if( reload != null )
                reload();
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
            objectListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;

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
                else if( SoftContext.CurrentPeriod.ListPromotion.Contains( new Promotion( nameTextBox.Text, mailTextBox.Text, 5,3,2 ) ))
                {
                    MessageBox.Show( "Cette promotion a déjà été créée." );
                }
                else
                {
                    int numberOfStudents;
                    int numberOfIL;
                    int numberOfSR;
                    if( int.TryParse( numberOfStudentsTextBox.Text, out numberOfStudents ) && int.TryParse( numberOfILTextBox.Text, out numberOfIL ) && int.TryParse( numberOfSRTextBox.Text, out numberOfSR ) )
                    {
                        if (((numberOfIL + numberOfSR) == numberOfStudents) || (numberOfIL == 0 && numberOfSR == 0))
                        {
                            SoftContext.CurrentPeriod.addPromotion( new Promotion( nameTextBox.Text, mailTextBox.Text, numberOfStudents, numberOfIL, numberOfSR ) );
                            InitializeOlv();
                            reinitialisation();
                        } else
                        {
                            MessageBox.Show( "Le nombre de SR et le nombre d'IL doit être égal au nombre d'élèves. Pour les semestres 1 et 2, laissez les deux champs à 0." );
                        }
                    }
                    else
                    {
                        MessageBox.Show( "Le nombre d'élèves, de SR ou IL entré n'est pas un nombre entier. S'il n'y a pas d'IL ou SR, laissez 0." );
                    }
                }
            }
        }
        private void retour_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls[SoftContext.CurrentPeriod.CurrentUcFilter].Visible = true;
            reinitialisation();
            OnReload();
        }

        private void supprimerPromotionToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if( SoftContext.CurrentPeriod.ListSlots.Where( sl => sl.AssociatedPromotionList.Contains(_pTmp) ).Any() )
            {
                MessageBox.Show( "Vous ne pouvez pas supprimer cette promotion. Supprimer d'abord le créneau où elle est affectée." );
            }
            else
            {
                SoftContext.CurrentPeriod.removePromotion( _pTmp );
                InitializeOlv();
                reinitialisation();
            }
        }

        private void objectListView1_CellRightClick( object sender, BrightIdeasSoftware.CellRightClickEventArgs e )
        {
            contextMenuStrip1.Show( new System.Drawing.Point( Cursor.Position.X, Cursor.Position.Y - 30 ) );
            _pTmp = (Promotion)e.Model;
        }


    }
}
