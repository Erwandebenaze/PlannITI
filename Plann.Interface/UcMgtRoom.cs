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
    public partial class UcMgtRoom : UserControl
    {
        public UcMgtRoom()
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
                this.objectListView1.SetObjects( SoftContext.CurrentSoft.ListRooms );
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
            if( !String.IsNullOrWhiteSpace( nameTextBox.Text ) && !String.IsNullOrWhiteSpace( numberOfSeatsTextBox.Text ) )
            {
                if( SoftContext.CurrentSoft.ListRooms.Contains( new Room( nameTextBox.Text,5) ) )
                {
                    MessageBox.Show( "Cette salle a déjà été créée." );

                } else
                {
                    int numberOfSeats;
                    if (int.TryParse(numberOfSeatsTextBox.Text, out numberOfSeats))
                    {
                        SoftContext.CurrentSoft.addRoom( new Room( nameTextBox.Text, numberOfSeats ) );
                        InitializeOlv();
                    } else
                    {
                        MessageBox.Show( "Le nombre de place entré n'est pas un nombre entier." );
                    }
                    

                }
            }
            
        }
    }
}
