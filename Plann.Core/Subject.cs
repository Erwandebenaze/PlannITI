using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Plann.Core
{
    public class Subject
    {
        readonly string _name;
        Teacher _referentTeacher;
        Color _color;
        public string Name
        {
            get { return _name; }
        }
        public Teacher ReferentTeacher
        {
            get { return _referentTeacher; }
        }
        public Color Color
        {
            get { return _color; }
        }
        public Subject(string name, Teacher referentTeacher, Color color )
        {
            if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentNullException();
            if( referentTeacher == null ) throw new ArgumentException( "Le professeur référent est nul" );
            if( color == null ) throw new ArgumentException( "La couleur est nulle" );
            _name = name;
            _referentTeacher = referentTeacher;
            _color = color;
        }

        public Subject( string name, Color color )
        {
            if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentNullException();
            if( color == null ) throw new ArgumentException( "La couleur est nulle" );
            _name = name;
            _color = color;
        }

        }
    
}
