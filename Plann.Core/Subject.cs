using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannIti
{
    internal class Subject
    {
        readonly string _name;
        int _numberOfSubjectInSemester;
        Teacher _referentTeacher;
        List<Promotion> _promotionConcerned;
        string _sector;
        string _color;
        internal string Name
        {
            get { return _name; }
        }
        internal Teacher ReferentTeacher
        {
            get { return _referentTeacher; }
        }
        internal int NumberOfSubjectInSemester
        {
            get { return _numberOfSubjectInSemester; }
        }
        internal List<Promotion> PromotionConcerned
        {
            get { return _promotionConcerned; }
        }
        internal string Sector
        {
            get { return _sector; }
        }
        internal string Color
        {
            get { return _color; }
        }
        internal Subject(string name, int numberOfSubject, Teacher referentTeacher, List<Promotion> listPromotion, string color, string sector )
        {
            if( String.IsNullOrWhiteSpace( name ) || String.IsNullOrWhiteSpace( color ) || String.IsNullOrWhiteSpace( sector ) ) throw new ArgumentNullException();
            if( numberOfSubject < 1 ) throw new ArgumentException( "Il ne peut pas y avoir moins de 1 créneau dans le semestre" );
            if( listPromotion.Capacity == 0 ) throw new ArgumentException( "La liste des promotions est vide" );
            if( referentTeacher == null ) throw new ArgumentException( "Le professeur référent est nul" );
            _promotionConcerned = new List<Promotion>();
            _name = name;
            _numberOfSubjectInSemester = numberOfSubject;
            _referentTeacher = referentTeacher;
            _promotionConcerned = listPromotion;
            _color = color;
            _sector = sector;
        }

        internal Subject( string name )
        {
            if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentNullException();
            _name = name;
        }

        internal Subject( string name, int numberOfSubject )
        {
            if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentNullException();
            if( numberOfSubject < 1 ) throw new ArgumentException( "Il ne peut pas y avoir moins de 1 créneau dans la semestre" );
            _name = name;
            _numberOfSubjectInSemester = numberOfSubject;
        }

        internal Subject( string name, int numberOfSubject, Teacher referentTeacher, List<Promotion> listPromotion, string sector )
        {
            if( String.IsNullOrWhiteSpace( name ) || String.IsNullOrWhiteSpace( sector ) ) throw new ArgumentNullException();
            if( numberOfSubject < 1 ) throw new ArgumentException( "Il ne peut pas y avoir moins de 1 créneau dans le semestre" );
            if( listPromotion.Capacity == 0 ) throw new ArgumentException( "La liste des promotions est vide" );
            _promotionConcerned = new List<Promotion>();
            _name = name;
            _numberOfSubjectInSemester = numberOfSubject;
            _referentTeacher = referentTeacher;
            _promotionConcerned = listPromotion;
            _sector = sector;

        }
    }
}
