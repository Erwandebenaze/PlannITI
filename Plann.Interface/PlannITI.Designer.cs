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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.ucMgtPeriod1 = new Plann.Interface.UcMgtPeriod();
            this.ucMgtPromotion1 = new Plann.Interface.UcMgtPromotion();
            this.previousMonthButton = new System.Windows.Forms.Button();
            this.nextMonthButton = new System.Windows.Forms.Button();
            this.ucTeacher1 = new Plann.Interface.UcTeacher();
            this.ucRoom1 = new Plann.Interface.UcRoom();
            this.ucMgtTeacher1 = new Plann.Interface.UcMgtTeacher();
            this.ucMgtSubject1 = new Plann.Interface.UcMgtSubject();
            this.ucMgtRoom1 = new Plann.Interface.UcMgtRoom();
            this.ucPromotion1 = new Plann.Interface.UcPromotion();
            this.calendar = new System.Windows.Forms.Calendar.Calendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.périodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parPromotionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parSalleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parProfesseurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
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
            this.splitContainer1.Panel1.Controls.Add(this.ucMgtPeriod1);
            this.splitContainer1.Panel1.Controls.Add(this.ucMgtPromotion1);
            this.splitContainer1.Panel1.Controls.Add(this.previousMonthButton);
            this.splitContainer1.Panel1.Controls.Add(this.nextMonthButton);
            this.splitContainer1.Panel1.Controls.Add(this.ucTeacher1);
            this.splitContainer1.Panel1.Controls.Add(this.ucRoom1);
            this.splitContainer1.Panel1.Controls.Add(this.ucMgtTeacher1);
            this.splitContainer1.Panel1.Controls.Add(this.ucMgtSubject1);
            this.splitContainer1.Panel1.Controls.Add(this.ucMgtRoom1);
            this.splitContainer1.Panel1.Controls.Add(this.ucPromotion1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.calendar);
            this.splitContainer1.Size = new System.Drawing.Size(950, 641);
            this.splitContainer1.SplitterDistance = 323;
            this.splitContainer1.TabIndex = 1;
            // 
            // ucMgtPeriod1
            // 
            this.ucMgtPeriod1.Location = new System.Drawing.Point(0, 0);
            this.ucMgtPeriod1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucMgtPeriod1.Name = "ucMgtPeriod1";
            this.ucMgtPeriod1.Size = new System.Drawing.Size(632, 433);
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
            // previousMonthButton
            // 
            this.previousMonthButton.Location = new System.Drawing.Point(16, 279);
            this.previousMonthButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.previousMonthButton.Name = "previousMonthButton";
            this.previousMonthButton.Size = new System.Drawing.Size(68, 19);
            this.previousMonthButton.TabIndex = 7;
            this.previousMonthButton.Text = "Mois précédent";
            this.previousMonthButton.UseVisualStyleBackColor = true;
            this.previousMonthButton.Click += new System.EventHandler(this.previousMonthButton_Click);
            // 
            // nextMonthButton
            // 
            this.nextMonthButton.Location = new System.Drawing.Point(110, 279);
            this.nextMonthButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.nextMonthButton.Name = "nextMonthButton";
            this.nextMonthButton.Size = new System.Drawing.Size(56, 19);
            this.nextMonthButton.TabIndex = 6;
            this.nextMonthButton.Text = "Mois suivant";
            this.nextMonthButton.UseVisualStyleBackColor = true;
            this.nextMonthButton.Click += new System.EventHandler(this.nextMonthButton_Click);
            // 
            // ucTeacher1
            // 
            this.ucTeacher1.Location = new System.Drawing.Point(2, 2);
            this.ucTeacher1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucTeacher1.Name = "ucTeacher1";
            this.ucTeacher1.Size = new System.Drawing.Size(307, 411);
            this.ucTeacher1.TabIndex = 5;
            this.ucTeacher1.Visible = false;
            // 
            // ucRoom1
            // 
            this.ucRoom1.Location = new System.Drawing.Point(2, 2);
            this.ucRoom1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            this.ucPromotion1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ucPromotion1.Name = "ucPromotion1";
            this.ucPromotion1.Size = new System.Drawing.Size(307, 411);
            this.ucPromotion1.TabIndex = 0;
            // 
            // calendar
            // 
            this.calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
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
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(623, 641);
            this.calendar.TabIndex = 0;
            this.calendar.Text = "calendar1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.périodeToolStripMenuItem,
            this.vueToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(950, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // périodeToolStripMenuItem
            // 
            this.périodeToolStripMenuItem.Name = "périodeToolStripMenuItem";
            this.périodeToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.périodeToolStripMenuItem.Text = "Période";
            this.périodeToolStripMenuItem.Click += new System.EventHandler(this.périodeToolStripMenuItem_Click);
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
            // PlannITI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 665);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PlannITI";
            this.Text = "Plann";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.Button nextMonthButton;
        private System.Windows.Forms.Button previousMonthButton;



    }
}

