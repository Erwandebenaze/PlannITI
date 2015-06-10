using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannIti
{
    class Slot
    {
        Room _associatedRoom;
        DateTime _date;
        bool _morning;
        Subject _associatedSubject;
        internal Room AssociatedRoom
        {
            get { return _associatedRoom; }
        }
        internal Subject AssociatedSubject
        {
            get { return _associatedSubject; }
        }
        internal bool Morning
        {
            get { return _morning; }
        }
        internal DateTime Date
        {
            get { return _date; }
        }
        internal Slot(DateTime date, bool morning, Room associatedRoom, Subject associatedSubject)
        {
            if( date == null || associatedRoom == null || associatedSubject == null ) throw new ArgumentNullException();
            _date = date;
            _morning = morning;
            _associatedRoom = associatedRoom;
            _associatedSubject = associatedSubject;
        }
    }
}
