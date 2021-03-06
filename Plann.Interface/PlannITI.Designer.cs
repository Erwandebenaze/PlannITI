﻿namespace Plann.Interface
{
    partial class PlannITI
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && (components != null) )
            {
                components.Dispose();
            }
            base.Dispose( disposing );
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.calendar = new System.Windows.Forms.Calendar.Calendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.périodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.créerUnePériodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chargerUnePériodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parPromotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parSalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parProfesseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sauvegarderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affectTooltip = new System.Windows.Forms.ToolTip(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.amToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentYearMonthLabel = new System.Windows.Forms.Label();
            this.ucTeacher1 = new Plann.Interface.UcTeacher();
            this.ucRoom1 = new Plann.Interface.UcRoom();
            this.ucMgtTeacher1 = new Plann.Interface.UcMgtTeacher();
            this.ucMgtSubject1 = new Plann.Interface.UcMgtSubject();
            this.ucMgtRoom1 = new Plann.Interface.UcMgtRoom();
            this.ucPromotion1 = new Plann.Interface.UcPromotion();
            this.ucMgtPeriod1 = new Plann.Interface.UcMgtPeriod();
            this.ucMgtPromotion1 = new Plann.Interface.UcMgtPromotion();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleName = "Sc1.Panel1";
            this.splitContainer1.Panel1.Controls.Add(this.ucTeacher1);
            this.splitContainer1.Panel1.Controls.Add(this.ucRoom1);
            this.splitContainer1.Panel1.Controls.Add(this.ucMgtTeacher1);
            this.splitContainer1.Panel1.Controls.Add(this.ucMgtSubject1);
            this.splitContainer1.Panel1.Controls.Add(this.ucMgtRoom1);
            this.splitContainer1.Panel1.Controls.Add(this.ucPromotion1);
            this.splitContainer1.Panel1.Controls.Add(this.ucMgtPeriod1);
            this.splitContainer1.Panel1.Controls.Add(this.ucMgtPromotion1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.calendar);
            this.splitContainer1.Size = new System.Drawing.Size(1006, 648);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.TabIndex = 1;
            // 
            // calendar
            // 
            this.calendar.AllowItemEdit = false;
            this.calendar.AllowItemResize = false;
            this.calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange1.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange1.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange2.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange2.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange3.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange3.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange4.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange4.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange5.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange5.StartTime = System.TimeSpan.Parse("08:00:00");
            this.calendar.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5};
            this.calendar.Location = new System.Drawing.Point(0, 0);
            this.calendar.MaximumFullDays = 0;
            this.calendar.MaximumViewDays = 28;
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(679, 648);
            this.calendar.TabIndex = 0;
            this.calendar.Text = "calendar1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.périodeToolStripMenuItem,
            this.vueToolStripMenuItem,
            this.sauvegarderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1006, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // périodeToolStripMenuItem
            // 
            this.périodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.créerUnePériodeToolStripMenuItem,
            this.chargerUnePériodeToolStripMenuItem});
            this.périodeToolStripMenuItem.Name = "périodeToolStripMenuItem";
            this.périodeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.périodeToolStripMenuItem.Text = "Période";
            // 
            // créerUnePériodeToolStripMenuItem
            // 
            this.créerUnePériodeToolStripMenuItem.Name = "créerUnePériodeToolStripMenuItem";
            this.créerUnePériodeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.créerUnePériodeToolStripMenuItem.Text = "Créer une période";
            this.créerUnePériodeToolStripMenuItem.Click += new System.EventHandler(this.créerUnePériodeToolStripMenuItem_Click);
            // 
            // chargerUnePériodeToolStripMenuItem
            // 
            this.chargerUnePériodeToolStripMenuItem.Name = "chargerUnePériodeToolStripMenuItem";
            this.chargerUnePériodeToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.chargerUnePériodeToolStripMenuItem.Text = "Charger une période";
            this.chargerUnePériodeToolStripMenuItem.Click += new System.EventHandler(this.chargerUnePériodeToolStripMenuItem_Click);
            // 
            // vueToolStripMenuItem
            // 
            this.vueToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.parPromotionToolStripMenuItem,
            this.parSalleToolStripMenuItem,
            this.parProfesseurToolStripMenuItem});
            this.vueToolStripMenuItem.Name = "vueToolStripMenuItem";
            this.vueToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.vueToolStripMenuItem.Text = "Vue";
            // 
            // parPromotionToolStripMenuItem
            // 
            this.parPromotionToolStripMenuItem.Name = "parPromotionToolStripMenuItem";
            this.parPromotionToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.parPromotionToolStripMenuItem.Text = "Par promotion";
            this.parPromotionToolStripMenuItem.Click += new System.EventHandler(this.parPromotionToolStripMenuItem_Click);
            // 
            // parSalleToolStripMenuItem
            // 
            this.parSalleToolStripMenuItem.Name = "parSalleToolStripMenuItem";
            this.parSalleToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.parSalleToolStripMenuItem.Text = "Par salle";
            this.parSalleToolStripMenuItem.Click += new System.EventHandler(this.parSalleToolStripMenuItem_Click);
            // 
            // parProfesseurToolStripMenuItem
            // 
            this.parProfesseurToolStripMenuItem.Name = "parProfesseurToolStripMenuItem";
            this.parProfesseurToolStripMenuItem.Size = new System.Drawing.Size(151, 22);
            this.parProfesseurToolStripMenuItem.Text = "Par professeur";
            this.parProfesseurToolStripMenuItem.Click += new System.EventHandler(this.parProfesseurToolStripMenuItem_Click);
            // 
            // sauvegarderToolStripMenuItem
            // 
            this.sauvegarderToolStripMenuItem.Name = "sauvegarderToolStripMenuItem";
            this.sauvegarderToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.sauvegarderToolStripMenuItem.Text = "Sauvegarder";
            this.sauvegarderToolStripMenuItem.Click += new System.EventHandler(this.sauvegarderToolStripMenuItem_Click);
            // 
            // affectTooltip
            // 
            this.affectTooltip.ShowAlways = true;
            this.affectTooltip.ToolTipTitle = "Affectation incorrecte";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.amToolStripMenuItem,
            this.pmToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(134, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            // 
            // amToolStripMenuItem
            // 
            this.amToolStripMenuItem.Name = "amToolStripMenuItem";
            this.amToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.amToolStripMenuItem.Text = "Matin";
            // 
            // pmToolStripMenuItem
            // 
            this.pmToolStripMenuItem.Name = "pmToolStripMenuItem";
            this.pmToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.pmToolStripMenuItem.Text = "Après-Midi";
            // 
            // currentYearMonthLabel
            // 
            this.currentYearMonthLabel.AutoSize = true;
            this.currentYearMonthLabel.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentYearMonthLabel.Location = new System.Drawing.Point(578, -1);
            this.currentYearMonthLabel.Name = "currentYearMonthLabel";
            this.currentYearMonthLabel.Size = new System.Drawing.Size(136, 23);
            this.currentYearMonthLabel.TabIndex = 4;
            this.currentYearMonthLabel.Text = "CurrentYearMonth";
            // 
            // ucTeacher1
            // 
            this.ucTeacher1.Location = new System.Drawing.Point(2, 2);
            this.ucTeacher1.Margin = new System.Windows.Forms.Padding(2);
            this.ucTeacher1.Name = "ucTeacher1";
            this.ucTeacher1.Size = new System.Drawing.Size(307, 411);
            this.ucTeacher1.TabIndex = 5;
            this.ucTeacher1.Visible = false;
            // 
            // ucRoom1
            // 
            this.ucRoom1.Location = new System.Drawing.Point(2, 2);
            this.ucRoom1.Margin = new System.Windows.Forms.Padding(2);
            this.ucRoom1.Name = "ucRoom1";
            this.ucRoom1.Size = new System.Drawing.Size(307, 411);
            this.ucRoom1.TabIndex = 4;
            this.ucRoom1.Visible = false;
            // 
            // ucMgtTeacher1
            // 
            this.ucMgtTeacher1.Location = new System.Drawing.Point(2, 2);
            this.ucMgtTeacher1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucMgtTeacher1.Name = "ucMgtTeacher1";
            this.ucMgtTeacher1.Size = new System.Drawing.Size(304, 347);
            this.ucMgtTeacher1.TabIndex = 3;
            this.ucMgtTeacher1.Visible = false;
            // 
            // ucMgtSubject1
            // 
            this.ucMgtSubject1.Location = new System.Drawing.Point(2, 2);
            this.ucMgtSubject1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucMgtSubject1.Name = "ucMgtSubject1";
            this.ucMgtSubject1.Size = new System.Drawing.Size(307, 411);
            this.ucMgtSubject1.TabIndex = 2;
            this.ucMgtSubject1.Visible = false;
            // 
            // ucMgtRoom1
            // 
            this.ucMgtRoom1.Location = new System.Drawing.Point(2, 2);
            this.ucMgtRoom1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucMgtRoom1.Name = "ucMgtRoom1";
            this.ucMgtRoom1.Size = new System.Drawing.Size(304, 347);
            this.ucMgtRoom1.TabIndex = 1;
            this.ucMgtRoom1.Visible = false;
            // 
            // ucPromotion1
            // 
            this.ucPromotion1.Location = new System.Drawing.Point(2, 2);
            this.ucPromotion1.Margin = new System.Windows.Forms.Padding(2);
            this.ucPromotion1.Name = "ucPromotion1";
            this.ucPromotion1.Size = new System.Drawing.Size(307, 411);
            this.ucPromotion1.TabIndex = 0;
            // 
            // ucMgtPeriod1
            // 
            this.ucMgtPeriod1.Location = new System.Drawing.Point(0, 0);
            this.ucMgtPeriod1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucMgtPeriod1.Name = "ucMgtPeriod1";
            this.ucMgtPeriod1.Size = new System.Drawing.Size(632, 642);
            this.ucMgtPeriod1.TabIndex = 7;
            this.ucMgtPeriod1.Visible = false;
            // 
            // ucMgtPromotion1
            // 
            this.ucMgtPromotion1.Location = new System.Drawing.Point(0, 0);
            this.ucMgtPromotion1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucMgtPromotion1.Name = "ucMgtPromotion1";
            this.ucMgtPromotion1.Size = new System.Drawing.Size(431, 402);
            this.ucMgtPromotion1.TabIndex = 6;
            this.ucMgtPromotion1.Visible = false;
            // 
            // PlannITI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 672);
            this.Controls.Add(this.currentYearMonthLabel);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlannITI";
            this.Text = "Plann";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PlannITI_FormClosing);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem périodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parPromotionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parSalleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem parProfesseurToolStripMenuItem;
        internal UcPromotion ucPromotion1;
        internal UcMgtRoom ucMgtRoom1;
        internal UcMgtSubject ucMgtSubject1;
        internal UcMgtTeacher ucMgtTeacher1;
        internal UcRoom ucRoom1;
        internal UcTeacher ucTeacher1;
        private System.Windows.Forms.Calendar.Calendar calendar;
        internal UcMgtPromotion ucMgtPromotion1;
        private UcMgtPeriod ucMgtPeriod1;
        private System.Windows.Forms.ToolStripMenuItem créerUnePériodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chargerUnePériodeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sauvegarderToolStripMenuItem;
        private System.Windows.Forms.ToolTip affectTooltip;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem amToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pmToolStripMenuItem;
        private System.Windows.Forms.Label currentYearMonthLabel;



    }
}

