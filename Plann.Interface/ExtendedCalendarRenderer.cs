using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Calendar;

namespace Plann.Interface
{
    class ExtendedCalendarRenderer : CalendarProfessionalRenderer
    {
        List<DateTime> _holidays = new List<DateTime>();

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

        internal List<DateTime> Holidays
        {
            get { return _holidays; }
            set { _holidays = value; }
        }

        public override void OnDrawItemText( CalendarRendererBoxEventArgs e )
        {
            int textHeight = TextRenderer.MeasureText( e.Text, Calendar.Font, e.Bounds.Size, TextFormatFlags.WordBreak ).Height;
            int nbLines = CountLines( e.Text );
            double divider = 1;

            if( nbLines == 4 )
                divider = 7.4;
            else if( nbLines == 5 )
                divider = 7.2;
            double textSize = StandardItemHeight / ( textHeight / divider );
            Font newFont = new Font( Calendar.Font.FontFamily, (float)textSize );
            e.Font = newFont;
            base.OnDrawItemText( e );
        }

        public override void OnDrawDay( CalendarRendererDayEventArgs e )
        {
            bool isHoliday = false;
            foreach( DateTime holiday in _holidays )
            {
                if( holiday.Date == e.Day.Date )
                    isHoliday = true;
            }
            Rectangle r = e.Day.Bounds;

            if( isHoliday )
            {
                using( Brush b = new SolidBrush( Color.Gray ) )
                {
                    e.Graphics.FillRectangle( b, r );
                }
            }
            else if( e.Day.Selected )
            {
                using( Brush b = new SolidBrush( ColorTable.DayBackgroundSelected ) )
                {
                    e.Graphics.FillRectangle( b, r );
                }
            }
            else if( e.Day.Date.Month % 2 == 0 )
            {
                using( Brush b = new SolidBrush( ColorTable.DayBackgroundEven ) )
                {
                    e.Graphics.FillRectangle( b, r );
                }
            }
            else
            {
                using( Brush b = new SolidBrush( ColorTable.DayBackgroundOdd ) )
                {
                    e.Graphics.FillRectangle( b, r );
                }
            }

            base.OnDrawDay( e );
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
