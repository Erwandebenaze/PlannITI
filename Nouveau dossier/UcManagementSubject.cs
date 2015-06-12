﻿using System;
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
    public partial class UcManagementSubject : UserControl
    {
        public UcManagementSubject()
        {
            InitializeComponent();
            InitializeListView();
        }
        IPlannContext PlannContext
        {
            get { return (IPlannContext)TopLevelControl; }
        }

        private void InitializeListView()
        {
            this.objectListView1.SetObjects(PlannContext.CurrentPlann.GetSubjects() );
        }

        private void button1_Click( object sender, EventArgs e )
        {
            if( colorDialog1.ShowDialog() == DialogResult.OK )
            {
                button1.BackColor = colorDialog1.Color;
                int color = colorDialog1.Color.A;
            }
        }
    }
}
