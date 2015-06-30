using System;
using System.Linq;
using System.Windows.Forms;
using Plann.Core;
using System.Windows.Forms.Calendar;
using System.IO;
using System.Collections.Generic;

namespace Plann.Interface
{
    public partial class PlannITI : Form, IPlannContext
    {
        Soft _mySoft;
        bool? _leftClick;

        public PlannITI()
        {
            _mySoft = new Soft();
            CurrentPeriod.CurrentUcFilter = "ucPromotion1";
            InitializeComponent();

            calendar.ItemsTimeFormat = "HH : mm";

            //Extended renderer for right Item Height
            calendar.Renderer = new ExtendedCalendarRenderer( calendar );

            calendar.SetViewRange( CurrentPeriod.CurrentViewMonthStart, CurrentPeriod.CurrentViewMonthEnd );

            Console.WriteLine( calendar.ViewStart + " " + calendar.ViewEnd );

            LoadItems();

            calendar.DayLeftClick += calendar_DayLeftClick;
            calendar.DayRightClick += calendar_DayRightClick;
            calendar.ItemCreating += calendar_ItemCreating;
            calendar.ItemCreated += calendar_ItemCreated;
            calendar.ItemClick += calendar_ItemClick;
            calendar.ItemDeleted += calendar_ItemDeleted;

            ucMgtSubject1.reload += callReload;
            ucMgtRoom1.reload += callReload;
            ucMgtTeacher1.reload += callReload;

            ucPromotion1.PromotionChanged += LoadItems;
            ucPromotion1.SectorChanged += LoadItems;
            ucRoom1.RoomChanged += LoadItems;
            ucTeacher1.TeacherChanged += LoadItems;
        }

        private void calendar_ItemDeleted( object sender, CalendarItemEventArgs e )
        {
            Slot slotToDelete = CurrentPeriod.ListSlots.Where( s => s.Date == e.Item.Date ).First();
            CurrentPeriod.removeSlot( slotToDelete );
            LoadItems();
        }

        void calendar_DayRightClick( object sender, CalendarDayEventArgs e )
        {
            _leftClick = false;
            calendar.CreateItemOnSelection( "", false );
        }

        void calendar_DayLeftClick( object sender, CalendarDayEventArgs e )
        {
            _leftClick = true;
            calendar.CreateItemOnSelection( "", false );
        }

        public Period CurrentPeriod
        {
            get { return _mySoft.CurrentPeriod; }
        }
        private void callReload()
        {
            ucPromotion1.InitializeComboBox();
            ucRoom1.InitializeComboBox();
            ucTeacher1.InitializeComboBox();
        }
        #region Calendar
        void calendar_ItemClick( object sender, CalendarItemEventArgs e )
        {
            Console.WriteLine( e.Item.Text );
            Console.WriteLine( e.Item.Date );
        }   
        void calendar_ItemCreating( object sender, CalendarItemCancelEventArgs e )
        {
            bool morning;

            if( _leftClick.HasValue )
                morning = _leftClick.Value ? true : false;
            else
            {
                e.Cancel = true;
                return;
            }

            string teacherText;
            string subjectText;
            string roomText;
            string promotionText;
            bool? isIl = null;
            string sectorText = null;

            switch( CurrentPeriod.CurrentUcFilter )
            {
                case "ucPromotion1":
                    teacherText = ucPromotion1.teacherComboBox.Text;
                    subjectText = ucPromotion1.subjectComboBox.Text;
                    roomText = ucPromotion1.roomComboBox.Text;
                    promotionText = ucPromotion1.promotionComboBox.Text;
                    if( ucPromotion1.sectorComboBox.Text == "IL" ) 
                    {
                        isIl = true;
                        sectorText = "IL";
                    }
                    else if( ucPromotion1.sectorComboBox.Text == "SR" ) 
                    {
                        isIl = false;
                        sectorText = "SR";
                    }
                    break;
                case "ucRoom1":
                    teacherText = ucRoom1.teacherComboBox.Text;
                    subjectText = ucRoom1.subjectComboBox.Text;
                    roomText = ucRoom1.roomComboBox.Text;
                    promotionText = ucRoom1.promotionComboBox.Text;
                    if( ucRoom1.sectorComboBox.Text == "IL" ) 
                    {
                        isIl = true;
                        sectorText = "IL";
                    }
                    else if( ucRoom1.sectorComboBox.Text == "SR" )
                    {
                        isIl = false;
                        sectorText = "SR";
                    }

                    break;
                case "ucTeacher1":
                    teacherText = ucTeacher1.teacherComboBox.Text;
                    subjectText = ucTeacher1.subjectComboBox.Text;
                    roomText = ucTeacher1.roomComboBox.Text;
                    promotionText = ucTeacher1.promotionComboBox.Text;
                    if( ucTeacher1.sectorComboBox.Text == "IL" ) 
                    {
                        isIl = true;
                        sectorText = "IL";
                    }
                    else if( ucTeacher1.sectorComboBox.Text == "SR" ) 
                    {
                        isIl = false;
                        sectorText = "SR";
                    }
                    break;
                default:
                    throw new ArgumentException( "Current filter is not set up properly" );
            }

            // A REVOIR
            DateTime day = e.Item.StartDate.Date;

            int nbM = CurrentPeriod.ListSlots.Count( s => s.Date.Date == day && ( s.Morning == morning && s.IsIl == isIl ) );

            int nb;
            if( isIl.HasValue )
                nb = CurrentPeriod.ListSlots.Count( s => ( s.IsIl == isIl || s.IsIl == null ) && s.Date.Date == day );
            else
                nb = CurrentPeriod.ListSlots.Count( s => s.Date.Date == day && s.IsIl == null );

            if( nb > 1 || nbM > 0 || subjectText == String.Empty || roomText == String.Empty || promotionText == String.Empty )
            {
                e.Cancel = true;
                return;
            }
            // A REVOIR

            else
            {
                Teacher teacher = CurrentPeriod.ListTeachers.Where( t => t.Name == teacherText ).SingleOrDefault();
                Subject subject = CurrentPeriod.ListSubjects.Where( s => s.Name == subjectText ).Single();
                Room room = CurrentPeriod.ListRooms.Where( r => r.Name == roomText ).Single();
                List<Promotion> promotions = CurrentPeriod.ListPromotion.Where( p => p.Name == promotionText ).ToList();

                Slot newSlot = new Slot( e.Item.StartDate, morning, room, subject, teacher, promotions, isIl );
                CurrentPeriod.addSlot( newSlot );

                e.Item.StartDate = morning ? e.Item.StartDate.AddHours( 9 ) : e.Item.StartDate.AddHours( 13.5 );
                e.Item.EndDate = e.Item.StartDate + TimeSpan.FromHours( 3.5 );
                e.Item.Text = subjectText;
                e.Item.Text += morning ? " - AM" : " - PM";
                e.Item.Text += Environment.NewLine + teacherText + Environment.NewLine + roomText;
                if( isIl.HasValue )
                    e.Item.Text += " - " + sectorText;
                e.Item.BackgroundColor = subject.Color;
            }

            _leftClick = null;
        }

        void calendar_ItemCreated( object sender, CalendarItemCancelEventArgs e )
        {
            LoadItems();
            Console.WriteLine( "ItemCreated fired !" );
        }

        void LoadItems()
        {
            calendar.Items.Clear();
            List<Slot> filteredSlots = getFilteredSlots();
            foreach( Slot slot in filteredSlots )
            {
                CalendarItem ci = getCalendarItemFromSlot( slot );
                calendar.Items.Add( ci );
            }
        }

        List<Slot> getFilteredSlots()
        {
            List<Slot> filteredSlots = new List<Slot>();
            // Get slots on current view
            List<Slot> slotsOnCurrentView = CurrentPeriod.ListSlots.Where( slot => slot.Date > calendar.ViewStart && slot.Date < calendar.ViewEnd ).ToList();

            if( CurrentPeriod.CurrentUcFilter == "ucPromotion1" )
            {
                bool? isIlBox;
                if( ucPromotion1.sectorComboBox.Text == String.Empty )
                    isIlBox = null;
                else if( ucPromotion1.sectorComboBox.Text == "IL" )
                    isIlBox = true;
                else
                    isIlBox = false;

                if( isIlBox.HasValue )
                    filteredSlots = slotsOnCurrentView.Where( s => ( s.IsIl == isIlBox || s.IsIl == null ) && s.AssociatedPromotionList.Any( p => p.Name == ucPromotion1.promotionComboBox.Text ) ).ToList();
                else
                    filteredSlots = slotsOnCurrentView.Where( s => s.IsIl == null && s.AssociatedPromotionList.Any( p => p.Name == ucPromotion1.promotionComboBox.Text ) ).ToList();
            }
            else if( CurrentPeriod.CurrentUcFilter == "ucRoom1" )
            {
                filteredSlots = slotsOnCurrentView.Where( s => s.AssociatedRoom.Name == ucRoom1.roomComboBox.Text ).ToList();
            }
            else if( CurrentPeriod.CurrentUcFilter == "ucTeacher1" )
            {
                filteredSlots = slotsOnCurrentView.Where( s => s.AssociatedTeacher.Name == ucTeacher1.teacherComboBox.Text ).ToList();
            }

            filteredSlots = filteredSlots.OrderByDescending( s => s.Date ).ToList();
            
            return filteredSlots;
        }

        CalendarItem getCalendarItemFromSlot( Slot slot )
        {
            DateTime startDate = slot.Date.Date;
            DateTime endDate = new DateTime();
            string slotFormattedText = slot.AssociatedSubject.Name;
            slotFormattedText += slot.Morning ? " - AM" : " - PM";
            slotFormattedText += Environment.NewLine + slot.AssociatedTeacher.Name + Environment.NewLine + slot.AssociatedRoom.Name;

            string sector = null;
            if( slot.IsIl.HasValue )
            {
                if( slot.IsIl.Value )
                    sector = "IL";
                else if( !slot.IsIl.Value )
                    sector = "SR";
            }

            if( slot.IsIl.HasValue )
                slotFormattedText += " - " + sector;

            //if( slot.Morning )
            //    startDate = startDate.AddHours( 9 );
            //else
            //    startDate = startDate.AddHours( 13.5 );
            startDate = slot.Date;
            endDate = startDate.AddHours( 3.5 );

            CalendarItem ci = new CalendarItem( calendar, startDate, endDate, slotFormattedText );
            ci.BackgroundColor = slot.AssociatedSubject.Color;
            return ci;
        } 
        #endregion
        #region ToolStrip
        private void parPromotionToolStripMenuItem_Click( object sender, EventArgs e )
        {
            CurrentPeriod.CurrentUcFilter = "ucPromotion1";
            ucRoom1.Visible = false;
            ucTeacher1.Visible = false;
            ucPromotion1.Visible = true;
            LoadItems();
        }
        private void parProfesseurToolStripMenuItem_Click( object sender, EventArgs e )
        {
            CurrentPeriod.CurrentUcFilter = "ucTeacher1";
            ucPromotion1.Visible = false;
            ucRoom1.Visible = false;
            ucTeacher1.Visible = true;
            LoadItems();
        } 
        #endregion
        private void loadPeriod_Click( object sender, EventArgs e )
        {
           // System.Diagnostics.Process.Start( @"..\..\..\Sauvegardes" );
            OpenFileDialog d = new OpenFileDialog();
            Stream myStream = null;
            //MessageBox.Show( Environment.CurrentDirectory.ToString() );
            
            d.InitialDirectory = @"C:\Dev\PlannITI\Sauvegardes"; // CHANGER LE REPERTOIRE EN CAS DE CHANGEMENT DE PC
            MessageBox.Show( d.InitialDirectory ); 
            d.Filter = "bin files (*.bin)|*.bin";
            // d.ShowDialog();

            if( d.ShowDialog() == DialogResult.OK )
            {
                try
                {
                    if( (myStream = d.OpenFile()) != null )
                    {
                        using( myStream )
                        {
                            PeriodLoader.Load( d.FileName );
                            MessageBox.Show( "La partie a été chargée." );
                        }
                    }
                }
                catch( Exception ex )
                {
                    MessageBox.Show( "Error: Could not read file from disk. Original error: " + ex.Message );
                }
            }
        }
        private void parSalleToolStripMenuItem_Click( object sender, EventArgs e )
        {
            CurrentPeriod.CurrentUcFilter = "ucRoom1";
            ucTeacher1.Visible = false;
            ucPromotion1.Visible = false;
            ucRoom1.Visible = true;
            LoadItems();
        }

        private void nextMonthButton_Click( object sender, EventArgs e )
        {
            CurrentPeriod.SetNextMonthView();
            calendar.SetViewRange( CurrentPeriod.CurrentViewMonthStart, CurrentPeriod.CurrentViewMonthEnd );
            LoadItems();
        }

        private void previousMonthButton_Click( object sender, EventArgs e )
        {
            CurrentPeriod.SetPreviousMonthView();
            calendar.SetViewRange( CurrentPeriod.CurrentViewMonthStart, CurrentPeriod.CurrentViewMonthEnd );
            LoadItems();
        }

        private void périodeToolStripMenuItem_Click( object sender, EventArgs e )
        {
            CurrentPeriod.CurrentUcFilter = "ucTeacher1";
            ucPromotion1.Visible = false;
            ucRoom1.Visible = false;
            ucTeacher1.Visible = false;
            ucMgtPeriod1.Visible = true;
        }

        //Slot getSlotFromCalendarItem( CalendarItem ci)
        //{
        //    Teacher teacher = _mySoft.ListTeachers.Where(t => t.Name == ci.)
        //}
    }
}
