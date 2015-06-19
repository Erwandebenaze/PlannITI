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
    public partial class UcTeacher : UserControl
    {
        public UcTeacher()
        {
            InitializeComponent();
        }

        private void manageTeachersLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls[ "ucMgtRoom1" ].Visible = true;
        }

        private void manageSubjectsLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls[ "ucMgtSubject1" ].Visible = true;
        }

        private void manageRoomsLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls[ "ucMgtRoom1" ].Visible = true;
        }
    }
}
