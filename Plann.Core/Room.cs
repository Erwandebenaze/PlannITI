using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plann.Core
{
    public class Room
    {
        int _numberOfSeats;
        string _name;

        public Room(string name, int numberOfSeats)
        {
            if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentNullException( "Nom de la salle vide" );
            if( numberOfSeats <= 4 ) throw new ArgumentException( "Le minimum de place assises est de 4." );

            _name = name;
            _numberOfSeats = numberOfSeats;
        }
        public int NumberOfSeats
        {
            get { return _numberOfSeats; }
            set { _numberOfSeats = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

    }
}
