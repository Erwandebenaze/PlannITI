using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plann.Core
{
    public class Period
    {
        string _name;
        DateTime _begginningDate;
        DateTime _endingDate;
        List<DateTime> _listOfHolidays;

        public Period( string name, DateTime begginningDate, DateTime endingDate, List<DateTime> listOfHolidays)
        {
            if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentException( "Name est null ou vide" );
            if( begginningDate == null || endingDate == null ) throw new ArgumentNullException();
            _name = name;
            _begginningDate = begginningDate;
            _endingDate = endingDate;
            _listOfHolidays = new List<DateTime>();
            _listOfHolidays = listOfHolidays;
        }

        public bool addHoliday(DateTime date)
        {
            if( date == null ) throw new ArgumentNullException();
            _listOfHolidays.Add( date );
            return true;
        }
    }
}
