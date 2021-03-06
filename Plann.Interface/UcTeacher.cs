﻿using System;
using System.Windows.Forms;
using Plann.Core;

namespace Plann.Interface
{
    public partial class UcTeacher : UserControl
    {
        public delegate void SelectionTeacherChanged();
        public event SelectionTeacherChanged TeacherChanged;

        public UcTeacher()
        {
            InitializeComponent();
        }
        IPlannContext SoftContext
        {
            get { return (IPlannContext)TopLevelControl; }
        }

        public void OnTeacherChanged()
        {
            if( TeacherChanged != null )
                TeacherChanged();
        }

        internal void InitializeComboBox()
        {
            #region ClearComboBox
            promotionComboBox.Items.Clear();
            teacherComboBox.Items.Clear();
            subjectComboBox.Items.Clear();
            roomComboBox.Items.Clear();
            #endregion
            try
            {
                #region FillComboBox
                foreach( Promotion p in SoftContext.CurrentPeriod.ListPromotion )
                {
                    promotionComboBox.Items.Add( p.Name );
                }
                foreach( Teacher t in SoftContext.CurrentPeriod.ListTeachers )
                {
                    teacherComboBox.Items.Add( t.Name );
                }
                foreach( Subject s in SoftContext.CurrentPeriod.ListSubjects )
                {
                    subjectComboBox.Items.Add( s.Name );
                }
                foreach( Room r in SoftContext.CurrentPeriod.ListRooms )
                {
                    roomComboBox.Items.Add( r.Name );
                }
                #endregion
            }
            catch( NullReferenceException e )
            {
                Console.Write( e );
            }
        }
        #region LinkClicked
        private void manageTeachersLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls["ucMgtTeacher1"].Visible = true;
        }
        private void manageSubjectsLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls["ucMgtSubject1"].Visible = true;
        }
        private void manageRoomsLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls["ucMgtRoom1"].Visible = true;
        }
        private void managePromotionsLink_LinkClicked( object sender, LinkLabelLinkClickedEventArgs e )
        {
            this.Visible = false;
            Parent.Controls["ucMgtPromotion1"].Visible = true;
        } 
        #endregion

        private void teacherComboBox_SelectedIndexChanged( object sender, EventArgs e )
        {
            OnTeacherChanged();
        }

        private void promotionComboBox_Click( object sender, EventArgs e )
        {
            if( promotionComboBox.Items.Count == 0 && roomComboBox.Items.Count == 0 && subjectComboBox.Items.Count == 0 )
                InitializeComboBox();
        }

        private void subjectComboBox_Click( object sender, EventArgs e )
        {
            if( promotionComboBox.Items.Count == 0 && roomComboBox.Items.Count == 0 && subjectComboBox.Items.Count == 0 )
                InitializeComboBox();
        }

        private void roomComboBox_Click( object sender, EventArgs e )
        {
            if( promotionComboBox.Items.Count == 0 && roomComboBox.Items.Count == 0 && subjectComboBox.Items.Count == 0 )
                InitializeComboBox();
        }

        private void teacherComboBox_Click( object sender, EventArgs e )
        {
            if( promotionComboBox.Items.Count == 0 && roomComboBox.Items.Count == 0 && subjectComboBox.Items.Count == 0 )
                InitializeComboBox();
        }
    }
}
