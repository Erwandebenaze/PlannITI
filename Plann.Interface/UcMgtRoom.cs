using System;
using System.Windows.Forms;
using Plann.Core;

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
                if( SoftContext.CurrentPeriod.ListRooms.Contains( new Room( nameTextBox.Text, 5 ) ) && validateButton.Text == "Valider" )
                {
                    MessageBox.Show( "Cette salle a déjà été créée." );
                } else
                {
                    int numberOfSeats;
                    if( int.TryParse( numberOfSeatsTextBox.Text, out numberOfSeats ) && validateButton.Text == "Valider" )
                    {
                        SoftContext.CurrentPeriod.addRoom( new Room( nameTextBox.Text, numberOfSeats ) );
                        InitializeOlv();
                        reinitialisation();
                    }
                    else if( int.TryParse( numberOfSeatsTextBox.Text, out numberOfSeats ) && validateButton.Text == "Modifier" )
                    {
                        SoftContext.CurrentPeriod.editRoom( _rTmp, new Room( nameTextBox.Text, numberOfSeats ) );
                        InitializeOlv();
                        validateButton.Text = "Valider";
                        delete.Visible = false;
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

        private void delete_Click( object sender, EventArgs e )
        {
            SoftContext.CurrentPeriod.ListRooms.Remove( _rTmp );
            InitializeOlv();
            delete.Visible = false; 
            reinitialisation();
        }

        private void objectListView1_CellClick( object sender, BrightIdeasSoftware.CellClickEventArgs e )
        {
            if( e.Model != null )
            {
                _rTmp = (Room)e.Model;
                nameTextBox.Text = _rTmp.Name;
                numberOfSeatsTextBox.Text = _rTmp.NumberOfSeats.ToString();
                validateButton.Text = "Modifier";
                delete.Visible = true;
            }

        }

        private void objectListView1_CellEditStarting( object sender, BrightIdeasSoftware.CellEditEventArgs e )
        {
            objectListView1.CellEditActivation = BrightIdeasSoftware.ObjectListView.CellEditActivateMode.DoubleClick;
            MessageBox.Show( "Fesses" );
        }
    }
}
