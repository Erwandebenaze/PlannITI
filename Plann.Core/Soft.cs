using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Linq;


namespace Plann.Core
{
    [Serializable]
    public class Soft
    {
        Period _currentPeriod;
        List<Period> _listPeriod;

        public Soft()
        {
            //List<DateTime> listDateTime = new List<DateTime>();
            //_listPeriod = new List<Period>();

            //listDateTime.Add( new DateTime( 2015, 05, 08 ) );
            //listDateTime.Add( new DateTime( 2015, 05, 09 ) );
            //listDateTime.Add( new DateTime( 2015, 05, 01 ) );
            //listDateTime.Add( new DateTime( 2015, 05, 14 ) );
            //listDateTime.Add( new DateTime( 2015, 05, 15 ) );
            //Period p = new Period( this, "test2", new DateTime( 2015, 03, 10 ), new DateTime( 2015, 07, 10 ), listDateTime );
            //_currentPeriod = p;
            //_listPeriod.Add( p );
            //p.SavePeriod();
        }

        public List<Period> ListPeriod
        {
            get { return _listPeriod; }
            set { _listPeriod = value; }
        }
        public Period CurrentPeriod
        {
            get { return _currentPeriod; }
        }

        public void ChangePeriode( Period p )
        {
            _currentPeriod = p;
        }

    }
}
