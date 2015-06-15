using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plann.Core
{
    public class Promotion
    {
        readonly string _name;
        int _numberOfStudents;
        string _mail;

        public Promotion(string name, string mail, int numberOfStudents)
        {
            if( String.IsNullOrWhiteSpace( name ) || String.IsNullOrWhiteSpace( mail ) ) throw new ArgumentNullException();
            if( !IsValidEmail( mail ) ) throw new ArgumentException( "La chaine entrée n'est pas un mail" );
            if( numberOfStudents < 4 ) throw new ArgumentException( "Il ne peut pas y avoir moins de 4 étudiants dans la promotion" );
            _name = name;
            _mail = mail;

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

        #region Properties

        public string Name
        {
            get { return _name; }
        }
        public int NumberOfStudents
        {
            get { return _numberOfStudents; }
            set { _numberOfStudents = value; }
        }

        public string Mail
        {
            get { return _mail; }
        }

        #endregion
        
    }
}
