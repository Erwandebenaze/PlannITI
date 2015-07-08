using System;
using System.Linq;
using System.Windows.Forms;
using Plann.Core;
using System.Windows.Forms.Calendar;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Text;
using System.Windows.Media;

namespace Plann.Interface
{
    public partial class PlannITI : Form, IPlannContext
    {
        Soft _mySoft;
        bool? _topClick;
        DateTime _clickedDay;
        bool _contextStripOn = false;
        Timer _timer;
        int interval;
        public PlannITI()
        {
            string fileName = findIfTmpExists();
            if (fileName != null)
            {
                DialogResult res = MessageBox.Show( "La programme a été fermé de manière impromptue. Voulez-vous charger la sauvegarde automatique ?", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1 );
                if(res == DialogResult.Yes)
                {
                    Period p = PeriodLoader.Load( fileName );
                    _mySoft = p.MySoft;
                    _mySoft.ChangePeriode( p );
                    string fileName2 = findIfTmpExists();
                    if( fileName2 != null )
                        _mySoft.CurrentPeriod.DeleteTmpPeriod( fileName2 );
                }
                else
                {
                    loadPeriodFromBeginning();
                    string fileName2 = findIfTmpExists();
                    if( fileName2 != null )
                        _mySoft.CurrentPeriod.DeleteTmpPeriod( fileName2 );
                }
            } else
            {
                loadPeriodFromBeginning();
            }

            CurrentPeriod.CurrentUcFilter = "ucPromotion1";
            InitializeComponent();



            _timer = new Timer();
            interval = 1500;
            _timer.Interval = interval;
            _timer.Tick += _timer_Tick;
            _timer.Start();

            calendar.ItemsTimeFormat = "HH : mm";
            calendar.Renderer = new ExtendedCalendarRenderer( calendar );
            setViewRange();
            LoadCalendarView();

            #region CalendarEvents
            calendar.DayTopClick += calendar_DayTopClick;
            calendar.DayBottomClick += calendar_DayBottomClick;
            calendar.ItemCreating += calendar_ItemCreating;
            calendar.ItemCreated += calendar_ItemCreated;
            calendar.ItemClick += calendar_ItemClick;
            calendar.ItemDeleted += calendar_ItemDeleted;
            this.Resize += PlannITI_Resize;
            this.ResizeEnd += PlannITI_ResizeEnd;
            calendar.Resize += calendar_Resize;
            #endregion

            #region ReloadAndLoadItems
            ucMgtSubject1.reload += callReload;
            ucMgtRoom1.reload += callReload;
            ucMgtTeacher1.reload += callReload;
            ucPromotion1.PromotionChanged += LoadCalendarView;
            ucPromotion1.SectorChanged += LoadCalendarView;
            ucRoom1.RoomChanged += LoadCalendarView;
            ucTeacher1.TeacherChanged += LoadCalendarView; 
            #endregion
        }
        void _timer_Tick( object sender, EventArgs e )
        {
            CurrentPeriod.SaveTmpPeriod();
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
        void PlannITI_ResizeEnd( object sender, EventArgs e )
        {
            LoadCalendarView();
        }
        void calendar_Resize( object sender, EventArgs e )
        {
            LoadCalendarView();
        }
        void PlannITI_Resize( object sender, EventArgs e )
        {
            if( this.Height < 300 )
                this.Height = 300;
            if( this.Width < 400 )
                this.Width = 400;
            Console.WriteLine( "Fesses" );
            LoadCalendarView();
        }
        void setViewRange()
        {
            calendar.SetViewRange( CurrentPeriod.CurrentViewMonthStart, CurrentPeriod.CurrentViewMonthEnd );
            SetCurrentYearMonth();

            ExtendedCalendarRenderer renderer = (ExtendedCalendarRenderer)calendar.Renderer;
            renderer.Holidays = GetHolidaysOnView();
        }

        protected override void WndProc( ref Message m )
        {
            base.WndProc( ref m );
            if( m.Msg == 0x0112 )
            {
                if( m.WParam == new IntPtr( 0xF030 )
                    || m.WParam == new IntPtr( 0xF120 ) )
                {
                    LoadCalendarView();
                }
            }
        }

        void contextMenuStrip1_Opening( object sender, System.ComponentModel.CancelEventArgs e )
        {
            contextMenuStrip1.Items.Clear();
            #region DisplayInProgress
            //bool? isIl = null;
            //switch( CurrentPeriod.CurrentUcFilter )
            //{
            //    case "ucPromotion1":
            //        if( ucPromotion1.sectorComboBox.Text == "IL" )
            //            isIl = true;
            //        else if( ucPromotion1.sectorComboBox.Text == "SR" )
            //            isIl = false;
            //        break;
            //    case "ucRoom1":
            //        if( ucRoom1.sectorComboBox.Text == "IL" )
            //            isIl = true;
            //        else if( ucRoom1.sectorComboBox.Text == "SR" )
            //            isIl = false;
            //        break;
            //    case "ucTeacher1":
            //        if( ucTeacher1.sectorComboBox.Text == "IL" )
            //            isIl = true;
            //        else if( ucTeacher1.sectorComboBox.Text == "SR" )
            //            isIl = false;
            //        break;
            //    default:
            //        throw new ArgumentException( "Current filter is not set up properly" );
            //}

            //int nbMorning;
            //if( isIl.HasValue )
            //    nbMorning = CurrentPeriod.ListSlots.Count( s => s.Date.Date == _clickedDay && ( s.Morning && s.IsIl == isIl ) );
            //else
            //    nbMorning = CurrentPeriod.ListSlots.Count( s => s.Date.Date == _clickedDay && s.Morning );

            //int nbAfternoon;
            //if( isIl.HasValue )
            //    nbAfternoon = CurrentPeriod.ListSlots.Count( s => s.Date.Date == _clickedDay && ( !s.Morning && s.IsIl == isIl ) );
            //else
            //    nbAfternoon = CurrentPeriod.ListSlots.Count( s => s.Date.Date == _clickedDay && !s.Morning );

            //if( nbMorning < 1 )
            //{
            //    contextMenuStrip1.Items.Add( "Matin" ).Name = "amToolStripMenuItem";
            //}
            //if( nbAfternoon < 1 )
            //{
            //   contextMenuStrip1.Items.Add( "Après-Midi" ).Name = "pmToolStripMenuItem";
            //} 
            #endregion
            contextMenuStrip1.Items.Add( "Matin" ).Name = "amToolStripMenuItem";
            contextMenuStrip1.Items.Add( "Après-Midi" ).Name = "pmToolStripMenuItem";
        }
        protected override void OnMouseWheel( MouseEventArgs e )
        {
            if( e.Delta > 0 )
                setPreviousMonth();
            else
                setNextMonth();
            base.OnMouseWheel( e );
        }
        private void calendar_ItemDeleted( object sender, CalendarItemEventArgs e )
        {
            Slot slotToDelete = CurrentPeriod.ListSlots.Where( s => s.Date == e.Item.StartDate && s.IsOnView == e.Item.IsOnViewDateRange ).Single();
            CurrentPeriod.removeSlot( slotToDelete );
            LoadCalendarView();
        }
        private void contextMenuStrip1_ItemClicked( object sender, ToolStripItemClickedEventArgs e )
        {
            if( e.ClickedItem.Name == "amToolStripMenuItem" )
                _topClick = true;
            else
                _topClick = false;

            calendar.CreateItemOnSelection( "", false );
            LoadCalendarView();
            _contextStripOn = false;
        }
        void calendar_DayTopClick( object sender, CalendarDayEventArgs e )
        {
            if( !_contextStripOn )
            {
                _clickedDay = e.CalendarDay.Date;
                contextMenuStrip1.Show( Cursor.Position );
                _contextStripOn = true;
            }
            else
            {
                _contextStripOn = false;
                contextMenuStrip1.Hide();
            }
        }
        void calendar_DayBottomClick( object sender, CalendarDayEventArgs e )
        {
            if( !_contextStripOn )
            {
                _clickedDay = e.CalendarDay.Date;
                contextMenuStrip1.Show( new Point( Cursor.Position.X, Cursor.Position.Y - 30 ) );
                _contextStripOn = true;
            }
            else
            {
                _contextStripOn = false;
                contextMenuStrip1.Hide();
            }

        }
        void calendar_ItemClick( object sender, CalendarItemEventArgs e )
        {
            Console.WriteLine( e.Item.Text );
            Console.WriteLine( e.Item.Date );
            Console.WriteLine( e.Item.Bounds.Y );
        }
        void calendar_ItemCreating( object sender, CalendarItemCancelEventArgs e )
        {
            bool morning;

            if( _topClick.HasValue )
                morning = _topClick.Value ? true : false;
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
            string additionnalText = "";

            #region Filter switch
            switch( CurrentPeriod.CurrentUcFilter )
            {
                case "ucPromotion1":
                    teacherText = ucPromotion1.teacherComboBox.Text;
                    subjectText = ucPromotion1.subjectComboBox.Text;
                    roomText = ucPromotion1.roomComboBox.Text;
                    promotionText = ucPromotion1.promotionComboBox.Text;
                    additionnalText = ucPromotion1.texBoxAddText.Text;
                    if( ucPromotion1.sectorComboBox.Text == "IL" )
                        isIl = true;
                    else if( ucPromotion1.sectorComboBox.Text == "SR" )
                        isIl = false;
                    break;
                case "ucRoom1":
                    teacherText = ucRoom1.teacherComboBox.Text;
                    subjectText = ucRoom1.subjectComboBox.Text;
                    roomText = ucRoom1.roomComboBox.Text;
                    promotionText = ucRoom1.promotionComboBox.Text;
                    additionnalText = ucRoom1.texBoxAddText.Text;
                    if( ucRoom1.sectorComboBox.Text == "IL" )
                        isIl = true;
                    else if( ucRoom1.sectorComboBox.Text == "SR" )
                        isIl = false;

                    break;
                case "ucTeacher1":
                    teacherText = ucTeacher1.teacherComboBox.Text;
                    subjectText = ucTeacher1.subjectComboBox.Text;
                    roomText = ucTeacher1.roomComboBox.Text;
                    promotionText = ucTeacher1.promotionComboBox.Text;
                    additionnalText = ucTeacher1.texBoxAddText.Text;
                    if( ucTeacher1.sectorComboBox.Text == "IL" )
                        isIl = true;
                    else if( ucTeacher1.sectorComboBox.Text == "SR" )
                        isIl = false;
                    break;
                default:
                    throw new ArgumentException( "Current filter is not set up properly" );
            }
            #endregion

            bool conflict = isAffectationConflict( e.Item.StartDate.Date, isIl, morning, teacherText, subjectText, roomText, promotionText );

            if( conflict )
            {
                e.Cancel = true;
                return;
            }
            else
            {
                #region Temporary CalendarItem Creation
                bool isAddText = false;
                if( additionnalText != String.Empty )
                    isAddText = true;

                Teacher teacher = CurrentPeriod.ListTeachers.Where( t => t.Name == teacherText ).SingleOrDefault();
                Subject subject = CurrentPeriod.ListSubjects.Where( s => s.Name == subjectText ).Single();
                Room room = CurrentPeriod.ListRooms.Where( r => r.Name == roomText ).Single();
                List<Promotion> promotions = CurrentPeriod.ListPromotion.Where( p => p.Name == promotionText ).ToList();

                Slot newSlot;
                if( isAddText )
                    newSlot = new Slot( e.Item.StartDate, morning, room, subject, teacher, promotions, isIl, additionnalText );
                else
                    newSlot = new Slot( e.Item.StartDate, morning, room, subject, teacher, promotions, isIl );

                bool roomConflict = IsRoomAffectationConflict( newSlot );
                if( roomConflict )
                {
                    e.Cancel = true;
                    return;
                }
                CurrentPeriod.addSlot( newSlot );
                #endregion
            }

            _topClick = null;
        }

        private bool IsRoomAffectationConflict( Slot slot )
        {
            bool conflict = false;
            if( slot.IsIl.HasValue )
            {
                if( slot.IsIl.Value )
                    conflict = slot.AssociatedPromotionList[ 0 ].NumberOfIl > slot.AssociatedRoom.NumberOfSeats;
                else
                    conflict = slot.AssociatedPromotionList[ 0 ].NumberOfSr > slot.AssociatedRoom.NumberOfSeats;
            }
            else
                conflict = slot.AssociatedPromotionList[ 0 ].NumberOfStudents > slot.AssociatedRoom.NumberOfSeats;

            if( conflict )
            {
                affectTooltip.Show( "La salle ne peut pas accueillir autant d'élèves", this, Cursor.Position, 5000 );
                return true;
            }

            return false;
        }
        private bool isAffectationConflict( DateTime dayPicked, bool? isIl, bool morning, string teacherText, string subjectText, string roomText, string promotionText )
        {
            bool conflict = false;

            // Holiday
            conflict = CurrentPeriod.ListOfHolidays.Any( d => d.Date == dayPicked );
            if( conflict )
            {
                affectTooltip.Show( "Ce jour n'est pas travaillé", this, Cursor.Position, 5000 );
                return true;
            }

            if( promotionText == String.Empty )
            {
                affectTooltip.Show( "Veullez sélectionner une promotion", this, Cursor.Position, 5000 );
                return true;
            }
            if( subjectText == String.Empty )
            {
                affectTooltip.Show( "Veullez sélectionner une matière", this, Cursor.Position, 5000 );
                return true;
            }
            if( roomText == String.Empty )
            {
                affectTooltip.Show( "Veullez sélectionner une salle", this, Cursor.Position, 5000 );
                return true;
            }

            // Promotion + sector (add promotion to associatedPromotionList to slot if multiple promotion)
            if( isIl.HasValue )
                conflict = CurrentPeriod.ListSlots.Count( s => s.Date.Date == dayPicked && ( s.IsIl == isIl || !s.IsIl.HasValue ) && s.Morning == morning && s.AssociatedPromotionList.Any( p => p.Name == promotionText ) ) > 0;
            else
                conflict = CurrentPeriod.ListSlots.Count( s => s.Date.Date == dayPicked && s.Morning == morning && s.AssociatedPromotionList.Any( p => p.Name == promotionText ) ) > 0;
            if( conflict )
            {
                affectTooltip.Show( "La promotion ou la filière est occupée pour ce créneau", this, Cursor.Position, 5000 );
                return true;
            }

            // Room
            conflict = CurrentPeriod.ListSlots.Count( s => s.Date.Date == dayPicked && s.Morning == morning && s.AssociatedRoom.Name == roomText ) > 0;
            if( conflict )
            {
                affectTooltip.Show( "La salle est déjà prise pour ce créneau", this, Cursor.Position, 5000 );
                return true;
            }

            // Teacher
            conflict = CurrentPeriod.ListSlots.Count( s => s.Date.Date == dayPicked && s.Morning == morning && s.AssociatedTeacher.Name == teacherText ) > 0;
            if( conflict )
            {
                affectTooltip.Show( "Le professeur est déjà pris pour ce créneau", this, Cursor.Position, 5000 );
                return true;
            }

            return false;
        }
        void calendar_ItemCreated( object sender, CalendarItemCancelEventArgs e )
        {
            LoadCalendarView();
        }
        internal void LoadCalendarView()
        {
            calendar.Items.Clear();
            List<Slot> filteredSlots = getFilteredSlots();
            List<Slot> slotsOnView = new List<Slot>();
            // Add filtered slots to items
            foreach( Slot slot in filteredSlots )
            {
                CalendarItem ci = getCalendarItemFromSlot( slot );
                if( ci.IsOnViewDateRange )
                {
                    calendar.Items.Add( ci );
                    slot.IsOnView = true;
                    slotsOnView.Add( slot );
                }
            }
            // IsOnView = false if the slot is not on the view
            foreach(Slot slot in CurrentPeriod.ListSlots)
            {
                if( !slotsOnView.Any( s => s == slot ) )
                {
                    slot.IsOnView = false;
                }
            }           
            foreach( CalendarItem ci in calendar.Items )
            {
                if( ci.StartDate.Hour > 10 && calendar.Items.Count( c => c.Date.DayOfYear == ci.Date.DayOfYear ) < 2 )
                {
                    Rectangle r = new Rectangle( new Point( ci.Bounds.X, ci.Bounds.Y + ( ( calendar.Days[ 0 ].BodyBounds.Height - ( calendar.Days[ 0 ].HeaderBounds.Height * 2 ) ) / 2 ) ), ci.Bounds.Size );
                    ci.SetBounds( r );
                }
            }
        }
        void SetCurrentYearMonth()
        {
            currentYearMonthLabel.Text = calendar.ViewStart.Year.ToString() + " / " + calendar.ViewStart.ToString( "MMMM" );
        }
        List<Slot> getFilteredSlots()
        {
            List<Slot> filteredSlots = new List<Slot>();
            List<Slot> slots = CurrentPeriod.ListSlots;

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
                    filteredSlots = slots.Where( s => ( s.IsIl == isIlBox || s.IsIl == null ) && s.AssociatedPromotionList.Any( p => p.Name == ucPromotion1.promotionComboBox.Text ) ).ToList();
                else
                    filteredSlots = slots.Where( s => s.IsIl == null && s.AssociatedPromotionList.Any( p => p.Name == ucPromotion1.promotionComboBox.Text ) ).ToList();
            }
            else if( CurrentPeriod.CurrentUcFilter == "ucRoom1" )
            {
                filteredSlots = slots.Where( s => s.AssociatedRoom.Name == ucRoom1.roomComboBox.Text ).ToList();
            }
            else if( CurrentPeriod.CurrentUcFilter == "ucTeacher1" )
            {
                filteredSlots = slots.Where( s => s.AssociatedTeacher.Name == ucTeacher1.teacherComboBox.Text ).ToList();
            }

            filteredSlots = filteredSlots.OrderByDescending( s => s.Date ).ToList();

            return filteredSlots;
        }

        CalendarItem getCalendarItemFromSlot( Slot slot )
        {
            DateTime startDate = slot.Date;
            DateTime endDate = new DateTime();

            string slotFormattedText = CustomTextWrap( slot );
            startDate = slot.Date;
            endDate = startDate.AddHours( 3.5 );

            CalendarItem ci = new CalendarItem( calendar, startDate, endDate, slotFormattedText );
            ci.BackgroundColor = slot.AssociatedSubject.Color;

            return ci;
        }
        string CustomTextWrap( Slot slot )
        {
            string slotFormattedText = "";
            List<string> wrappedText = new List<string>();
            double width = calendar.Days[ 0 ].Bounds.Width / 2.6;

            float fontSize = calendar.Days[ 0 ].Bounds.Height / 14;
            string fontFamily = calendar.Font.FontFamily.Name;

            // 1st line = subject
            wrappedText = WrapText( slot.AssociatedSubject.Name, width, fontFamily, fontSize );
            foreach( string s in wrappedText )
                slotFormattedText += s + Environment.NewLine;

            // 2nd line = teacher
            if( slot.AssociatedTeacher != null )
            {
                wrappedText = WrapText( slot.AssociatedTeacher.Name, width, fontFamily, fontSize );
                foreach( string s in wrappedText )
                    slotFormattedText += s + Environment.NewLine;
            }
            else
                slotFormattedText += Environment.NewLine;

            // 3rd line = room + sector
            string roomAndSector = slot.AssociatedRoom.Name;

            string sector = null;
            if( slot.IsIl.HasValue )
            {
                if( slot.IsIl.Value )
                    sector = "IL";
                else if( !slot.IsIl.Value )
                    sector = "SR";
                roomAndSector += " - " + sector;
            }

            slotFormattedText += roomAndSector;

            // 4th line = additionnal text
            if( slot.AdditionnalText != null )
            {
                fontSize = calendar.Days[ 0 ].Bounds.Height / 17;
                List<string> addTextWrapped = WrapText( slot.AdditionnalText, width, fontFamily, fontSize );
                foreach( string s in addTextWrapped )
                {
                    slotFormattedText += Environment.NewLine + s;
                }
            }

            return slotFormattedText;
        }
        static List<string> WrapText( string text, double pixels, string fontFamily,
    float emSize )
        {
            string[] originalLines = text.Split( new string[] { " " },
                StringSplitOptions.None );

            List<string> wrappedLines = new List<string>();

            StringBuilder actualLine = new StringBuilder();
            double actualWidth = 0;

            foreach( var item in originalLines )
            {
                FormattedText formatted = new FormattedText( item,
                    System.Globalization.CultureInfo.CurrentCulture,
                    System.Windows.FlowDirection.LeftToRight,
                    new Typeface( fontFamily ), emSize, System.Windows.Media.Brushes.Black );

                actualLine.Append( item + " " );
                actualWidth += formatted.Width;

                if( actualWidth > pixels )
                {
                    wrappedLines.Add( actualLine.ToString() );
                    actualLine.Clear();
                    actualWidth = 0;
                }
            }

            if( actualLine.Length > 0 )
                wrappedLines.Add( actualLine.ToString() );

            return wrappedLines;
        }
        private void setNextMonth()
        {
            CurrentPeriod.SetNextMonthView();
            setViewRange();
            LoadCalendarView();
        }
        private void setPreviousMonth()
        {
            CurrentPeriod.SetPreviousMonthView();
            setViewRange();
            LoadCalendarView();
        }

        private List<DateTime> GetHolidaysOnView()
        {
            List<DateTime> holidaysOnView = new List<DateTime>();
            foreach( CalendarDay day in calendar.Days )
            {
                DateTime d = CurrentPeriod.ListOfHolidays.Where( h => h.Date == day.Date ).SingleOrDefault();
                if( d != DateTime.MinValue )
                    holidaysOnView.Add( d );
            }
            return holidaysOnView;
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
            LoadCalendarView();
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
            LoadCalendarView();
        }
        private void parSalleToolStripMenuItem_Click( object sender, EventArgs e )
        {
            CurrentPeriod.CurrentUcFilter = "ucRoom1";
            ucTeacher1.Visible = false;
            ucPromotion1.Visible = false;
            ucRoom1.Visible = true;
            ucMgtSubject1.reload += callReload;
            ucMgtRoom1.reload += callReload;
            ucMgtTeacher1.reload += callReload;
            LoadCalendarView();
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
                            _mySoft.ChangePeriode( PeriodLoader.Load( d.FileName ) );
                            parPromotionToolStripMenuItem_Click( null, null );
                            ReloadOlv();
                            callReload();
                            MessageBox.Show( "La période a été chargée." );
                        }
                    }
                }
                catch( Exception ex )
                {
                    MessageBox.Show( "Error: Could not read file from disk. Original error: " + ex.Message );
                }
            }
            string fileName = findIfTmpExists();
            if( fileName != null )
                _mySoft.CurrentPeriod.DeleteTmpPeriod( fileName );

            ucMgtPeriod1.Visible = false;
            ucPromotion1.Visible = true;
        }
        #endregion
        private void loadPeriodFromBeginning()
        {
            OpenFileDialog d = new OpenFileDialog();
            Stream myStream = null;

            d.InitialDirectory = @"C:\Dev\PlannITI\Sauvegardes"; // CHANGER LE REPERTOIRE EN CAS DE CHANGEMENT DE PC
            d.Filter = "bin files (*.bin)|*.bin";
            bool b = true;
            do
            {
                b = true;
                if( d.ShowDialog() != DialogResult.OK)
                {
                    b = false;
                }
                try
                {
                    if( (myStream = d.OpenFile()) != null )
                    {
                        using( myStream )
                        {
                            Period p = PeriodLoader.Load( d.FileName );
                            _mySoft = p.MySoft;
                            _mySoft.ChangePeriode( p );
                        }
                    }
                }
                catch( Exception ex )
                {
                    MessageBox.Show( "Vous devez charger une période pour commencer" );
                    Console.WriteLine( ex );
                }
            } while( b == false );
            string fileName = findIfTmpExists();
            if( fileName != null )
                _mySoft.CurrentPeriod.DeleteTmpPeriod( fileName );
        }
        private string findIfTmpExists()
        {
            string pattern = @"Tmp.bin$";
            string fileName = null;
            Regex rgx = new Regex( pattern, RegexOptions.IgnoreCase );
            foreach( string s in System.IO.Directory.GetFiles( @"..\..\..\Sauvegardes" ) )
            {
                if( rgx.IsMatch( s ) )
                {
                    fileName = s;
                    break;
                }
            }
            return fileName;

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
        private void PlannITI_FormClosing( object sender, FormClosingEventArgs e )
        {
            DialogResult res = MessageBox.Show( "Souhaitez-vous enregistrer avant de quitter ?","Quitter", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button3 );
            if( res == DialogResult.Cancel )
            {
                e.Cancel = true;
            }
            else if( res == DialogResult.Yes ) 
            {
                CurrentPeriod.SavePeriod();
                CurrentPeriod.DeleteTmpPeriod();
            } else if( res == DialogResult.No)
            {
                CurrentPeriod.DeleteTmpPeriod();
            }
        }
    }
}
