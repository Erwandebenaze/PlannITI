using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plann.Core
{
    public class Soft
    {
        List<Room> _listRooms;
        List<Subject> _listSubjects;
        List<Teacher> _listTeachers;
        List<Period> _listPeriods;
        List<Slot> _listSlots;

        public Soft()
        {
            _listRooms = new List<Room>();
            _listSubjects = new List<Subject>();
            _listTeachers = new List<Teacher>();
            _listPeriods = new List<Period>();
            _listSlots = new List<Slot>();
            Teacher spi = new Teacher( "Spi", "spi@gmail.com" );
            Subject pi = new Subject("PI",spi,"red");
            addSubject( pi );
        }
        public List<Teacher> ListTeachers
        {
            get { return _listTeachers; }
        }

        public List<Subject> ListSubjects
        {
            get { return _listSubjects; }
        }
        public List<Subject> GetSubjects()
        {
            return _listSubjects;
        }
        public List<Room> ListRooms
        {
            get { return _listRooms; }
        }
        public List<Period> ListPeriods
        {
            get { return _listPeriods; }
        }
        public List<Slot> ListSlots
        {
            get { return _listSlots; }
        }



        public bool addRoom(Room room)
        {
            if( room == null ) throw new ArgumentNullException();
            _listRooms.Add( room );
            return true;
        }
        public bool removeRoom(Room room)
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

        public bool addPeriod( Period period )
        {
            if( period == null ) throw new ArgumentNullException();
            _listPeriods.Add( period );
            return true;
        }
        public bool removePeriod( Period period )
        {
            if( !_listPeriods.Contains( period ) ) throw new ArgumentException( "Le créneau  n'est pas dans la liste des créneaux." );
            _listPeriods.Remove( period );
            return true;
        }

        public bool editPeriod( Period periodToEdit, Period newPeriod )
        {
            if( !_listPeriods.Contains( periodToEdit ) ) throw new ArgumentException( "La salle n'est pas dans la liste des salles." );

            int index = _listPeriods.FindIndex( p => p == periodToEdit );
            removePeriod( periodToEdit );
            _listPeriods.Insert( index, newPeriod );
            return true;
        }

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
    }
}
