using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Plann.Core
{
    public class Period
    {
        string _name;
        DateTime _begginningDate;
        DateTime _endingDate;
        List<DateTime> _listOfHolidays;
        List<Slot> _listSlots;
        List<Room> _listRooms;
        List<Subject> _listSubjects;
        List<Teacher> _listTeachers;

        public Period( string name, DateTime begginningDate, DateTime endingDate, List<DateTime> listOfHolidays)
        {
            if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentException( "Name est null ou vide" );
            if( begginningDate == null || endingDate == null ) throw new ArgumentNullException();
            _name = name;
            _begginningDate = begginningDate;
            _endingDate = endingDate;
            _listOfHolidays = new List<DateTime>();
            _listOfHolidays = listOfHolidays;
            _listRooms = new List<Room>();
            _listSubjects = new List<Subject>();
            _listTeachers = new List<Teacher>();
            _listSlots = new List<Slot>();
            Teacher spi = new Teacher( "Spi", "spi@gmail.com" );
            Subject pi = new Subject( "PI", spi, Color.Red );
            addSubject( pi );
        }

        public bool addHoliday(DateTime date)
        {
            if( date == null ) throw new ArgumentNullException();
            _listOfHolidays.Add( date );
            return true;
        }

        #region Properties

        public string Name
        {
            get { return _name; }
        }

        public DateTime BegginningDate
        {
            get { return _begginningDate; }
        }
        public List<Teacher> ListTeachers
        {
            get { return _listTeachers; }
        }
        public List<Subject> ListSubjects
        {
            get { return _listSubjects; }
        }

        public List<Room> ListRooms
        {
            get { return _listRooms; }
        }
        public DateTime EndingDate
        {
            get { return _endingDate; }
        }

        public List<DateTime> ListOfHolidays
        {
            get { return _listOfHolidays; }
        }
        public List<Slot> ListSlots
        {
            get { return _listSlots; }
        }
        #endregion

        #region Actions sur listes

        #region Slot
        public bool addSlot( Slot slot )
        {
            if( slot == null ) throw new ArgumentNullException();
            _listSlots.Add( slot );
            return true;
        }
        public bool removeSlot( Slot slot )
        {
            if( !_listSlots.Contains( slot ) ) throw new ArgumentException( "Le créneau  n'est pas dans la liste des créneaux." );
            _listSlots.Remove( slot );
            return true;
        }

        public bool editSlot( Slot slotToEdit, Slot newSlot )
        {
            if( !_listSlots.Contains( slotToEdit ) ) throw new ArgumentException( "La salle n'est pas dans la liste des salles." );

            int index = _listSlots.FindIndex( s => s == slotToEdit );
            removeSlot( slotToEdit );
            _listSlots.Insert( index, newSlot );
            return true;
        } 
        #endregion
        #region Room
        public bool addRoom( Room room )
        {
            if( room == null ) throw new ArgumentNullException();
            _listRooms.Add( room );
            return true;
        }
        public bool removeRoom( Room room )
        {
            if( !_listRooms.Contains( room ) ) throw new ArgumentException( "La salle n'est pas dans la liste des salles." );
            _listRooms.Remove( room );
            return true;
        }

        public bool editRoom( Room roomToEdit, Room newRoom )
        {
            if( !_listRooms.Contains( roomToEdit ) ) throw new ArgumentException( "La salle n'est pas dans la liste des salles." );

            int index = _listRooms.FindIndex( r => r == roomToEdit );
            removeRoom( roomToEdit );
            _listRooms.Insert( index, newRoom );
            return true;
        } 
        #endregion
        #region Teacher
        public bool addTeacher( Teacher teacher )
        {
            if( teacher == null ) throw new ArgumentNullException();
            _listTeachers.Add( teacher );
            return true;
        }
        public bool removeTeacher( Teacher teacher )
        {
            if( !_listTeachers.Contains( teacher ) ) throw new ArgumentException( "Le prof n'est pas dans la liste des profs." );
            _listTeachers.Remove( teacher );
            return true;
        }

        public bool editTeacher( Teacher teacherToEdit, Teacher newTeacher )
        {
            if( !_listTeachers.Contains( teacherToEdit ) ) throw new ArgumentException( "La salle n'est pas dans la liste des salles." );

            int index = _listTeachers.FindIndex( t => t == teacherToEdit );
            removeTeacher( teacherToEdit );
            _listTeachers.Insert( index, newTeacher );
            return true;
        } 
        #endregion
        #region Subject
        public bool addSubject( Subject subject )
        {
            if( subject == null ) throw new ArgumentNullException();
            _listSubjects.Add( subject );
            return true;
        }
        public bool removeSubject( Subject subject )
        {
            if( !_listSubjects.Contains( subject ) ) throw new ArgumentException( "La période  n'est pas dans la liste des périodes." );
            _listSubjects.Remove( subject );
            return true;
        }

        public bool editSubject( Subject subjectToEdit, Subject newSubject )
        {
            if( !_listSubjects.Contains( subjectToEdit ) ) throw new ArgumentException( "La salle n'est pas dans la liste des salles." );

            int index = _listSubjects.FindIndex( s => s == subjectToEdit );
            removeSubject( subjectToEdit );
            _listSubjects.Insert( index, newSubject );
            return true;
        } 
        #endregion
        #endregion
    
    }
}
