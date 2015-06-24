﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Calendar;

namespace Plann.Interface
{
    class ExtendedCalendarRenderer : CalendarProfessionalRenderer
    {

        int _standardItemHeight;

        public ExtendedCalendarRenderer(Calendar calendar)
            : base(calendar)
        {
        }

        public override int StandardItemHeight
        {
            get
            {
                return base.StandardItemHeight;
            }
            //set
            //{
            //    _standardItemHeight = value;
            //}
        }
    }
}
