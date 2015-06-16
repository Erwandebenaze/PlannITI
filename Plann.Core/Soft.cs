using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Plann.Core
{
    public class Soft
    {
        List<Promotion> _listPromotion;
            _listPromotion = new List<Promotion>();
            
            // Test objects TO REMOVE
            Room e5 = new Room( "E01", 40 );
            Promotion iti = new Promotion( "ItiTruc", "iti@intech.fr", 20 );

            addTeacher( spi );
            addRoom( e5 );
            addPromotion( iti );

        #region Properties

        public List<Promotion> ListPromotion
        {
            get { return _listPromotion; }
        }

        Period _currentPeriod;

        public Soft()
        {
            List<DateTime> listDateTime= new List<DateTime>();
            listDateTime.Add(new DateTime(2015,05,08));
            listDateTime.Add(new DateTime(2015,05,09));
            listDateTime.Add(new DateTime(2015,05,01));
            listDateTime.Add(new DateTime(2015,05,14));
            listDateTime.Add(new DateTime(2015,05,15));
            _currentPeriod = new Period( "2015M", new DateTime( 2015, 03, 10 ), new DateTime( 2015, 07, 10 ), listDateTime );
        }

        public Period CurrentPeriod
        {
            get { return _currentPeriod; }
        }
            return true;
        }
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
    }
}
