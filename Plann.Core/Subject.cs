using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plann.Core
{
    public class Subject
    {
        readonly string _name;
        Teacher _referentTeacher;
        string _color;
        
        public Subject(string name, Teacher referentTeacher, string color )
        {
            if( String.IsNullOrWhiteSpace( name ) || String.IsNullOrWhiteSpace( color ) ) throw new ArgumentNullException();
            if( referentTeacher == null ) throw new ArgumentException( "Le professeur référent est nul" );
            _name = name;
            _referentTeacher = referentTeacher;
            _color = color;
        }

        public Subject( string name, string color )
        {
            if( String.IsNullOrWhiteSpace( name ) || String.IsNullOrWhiteSpace( color ) ) throw new ArgumentNullException();
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
        public string Color
        {
            get { return _color; }
        }

        #endregion
    }
    
}
