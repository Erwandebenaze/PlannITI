using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plann.Core
{
    public class Slot
    {
        Room _associatedRoom;
        DateTime _date;
        bool _morning;
        Subject _associatedSubject;
        List<Promotion> _associatedPromotionList;

        #region Properties

        public Room AssociatedRoom
        {
            get { return _associatedRoom; }
        }
        public Subject AssociatedSubject
        {
            get { return _associatedSubject; }
        }
        public bool Morning
        {
            get { return _morning; }
        }
        public DateTime Date
        {
            get { return _date; }
        } 

        #endregion

        public Slot(DateTime date, bool morning, Room associatedRoom, Subject associatedSubject, List<Promotion> promotionAssociatedList)
        {
            if( date == null || associatedRoom == null || associatedSubject == null ) throw new ArgumentNullException();
            _date = date;
            _morning = morning;
            _associatedRoom = associatedRoom;
            _associatedSubject = associatedSubject;
            _associatedPromotionList = promotionAssociatedList;
        }
    }
}
