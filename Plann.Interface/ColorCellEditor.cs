using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace Plann.Interface
{
    class ColorCellEditor : Control
    {
        Color _value;
        ColorDialog _c;

        internal Color Value
        {
            get { return _value; }
        }

        public ColorCellEditor(Color c)
        {
            _c = new ColorDialog();
            if( _c.ShowDialog() == DialogResult.OK )
            {
                _value = _c.Color;
                //    int color = colorDialog1.Color.A;
            } else
            {
                _value = c;
            }
        }

    }
}
