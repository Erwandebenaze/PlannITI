using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlannIti
{
    public class Plann
    {
        List<Room> _listRooms = new List<Room>();
        List<Subject> _listSubjects = new List<Subject>();
        List<Teacher> _listTeachers = new List<Teacher>();

        internal List<Teacher> ListTeachers
        {
            get { return _listTeachers; }
        }

        internal List<Subject> ListSlots
        {
            get { return _listSubjects; }
        }
        internal List<Room> ListRooms
        {
            get { return _listRooms; }
        }

        internal bool addRoom(Room room)
        {
            if( room == null ) throw new ArgumentNullException();
            _listRooms.Add( room );
            return true;
        }
        internal bool removeRoom(Room room)
        {
            if( !_listRooms.Contains( room ) ) throw new ArgumentException( "La salle n'est pas dans la liste des salles." );
            _listRooms.Remove( room );
            return true;
        }

        internal bool addTeacher( Teacher teacher )
        {
            if( teacher == null ) throw new ArgumentNullException();
            _listTeachers.Add( teacher );
            return true;
        }
        internal bool removeTeacher( Teacher teacher )
        {
            if( !_listTeachers.Contains( teacher ) ) throw new ArgumentException( "Le prof n'est pas dans la liste des profs." );
            _listTeachers.Remove( teacher );
            return true;
        }
        internal bool addSubject( Subject subject )
        {
            if( subject == null ) throw new ArgumentNullException();
            _listSubjects.Add( subject );
            return true;
        }
        internal bool removeSubject( Subject subject )
        {
            if( !_listSubjects.Contains( subject ) ) throw new ArgumentException( "La matière  n'est pas dans la liste des matières." );
            _listSubjects.Remove( subject );
            return true;
        }
    }
}
