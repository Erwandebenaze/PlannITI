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

            calendar.ItemCreating += calendar_ItemCreating;
            calendar.ItemCreated += calendar_ItemCreated;
            calendar.ItemClick += calendar_ItemClick;

            ucMgtSubject1.reload += callReload;
            ucMgtRoom1.reload += callReload;
            ucMgtTeacher1.reload += callReload;
            ucPromotion1.PromotionChanged += LoadItems;
            ucPromotion1.SectorChanged += LoadItems;
            ucRoom1.RoomChanged += LoadItems;
            ucTeacher1.TeacherChanged += LoadItems;
        }

        private void ReloadItems( object sender, MouseEventArgs e )
        {
            LoadItems();
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
            //foreach( Slot slot in CurrentPeriod.ListSlots )
            //{
            //    Console.WriteLine( slot.Date + " " + slot.AssociatedSubject + " " + slot.AssociatedTeacher + " " + slot.AssociatedRoom + " " + slot.Morning );
            //}
        }   
        void calendar_ItemCreating( object sender, CalendarItemCancelEventArgs e )
        {
            // Find a way to know if morning on click
            bool morning = true;

            string teacherText;
            string subjectText;
            string roomText;
            string promotionText;
            bool? il = null;
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
                        il = true;
                        sectorText = "IL";
                    }
                    else if( ucPromotion1.sectorComboBox.Text == "SR" ) 
                    {
                        il = false;
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
                        il = true;
                        sectorText = "IL";
                    }
                    else if( ucRoom1.sectorComboBox.Text == "SR" )
                    {
                        il = false;
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
                        il = true;
                        sectorText = "IL";
                    }
                    else if( ucTeacher1.sectorComboBox.Text == "SR" ) 
                    {
                        il = false;
                        sectorText = "SR";
                    }
                    break;
                default:
                    throw new ArgumentException( "Current filter is not set up properly" );
            }

            DateTime day = e.Item.StartDate.Date;
            int nb = calendar.Items.Count( i => i.StartDate.Date == day );
            if( nb > 1 || subjectText == String.Empty || roomText == String.Empty || promotionText == String.Empty )
            {
                e.Cancel = true;
            }
            else
            {
                Teacher teacher = CurrentPeriod.ListTeachers.Where( t => t.Name == teacherText ).SingleOrDefault();
                Subject subject = CurrentPeriod.ListSubjects.Where( s => s.Name == subjectText ).Single();
                Room room = CurrentPeriod.ListRooms.Where( r => r.Name == roomText ).Single();
                List<Promotion> promotions = CurrentPeriod.ListPromotion.Where( p => p.Name == promotionText ).ToList();

                Slot newSlot = new Slot( e.Item.StartDate, morning, room, subject, teacher, promotions, il );
                CurrentPeriod.addSlot( newSlot );

                e.Item.StartDate = morning ? e.Item.StartDate.AddHours( 9 ) : e.Item.StartDate.AddHours( 13.5 );
                e.Item.EndDate = e.Item.StartDate + TimeSpan.FromHours( 3.5 );
                e.Item.Text = subjectText + Environment.NewLine + teacherText + Environment.NewLine + roomText;
                if( il.HasValue )
                    e.Item.Text += " - " + sectorText;
                e.Item.BackgroundColor = subject.Color;

            }
        }

        void calendar_ItemCreated( object sender, CalendarItemCancelEventArgs e )
        {
            Console.WriteLine( "Item created : " + e.Item.Text + " " + e.Item.Date);
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
            calendar.Items.Reverse();
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
                    filteredSlots = slotsOnCurrentView.Where( s => s.IsIl == isIlBox && s.AssociatedPromotionList.Any( p => p.Name == ucPromotion1.promotionComboBox.Text ) ).ToList();
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

            return filteredSlots;
        }

        CalendarItem getCalendarItemFromSlot( Slot slot )
        {
            DateTime startDate = slot.Date.Date;
            DateTime endDate = new DateTime();
            string slotFormattedText = slot.AssociatedSubject.Name + Environment.NewLine
                + slot.AssociatedTeacher.Name + Environment.NewLine
                + slot.AssociatedRoom.Name;

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

            if( slot.Morning )
                startDate = startDate.AddHours( 9 );
            else
                startDate = startDate.AddHours( 13.5 );
            endDate = startDate.AddHours( 3 );

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
            ucMgtSubject1.reload += callReload;
            ucMgtRoom1.reload += callReload;
            ucMgtTeacher1.reload += callReload;
            LoadItems();
        }
        private void parProfesseurToolStripMenuItem_Click( object sender, EventArgs e )
        {
            CurrentPeriod.CurrentUcFilter = "ucTeacher1";
            ucPromotion1.Visible = false;
            ucRoom1.Visible = false;
            ucTeacher1.Visible = true;
            ucMgtSubject1.reload += callReload;
            ucMgtRoom1.reload += callReload;
            ucMgtTeacher1.reload += callReload;
            LoadItems();
        }
        private void parSalleToolStripMenuItem_Click( object sender, EventArgs e )
        {
            CurrentPeriod.CurrentUcFilter = "ucRoom1";
            ucTeacher1.Visible = false;
            ucPromotion1.Visible = false;
            ucRoom1.Visible = true;
            LoadItems();
            ucMgtSubject1.reload += callReload;
            ucMgtRoom1.reload += callReload;
            ucMgtTeacher1.reload += callReload;
        }
        #endregion

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

        private void créerUnePériodeToolStripMenuItem_Click( object sender, EventArgs e )
        {
            CurrentPeriod.CurrentUcFilter = "ucTeacher1";
            ucPromotion1.Visible = false;
            ucRoom1.Visible = false;
            ucTeacher1.Visible = false;
            ucMgtPeriod1.Visible = true;
            ucMgtSubject1.reload += callReload;
            ucMgtRoom1.reload += callReload;
            ucMgtTeacher1.reload += callReload;
        }

        private void chargerUnePériodeToolStripMenuItem_Click( object sender, EventArgs e )
        {
            // System.Diagnostics.Process.Start( @"..\..\..\Sauvegardes" );
            OpenFileDialog d = new OpenFileDialog();
            Stream myStream = null;
            //MessageBox.Show( Environment.CurrentDirectory.ToString() );

            d.InitialDirectory = @"C:\Dev\PlannITI\Sauvegardes"; // CHANGER LE REPERTOIRE EN CAS DE CHANGEMENT DE PC
            //MessageBox.Show( d.InitialDirectory );
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
                           _mySoft.ChangePeriode(PeriodLoader.Load( d.FileName ));
                           parPromotionToolStripMenuItem_Click( null, null );
                           ReloadOlv();
                            MessageBox.Show( "La période a été chargée." );
                        }
                    }
                }
                catch( Exception ex )
                {
                    MessageBox.Show( "Error: Could not read file from disk. Original error: " + ex.Message );
                }
            }
        }

        private void ReloadOlv()
        {
            ucMgtPromotion1.LoadPage();
            ucMgtSubject1.LoadPage();
            ucMgtRoom1.LoadPage();
        }

        private void sauvegarderToolStripMenuItem_Click( object sender, EventArgs e )
        {
            CurrentPeriod.SavePeriod();

            MessageBox.Show( "La période actuelle a été sauvegardée." );
        }



        //Slot getSlotFromCalendarItem( CalendarItem ci)
        //{
        //    Teacher teacher = _mySoft.ListTeachers.Where(t => t.Name == ci.)
        //}
    }
}
