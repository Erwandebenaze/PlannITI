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

namespace Plann.Interface
{
    public partial class PlannITI : Form, IPlannContext
    {
        Soft _mySoft;
        public PlannITI()
        {
            _mySoft = new Soft();
            InitializeComponent();
            
        }
        public Soft CurrentSoft
        {
            get { return _mySoft; }
        }
    }

}
