using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Plann.Core
{
    public class Soft
    {
        List<Room> _listRooms;
        List<Subject> _listSubjects;
        List<Teacher> _listTeachers;

        public Soft()
        {
            _listRooms = new List<Room>();
            _listSubjects = new List<Subject>();
            _listTeachers = new List<Teacher>();
            Teacher spi = new Teacher( "Spi", "spi@gmail.com" );
            Subject pi = new Subject("PI",spi,Color.Red);
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
        public bool addSubject( Subject subject )
        {
            if( subject == null ) throw new ArgumentNullException();
            _listSubjects.Add( subject );
            return true;
        }
        public bool removeSubject( Subject subject )
        {
            if( !_listSubjects.Contains( subject ) ) throw new ArgumentException( "La matière  n'est pas dans la liste des matières." );
            _listSubjects.Remove( subject );
            return true;
        }
    }
}
