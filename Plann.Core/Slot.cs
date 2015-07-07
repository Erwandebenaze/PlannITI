using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Calendar;


namespace Plann.Core
{
    [Serializable]
    public class Slot
    {
        Room _associatedRoom;
        DateTime _date;
        bool _morning;
        Subject _associatedSubject;
        Teacher _associatedTeacher;
        List<Promotion> _associatedPromotionList;
        bool? _isIl;
        string _additionnalText;
        bool isOnView;
        // CalendarItem _currentCalendarItem;

        public Slot( DateTime date, bool morning, Room associatedRoom, Subject associatedSubject, Teacher associatedTeacher, List<Promotion> promotionAssociatedList, bool? il, string additionnalText )
        {
            if( date == null || associatedRoom == null || associatedSubject == null ) throw new ArgumentNullException();
            _date = date;
            _morning = morning;
            _associatedRoom = associatedRoom;
            _associatedSubject = associatedSubject;
            _associatedTeacher = associatedTeacher;
            _associatedPromotionList = promotionAssociatedList;
            _isIl = il;
            _additionnalText = additionnalText;
        }

        public Slot( DateTime date, bool morning, Room associatedRoom, Subject associatedSubject, Teacher associatedTeacher, List<Promotion> promotionAssociatedList, bool? il )
        {
            if( date == null || associatedRoom == null || associatedSubject == null ) throw new ArgumentNullException();
            _date = date;
            _morning = morning;
            _associatedRoom = associatedRoom;
            _associatedSubject = associatedSubject;
            _associatedTeacher = associatedTeacher;
            _associatedPromotionList = promotionAssociatedList;
            _isIl = il;
        }

        #region Properties

        public Room AssociatedRoom
        {
            get { return _associatedRoom; }
        }
        public Subject AssociatedSubject
        {
            get { return _associatedSubject; }
        }
        public Teacher AssociatedTeacher
        {
            get { return _associatedTeacher; }
        }
        public bool Morning
        {
            get { return _morning; }
        }
        public DateTime Date
        {
            get
            {
                return _date.AddHours( _morning ? 9 : 13.5 );
            }
            internal set { _date = value; }
        }
        public List<Promotion> AssociatedPromotionList
        {
            get { return _associatedPromotionList; }
        }
        public bool? IsIl
        {
            get { return _isIl; }
        }
        public string AdditionnalText
        {
            get { return _additionnalText; }
            set { _additionnalText = value; }
        }
        //public CalendarItem CurrentCalendarItem
        //{
        //    get { return _currentCalendarItem; }
        //    set { _currentCalendarItem = value; }
        //}
        public bool IsOnView
        {
            get { return isOnView; }
            set { isOnView = value; }
        }
        #endregion
    }
}
