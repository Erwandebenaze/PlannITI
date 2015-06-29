using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Plann.Core;

namespace Plann.Interface
{
    public partial class UcMgtPeriod : UserControl
    {
        string _state;
        List<DateTime> _listHolidays;
        DateTime _begDate;
        DateTime _endDate;
        public UcMgtPeriod()
        {
            InitializeComponent();
            _listHolidays = new List<DateTime>();
            _begDate = new DateTime() ;
            _endDate = new DateTime();
        }
        internal delegate void MyEventHandler();
        internal event MyEventHandler reload;
        internal void OnReload()
        {
            if( reload != null )
                reload();
        }
        IPlannContext SoftContext
        {
            get { return (IPlannContext)TopLevelControl; }
        }
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad( e );
        }
        private void linkLabel1_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls[SoftContext.CurrentPeriod.CurrentUcFilter].Visible = true;
            OnReload();
        }

        private void begginingButton_Click( object sender, EventArgs e )
        {
            monthCalendar1.Visible = true;
            _state = "begin";
        }

        private void endingButton_Click( object sender, EventArgs e )
        {
            monthCalendar1.Visible = true;
            _state = "end";
        }

        private void monthCalendar1_DateSelected( object sender, DateRangeEventArgs e )
        {
            if( _state == "begin")
            {
                begginingDateText.Text = e.End.ToShortDateString();
                _begDate = e.End;
            } else if( _state == "end")
            {
                endingDateText.Text = e.End.ToShortDateString();
                _endDate = e.End;
            }
            monthCalendar1.Visible = false;
        }

        private void monthCalendar2_DateSelected( object sender, DateRangeEventArgs e )
        {
            if( _state == "holidays")
            {
                if( _listHolidays.Contains(e.End))
                {
                    MessageBox.Show( "Cette date a déjà été ajoutée." );
                } else
                {
                    _listHolidays.Add( e.End );
                }
            }

            objectListView1.SetObjects( _listHolidays );
        }

        private void holidaysButton_Click( object sender, EventArgs e )
        {
            if(_state !="holidays")
            {
                monthCalendar1.Visible = false;
                monthCalendar2.Visible = true;
                _state = "holidays";
                holidaysButton.Text = "Fin";
            } else
            {
                monthCalendar2.Visible = false;
                _state = "autre";
                holidaysButton.Text = "Choisir";

            }
        }

        private void validatePeriod_Click( object sender, EventArgs e )
        {
            if( !String.IsNullOrWhiteSpace( nameTextBox.Text ) && !String.IsNullOrWhiteSpace( begginingDateText.Text ) && !String.IsNullOrWhiteSpace( endingDateText.Text ) && _listHolidays.Count > 0) 
            {
                if( _begDate > _endDate)
                {
                    MessageBox.Show( "La date de début de période est après celle de fin." );
                }
                else if( !_listHolidays.Where( d => d > _endDate ).Any() && !_listHolidays.Where( d => d < _begDate ).Any() )
                {
                    Period p = new Period( SoftContext.CurrentPeriod.MySoft, nameTextBox.Text, _begDate, _endDate, _listHolidays );
                    SoftContext.CurrentPeriod.MySoft.ListPeriod.Add( p );
                    p.SavePeriod();
                    MessageBox.Show( "La période a bien été créée. Pour la charger, cliquez en haut à gauche sur Période puis Charger période" );
                } else
                {
                    MessageBox.Show( "Une date dans les jours fériés ou de vacances n'est pas dans la période définie." );
                }

                reinitilisation();
            }
        }

        private void reinitilisation()
        {
            _state = null;
            _listHolidays.Clear();
            objectListView1.Clear();
            endingDateText.Text = "";
            begginingDateText.Text = "";
            nameTextBox.Text = "";
            monthCalendar2.Visible = false;
            _state = "autre";
            holidaysButton.Text = "Choisir";
        }
    }
}
