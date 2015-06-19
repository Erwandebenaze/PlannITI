using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plann.Core;
using System.Windows.Forms.Calendar;

namespace Plann.Interface
{
    public partial class PlannITI : Form, IPlannContext
    {
        Soft _mySoft;

        public PlannITI()
        {
            _mySoft = new Soft();
            _mySoft.CurrentUcFilter = "ucPromotion1";
            InitializeComponent();
            fillCalendarFromSlots();

            calendar.ItemCreating += calendar_ItemCreating;
            calendar.ItemCreated += calendar_ItemCreated;
            calendar.ItemClick += calendar_ItemClick;
        }

        public Soft CurrentSoft
        {
            get { return _mySoft; }
        }

        void calendar_ItemClick( object sender, CalendarItemEventArgs e )
        {
            Console.WriteLine( e.Item.Text );
            foreach( Slot slot in _mySoft.ListSlots )
            {
                Console.WriteLine( slot.Date + " " + slot.AssociatedSubject + " " + slot.AssociatedTeacher + " " + slot.AssociatedRoom + " " + slot.Morning );
            }
        }

        void calendar_ItemCreating( object sender, CalendarItemCancelEventArgs e )
        {
            DateTime beg = e.Item.StartDate;
            e.Item.EndDate = beg + TimeSpan.FromHours( 3.5 );

            DateTime day = beg.Date;
            int nb = calendar.Items.Count( i => i.StartDate.Date == day );

            if( nb > 1 ) e.Cancel = true;

            //Teacher teacher = _mySoft.ListTeachers.Where( t => t.Name == ucPromotion1.teacherComboBox.Text ).SingleOrDefault();
            //Subject subject = _mySoft.ListSubjects.Where(s => s.Name == ucPromotion1.subjectComboBox.Text).Single();
            //Room room = _mySoft.ListRooms.Where( r => r.Name == ucPromotion1.roomComboBox.Text ).Single();
            //List<Promotion> promotions = _mySoft.ListPromotion.Where( p => p.Name == ucPromotion1.promotionComboBox.Text ).ToList();
            //DateTime date = e.Item.StartDate;
            //bool morning = true;
            //Slot newSlot = new Slot( date, morning, room, subject, teacher, promotions);

            // calendar.Items.Add( getCalendarItemFromSlot( newSlot ) );
            e.Item.Text = "Test" + Environment.NewLine + "Test 2" + Environment.NewLine + "Test 3";

            CalendarRenderer cr = new CalendarRenderer( calendar );
            cr.ItemTextMargin = new Padding( 100 );
        }

        void calendar_ItemCreated( object sender, CalendarItemCancelEventArgs e )
        {
            Console.WriteLine( "Item created" );
        }

        void fillCalendarFromSlots()
        {
            foreach( Slot slot in _mySoft.ListSlots )
            {
                CalendarItem ci = getCalendarItemFromSlot( slot );
                calendar.Items.Add( ci );
            }
        }

        CalendarItem getCalendarItemFromSlot( Slot slot )
        {
            DateTime startDate = slot.Date.Date;
            string slotFormattedText = slot.AssociatedSubject.Name + Environment.NewLine
                + slot.AssociatedTeacher.Name + Environment.NewLine
                + slot.AssociatedRoom.Name;

            if( slot.Morning )
                startDate.AddHours( 9 );
            else
                startDate.AddHours( 13.5 );
            
            CalendarItem ci = new CalendarItem( calendar, startDate, new TimeSpan(3, 30, 0 ), slotFormattedText );
            return ci;
        }

        private void parPromotionToolStripMenuItem_Click( object sender, EventArgs e )
        {
            _mySoft.CurrentUcFilter = "ucPromotion1";
            ucRoom1.Visible = false;
            ucTeacher1.Visible = false;
            ucPromotion1.Visible = true;
        }

        private void parSalleToolStripMenuItem_Click( object sender, EventArgs e )
        {
            _mySoft.CurrentUcFilter = "ucRoom1";
            ucTeacher1.Visible = false;
            ucPromotion1.Visible = false;
            ucRoom1.Visible = true;
        }

        private void parProfesseurToolStripMenuItem_Click( object sender, EventArgs e )
        {
            _mySoft.CurrentUcFilter = "ucTeacher1";
            ucPromotion1.Visible = false;
            ucRoom1.Visible = false;
            ucTeacher1.Visible = true;
        }

        //Slot getSlotFromCalendarItem( CalendarItem ci)
        //{
        //    Teacher teacher = _mySoft.ListTeachers.Where(t => t.Name == ci.)
        //}
    }

}
