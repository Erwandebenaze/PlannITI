using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Plann.Core
{
    static public class PeriodLoader
    {
        static public Period Load( string periodName )
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream;

            if( periodName.Contains( ".bin" ) )
            {
                stream = new FileStream( periodName, FileMode.Open, FileAccess.Read, FileShare.Read );
            } else
            {
                stream = new FileStream( @"..\..\Sauvegardes\" + periodName + ".bin", FileMode.Open, FileAccess.Read, FileShare.Read );
            }

            Period myPeriod = (Period)formatter.Deserialize( stream );
            stream.Close();
            return myPeriod;
        }


        //IReadOnlyList<string>
    }
}
