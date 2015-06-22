﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plann.Core
{
    [Serializable]
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
            _numberOfStudents = numberOfStudents;

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
