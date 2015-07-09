using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Plann.Core
{
    [Serializable]
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
        List<Promotion> _listPromotion;
        string _currentUcFilter;
        DateTime _currentViewMonthStart;
        DateTime _currentViewMonthEnd;
        Soft _mySoft;

        public Period(Soft mySoft, string name, DateTime begginningDate, DateTime endingDate, List<DateTime> listOfHolidays)
        {
            if( String.IsNullOrWhiteSpace( name ) ) throw new ArgumentException( "Name est null ou vide" );
            if( mySoft == null ) throw new ArgumentNullException( "mySoft est null" );
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
            _listPromotion = new List<Promotion>();
            _currentViewMonthStart = _begginningDate;
            _currentViewMonthEnd = _currentViewMonthStart.AddDays(22);
            _mySoft = mySoft;

            //Teacher spi = new Teacher( "Spi", "spi@gmail.com" );
            //Subject pi = new Subject( "PI", spi, Color.Red );
            //addSubject( pi );
            //Room e5 = new Room( "E01", 40 );
            //Promotion iti = new Promotion( "ItiTruc", "iti@intech.fr", 20, 10,10);

            //addTeacher( spi );
            //addRoom( e5 );
            //addPromotion( iti );
            //addSlot( new Slot( new DateTime( 2015, 03, 20 ), true, e5, pi, spi, _listPromotion, true ) );
            //addSlot( new Slot( new DateTime( 2015, 03, 20 ), false, e5, pi, spi, _listPromotion, false ) );
        }

        private DateTime GetFirstMonth( DateTime date )
        {
            while( date.Day > 1 )
            {
                date = date.AddDays( -1 );
            }
            return date;
        }

        public bool addHoliday(DateTime date)
        {
            if( date == null ) throw new ArgumentNullException();
            _listOfHolidays.Add( date );
            return true;
        }

        #region Properties
        public String CurrentUcFilter
        {
            get { return _currentUcFilter; }
            set { _currentUcFilter = value; }
        }
        public Soft MySoft
        {
            get { return _mySoft; }
        }
        public string Name
        {
            get { return _name; }
        }
        public List<Promotion> ListPromotion
        {
            get { return _listPromotion; }
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
        public DateTime CurrentViewMonthEnd
        {
            get { return _currentViewMonthEnd; }
        }
        public DateTime CurrentViewMonthStart
        {
            get { return _currentViewMonthStart; }
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
            if( !_listSubjects.Contains( subjectToEdit ) ) throw new ArgumentException( "La matière n'est pas dans la liste des matières." );

            int index = _listSubjects.FindIndex( s => s == subjectToEdit );
            removeSubject( subjectToEdit );
            _listSubjects.Insert( index, newSubject );
            return true;
        } 
        #endregion
        #region Promotion
        public bool addPromotion( Promotion promotion )
        {
            if( promotion == null ) throw new ArgumentNullException();
            _listPromotion.Add( promotion );
            return true;
        }
        public bool removePromotion( Promotion promotion )
        {
            if( !_listPromotion.Contains( promotion ) ) throw new ArgumentException( "La promotion n'est pas dans la liste des promotions." );
            _listPromotion.Remove( promotion );
            return true;
        }
        public bool editPromotion( Promotion promotionToEdit, Promotion newPromotion )
        {
            if( !_listPromotion.Contains( promotionToEdit ) ) throw new ArgumentException( "La promotion n'est pas dans la liste des promotions." );

            int index = _listPromotion.FindIndex( s => s == promotionToEdit );
            removePromotion( promotionToEdit );
            _listPromotion.Insert( index, newPromotion );
            return true;
        } 
        #endregion
        #endregion

        public void SavePeriod()
        {
            IFormatter formatter = new BinaryFormatter();
            // CHANGE ICI
            
            Stream stream = new FileStream( @"..\..\..\Sauvegardes\" + this.Name + ".bin", FileMode.Create, FileAccess.Write, FileShare.None );
            try
            {
                formatter.Serialize( stream, this );
            }
            catch (SerializationException e)
            {
                Console.WriteLine("Problème de sérialisation dans SavePeriod. "+ e );
            }
            stream.Close();
        }
        public void SaveTmpPeriod()
        {
            IFormatter formatter = new BinaryFormatter();
            // CHANGE ICI
            Stream stream = new FileStream( @"..\..\..\Sauvegardes\" + this.Name + "Tmp.bin", FileMode.Create, FileAccess.Write, FileShare.None );
            try
            {
                formatter.Serialize( stream, this );
            }
            catch( SerializationException e )
            {
                Console.WriteLine( "Problème de sérialisation dans SavePeriodTmp. " + e );
            }
            Console.WriteLine( DateTime.Now + " : Fichier " + this.Name + "Tmp.bin sauvegardé." );
            stream.Close();
        }
        public void DeleteTmpPeriod()
        {
            // CHANGE ICI
            if( System.IO.File.Exists( @"..\..\..\Sauvegardes\" + this.Name + "Tmp.bin" ) )
            {
                try
                {
                    System.IO.File.Delete( @"..\..\..\Sauvegardes\" + this.Name + "Tmp.bin" );
                }
                catch( System.IO.IOException e )
                {
                    Console.WriteLine( e.Message );
                    return;
                }
            }
        }
        public void DeleteTmpPeriod(string fileName)
        {
            if( System.IO.File.Exists( fileName ))
            {
                try
                {
                    System.IO.File.Delete( fileName);
                }
                catch( System.IO.IOException e )
                {
                    Console.WriteLine( e.Message );
                    return;
                }
            }
        }
        //public void SetNextMonthView()
        //{
        //    if( _currentViewMonthEnd.AddMonths( 1 ) < _endingDate )
        //    {
        //        _currentViewMonthEnd = _currentViewMonthEnd.AddMonths( 1 );
        //        _currentViewMonthStart = _currentViewMonthStart.AddMonths( 1 );
        //    }
        //    else
        //    {
        //        _currentViewMonthEnd = _endingDate;
        //        _currentViewMonthStart = _endingDate.AddMonths( -1 );
        //    }
        //}
        //public void SetPreviousMonthView()
        //{
        //    if( _currentViewMonthStart.AddMonths( -1 ) > _begginningDate )
        //    {
        //        _currentViewMonthEnd = _currentViewMonthEnd.AddMonths( -1 );
        //        _currentViewMonthStart = _currentViewMonthStart.AddMonths( -1 );
        //    }
        //    else
        //    {
        //        _currentViewMonthEnd = _begginningDate.AddMonths( 1 );
        //        _currentViewMonthStart = _begginningDate;
        //    }
        //}

        public void SetNextMonthView()
        {
            if( _currentViewMonthEnd.AddDays( 22 ) < _endingDate )
            {
                _currentViewMonthEnd = _currentViewMonthEnd.AddDays( 22 );
                _currentViewMonthStart = _currentViewMonthStart.AddDays( 22 );
            }
            else
            {
                _currentViewMonthEnd = _endingDate;
                _currentViewMonthStart = _endingDate.AddDays( -22 );
            }
        }
        public void SetPreviousMonthView()
        {
            if( _currentViewMonthStart.AddDays( -22 ) > _begginningDate )
            {
                _currentViewMonthEnd = _currentViewMonthEnd.AddDays( -22 );
                _currentViewMonthStart = _currentViewMonthStart.AddDays( -22 );
            }
            else
            {
                _currentViewMonthEnd = _begginningDate.AddDays( 22 );
                _currentViewMonthStart = _begginningDate;
            }
        }
    }
}
