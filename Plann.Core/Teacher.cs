using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannIti
{
    class Teacher
    {
        readonly string _name;
        readonly string _mail;

        internal Teacher(string name, string mail)
        {
            if( String.IsNullOrWhiteSpace( name )|| String.IsNullOrWhiteSpace( mail )) throw new ArgumentNullException();
            if( !IsValidEmail( mail ) ) throw new ArgumentException( "La chaine entrée n'est pas un mail" );
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
        internal string Name
        {
            get { return _name; }
        }


        internal string Mail
        {
            get { return _mail; }
        }

    }
}
