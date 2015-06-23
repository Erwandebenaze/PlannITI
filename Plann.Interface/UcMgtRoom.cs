using System;
using System.Windows.Forms;
using Plann.Core;

namespace Plann.Interface
{
    public partial class UcMgtRoom : UserControl
    {
        public UcMgtRoom()
        {
            InitializeComponent();
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
                if( SoftContext.CurrentPeriod.ListRooms.Contains( new Room( nameTextBox.Text,5) ) )
                {
                    MessageBox.Show( "Cette salle a déjà été créée." );
                } else
                {
                    int numberOfSeats;
                    if (int.TryParse(numberOfSeatsTextBox.Text, out numberOfSeats))
                    {
                        SoftContext.CurrentPeriod.addRoom( new Room( nameTextBox.Text, numberOfSeats ) );
                        InitializeOlv();
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
            OnReload();
        }
    }
}
