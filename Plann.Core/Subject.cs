using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace Plann.Core
{
    [Serializable]
    public class Subject
    {
        readonly string _name;
        Teacher _referentTeacher;
        Color _color;
        
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

        #region Properties

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

        #endregion

        public override bool Equals( object obj )
        {
            if( obj == null ) throw new ArgumentNullException( "obj == null" );
            Subject otherSub = obj as Subject;

            if( otherSub == null ) throw new ArgumentException( "obj != Subject" );
            return (this.Name == otherSub.Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    
}
