using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plann.Core
{
    [Serializable]
    public class Teacher
    {
        readonly string _name;
        readonly string _mail;

        public Teacher(string name, string mail)
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

        #region Properties

        public string Name
        {
            get { return _name; }
        }


        public string Mail
        {
            get { return _mail; }
        }

        #endregion
        public override bool Equals( object obj )
        {
            if( obj == null ) throw new ArgumentNullException( "obj == null" );
            Teacher otherSub = obj as Teacher;

            if( otherSub == null ) throw new ArgumentException( "obj != Teacher" );
            return (this.Name == otherSub.Name);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
