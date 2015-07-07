using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;
using System.Windows.Media;

namespace Plann.Interface
{
    class ExtendedCalendarRenderer : CalendarProfessionalRenderer
    {

        public ExtendedCalendarRenderer( Calendar calendar )
            : base( calendar )
        {
        }

        public override int StandardItemHeight
        {
            get
            {
                return ( Calendar.Days[ 0 ].Bounds.Height - Calendar.Days[ 0 ].HeaderBounds.Height ) / 2;
            }
        }

        public override void OnDrawItemText( CalendarRendererBoxEventArgs e )
        {
            int nbLines = CountLines( e.Text );
            double divider = 1;
            if( nbLines < 4 )
                divider = 14.1;
            else if( nbLines < 5 )
                divider = 17.5;
            else if( nbLines < 6 )
                divider = 22;
            else if( nbLines < 7 )
                divider = 29;

            double textSize = Calendar.Days[ 0 ].Bounds.Height / divider;
            Font newFont = new Font( Calendar.Font.FontFamily, (float)textSize );
            e.Font = newFont;
            base.OnDrawItemText( e );
        }
        int CountLines( string s )
        {
            int n = 0;
            foreach( var c in s )
            {
                if( c == '\n' ) n++;
            }
            return n + 1;
        }
    }
}
