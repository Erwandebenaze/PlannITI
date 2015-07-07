using System;
using System.Windows.Forms;
using Plann.Core;
using System.Linq;

namespace Plann.Interface
{
    public partial class UcMgtRoom : UserControl
    {
        Room _rTmp;
        public UcMgtRoom()
        {
            InitializeComponent();
        }
        private void reinitialisation()
        {
            nameTextBox.Text = "";
            numberOfSeatsTextBox.Text = "";
            validateButton.Text = "Valider";
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
                this.objectListView1.SetObjects( SoftContext.CurrentPeriod.ListRooms );
            }
            catch( NullReferenceException e )
            {
                Console.Write( e );
            }
        }
        private void validateButton_Click( object sender, EventArgs e )
        {
            if( !String.IsNullOrWhiteSpace( nameTextBox.Text ) && !String.IsNullOrWhiteSpace( numberOfSeatsTextBox.Text ) )
            {
                if( SoftContext.CurrentPeriod.ListRooms.Contains( new Room( nameTextBox.Text, 5 ) ) )
                {
                    MessageBox.Show( "Cette salle a déjà été créée." );
                } else
                {
                    int numberOfSeats;
                    if( int.TryParse( numberOfSeatsTextBox.Text, out numberOfSeats ))
                    {
                        SoftContext.CurrentPeriod.addRoom( new Room( nameTextBox.Text, numberOfSeats ) );
                        InitializeOlv();
                        reinitialisation();
                    } else 
                    {
                        MessageBox.Show( "Le nombre de place entré n'est pas un nombre entier." );
                    }
                }
            }          
        }
        private void returnLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls[ SoftContext.CurrentPeriod.CurrentUcFilter ].Visible = true;
            reinitialisation();
            OnReload();
        }
        private void supprimerSalleToolStripMenuItem_Click( object sender, EventArgs e )
        {
            if( SoftContext.CurrentPeriod.ListSlots.Where( sl => sl.AssociatedRoom == _rTmp ).Any() )
            {
                MessageBox.Show( "Vous ne pouvez pas supprimer cette salle. Supprimer d'abord le créneau où elle est affectée." );
            }
            else
            {
                SoftContext.CurrentPeriod.removeRoom( _rTmp );
                InitializeOlv();
                reinitialisation();
            }
        }

        private void objectListView1_CellRightClick( object sender, BrightIdeasSoftware.CellRightClickEventArgs e )
        {
            contextMenuStrip1.Show( new System.Drawing.Point( Cursor.Position.X, Cursor.Position.Y - 30 ) );
            _rTmp = (Room)e.Model;
        }
    }
}
