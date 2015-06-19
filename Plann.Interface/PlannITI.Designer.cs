namespace Plann.Interface
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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange6 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange7 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange8 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange9 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange10 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.calendar = new System.Windows.Forms.Calendar.Calendar();
            this.ucMgtSubject1 = new Plann.Interface.UcMgtSubject();
            this.ucPromotion1 = new Plann.Interface.UcPromotion();
            this.ucMgtRoom1 = new Plann.Interface.UcMgtRoom();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AccessibleName = "Sc1.Panel1";
            this.splitContainer1.Panel1.Controls.Add(this.ucMgtRoom1);
            this.splitContainer1.Panel1.Controls.Add(this.ucMgtSubject1);
            this.splitContainer1.Panel1.Controls.Add(this.ucPromotion1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.calendar);
            this.splitContainer1.Size = new System.Drawing.Size(950, 665);
            this.splitContainer1.SplitterDistance = 327;
            this.splitContainer1.TabIndex = 1;
            // 
            // calendar
            // 
            this.calendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            calendarHighlightRange6.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange6.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange6.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange7.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange7.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange7.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange8.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange8.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange8.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange9.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange9.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange9.StartTime = System.TimeSpan.Parse("08:00:00");
            calendarHighlightRange10.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange10.EndTime = System.TimeSpan.Parse("17:00:00");
            calendarHighlightRange10.StartTime = System.TimeSpan.Parse("08:00:00");
            this.calendar.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange6,
        calendarHighlightRange7,
        calendarHighlightRange8,
        calendarHighlightRange9,
        calendarHighlightRange10};
            this.calendar.Location = new System.Drawing.Point(0, 0);
            this.calendar.MaximumFullDays = 0;
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(619, 665);
            this.calendar.TabIndex = 0;
            this.calendar.Text = "calendar1";
            // 
            // ucMgtSubject1
            // 
            this.ucMgtSubject1.Location = new System.Drawing.Point(11, 35);
            this.ucMgtSubject1.Margin = new System.Windows.Forms.Padding(2);
            this.ucMgtSubject1.Name = "ucMgtSubject1";
            this.ucMgtSubject1.Size = new System.Drawing.Size(307, 411);
            this.ucMgtSubject1.TabIndex = 1;
            this.ucMgtSubject1.Visible = false;
            // 
            // ucPromotion1
            // 
            this.ucPromotion1.Location = new System.Drawing.Point(2, 2);
            this.ucPromotion1.Margin = new System.Windows.Forms.Padding(2);
            this.ucPromotion1.Name = "ucPromotion1";
            this.ucPromotion1.Size = new System.Drawing.Size(312, 431);
            this.ucPromotion1.TabIndex = 0;
            // 
            // ucMgtRoom1
            // 
            this.ucMgtRoom1.Location = new System.Drawing.Point(11, 35);
            this.ucMgtRoom1.Margin = new System.Windows.Forms.Padding(2);
            this.ucMgtRoom1.Name = "ucMgtRoom1";
            this.ucMgtRoom1.Size = new System.Drawing.Size(304, 347);
            this.ucMgtRoom1.TabIndex = 2;
            this.ucMgtRoom1.Visible = false;
            // 
            // PlannITI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 665);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PlannITI";
            this.Text = "Plann";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Calendar.Calendar calendar;
        private UcPromotion ucPromotion1;
        private UcMgtSubject ucMgtSubject1;
        private UcMgtRoom ucMgtRoom1;



    }
}

