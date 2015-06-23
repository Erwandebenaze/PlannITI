using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Plann.Interface
{
    public partial class UcMgtPeriod : UserControl
    {
        string _state;
        public UcMgtPeriod()
        {
            InitializeComponent();
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
            } else if( _state == "end")
            {
                endingDateText.Text = e.End.ToShortDateString();
            }
            monthCalendar1.Visible = false;
        }
    }
}
