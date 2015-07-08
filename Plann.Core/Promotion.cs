using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plann.Core
{
    [Serializable]
    public class Promotion
    {
        string _name;
        int _numberOfStudents;
        string _mail;
        int _numberOfIl;
        int _numberOfSr;


        public Promotion(string name, string mail, int numberOfStudents, int numberOfIL = 0, int numberOfSR = 0)
        {
            if( String.IsNullOrWhiteSpace( name ) || String.IsNullOrWhiteSpace( mail ) ) throw new ArgumentNullException();
            if( !IsValidEmail( mail ) ) throw new ArgumentException( "La chaine entrée n'est pas un mail" );
            if( numberOfStudents < 4 ) throw new ArgumentException( "Il ne peut pas y avoir moins de 4 étudiants dans la promotion" );
            if( numberOfIL < 0 ) throw new ArgumentException( "Il ne peut pas y avoir un nombre négatif de IL" );
            if( numberOfSR < 0 ) throw new ArgumentException( "Il ne peut pas y avoir un nombre négatif de SR" );
            if( (numberOfIL + numberOfSR) != numberOfStudents && (numberOfIL + numberOfSR) != 0) throw new ArgumentException( "La somme des IL et des SR doit être égale au nombre d'élèves ou égale à 0." );
           
            _name = name;
            _mail = mail;
            _numberOfStudents = numberOfStudents;

            _numberOfIl = numberOfIL;
            _numberOfSr = numberOfSR;

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

        public override bool Equals( object obj )
        {
            if( obj == null ) throw new ArgumentNullException( "obj == null" );
            Promotion otherPromotion = obj as Promotion;

            if( otherPromotion == null ) throw new ArgumentException( "obj != Promotion" );
            return (this.Name == otherPromotion.Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #region Properties

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int NumberOfStudents
        {
            get { return _numberOfStudents; }
            set { _numberOfStudents = value; }
        }

        public string Mail
        {
            get { return _mail; }
            set { _mail = value; }
        }
        public int NumberOfIl
        {
            get { return _numberOfIl; }
            set { _numberOfIl = value; }
        }
        public int NumberOfSr
        {
            get { return _numberOfSr; }
            set { _numberOfSr = value; }
        }
        #endregion
        
    }
}
