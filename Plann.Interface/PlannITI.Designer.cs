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
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.calendar = new System.Windows.Forms.Calendar.Calendar();
            this.savePeriod = new System.Windows.Forms.Button();
            this.ucPromotion1 = new Plann.Interface.UcPromotion();
            this.ucMgtRoom1 = new Plann.Interface.UcMgtRoom();
            this.ucMgtTeacher1 = new Plann.Interface.UcMgtTeacher();
            this.ucMgtSubject1 = new Plann.Interface.UcMgtSubject();
            this.loadPeriod = new System.Windows.Forms.Button();
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
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.loadPeriod);
            this.splitContainer1.Panel1.Controls.Add(this.ucPromotion1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.calendar);
            this.splitContainer1.Size = new System.Drawing.Size(1267, 818);
            this.splitContainer1.SplitterDistance = 436;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
            // 
            // calendar
            // 
            this.calendar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.calendar.FirstDayOfWeek = System.DayOfWeek.Monday;
            this.calendar.Font = new System.Drawing.Font("Segoe UI", 11.4F);
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
            this.calendar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.calendar.MaximumFullDays = 0;
            this.calendar.Name = "calendar";
            this.calendar.Size = new System.Drawing.Size(826, 818);
            this.calendar.TabIndex = 0;
            this.calendar.Text = "calendar1";
            // 
            // savePeriod
            // 
            this.savePeriod.Location = new System.Drawing.Point(77, 440);
            this.savePeriod.Name = "savePeriod";
            this.savePeriod.Size = new System.Drawing.Size(197, 44);
            this.savePeriod.TabIndex = 1;
            this.savePeriod.Text = "Sauvegarder la période actuelle";
            this.savePeriod.UseVisualStyleBackColor = true;
            this.savePeriod.Click += new System.EventHandler(this.savePeriod_Click);
            // 
            // ucPromotion1
            // 
            this.ucPromotion1.Location = new System.Drawing.Point(3, 2);
            this.ucPromotion1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucPromotion1.Name = "ucPromotion1";
            this.ucPromotion1.Size = new System.Drawing.Size(416, 530);
            this.ucPromotion1.TabIndex = 0;
            // 
            // ucMgtRoom1
            // 
            this.ucMgtRoom1.Location = new System.Drawing.Point(401, 278);
            this.ucMgtRoom1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucMgtRoom1.Name = "ucMgtRoom1";
            this.ucMgtRoom1.Size = new System.Drawing.Size(540, 526);
            this.ucMgtRoom1.TabIndex = 2;
            // 
            // ucMgtTeacher1
            // 
            this.ucMgtTeacher1.Location = new System.Drawing.Point(532, -33);
            this.ucMgtTeacher1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucMgtTeacher1.Name = "ucMgtTeacher1";
            this.ucMgtTeacher1.Size = new System.Drawing.Size(540, 526);
            this.ucMgtTeacher1.TabIndex = 1;
            // 
            // ucMgtSubject1
            // 
            this.ucMgtSubject1.Location = new System.Drawing.Point(-21, -12);
            this.ucMgtSubject1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucMgtSubject1.Name = "ucMgtSubject1";
            this.ucMgtSubject1.Size = new System.Drawing.Size(545, 623);
            this.ucMgtSubject1.TabIndex = 0;
            // 
            // loadPeriod
            // 
            this.loadPeriod.Location = new System.Drawing.Point(77, 490);
            this.loadPeriod.Name = "loadPeriod";
            this.loadPeriod.Size = new System.Drawing.Size(197, 44);
            this.loadPeriod.TabIndex = 3;
            this.loadPeriod.Text = "Charger une période";
            this.loadPeriod.UseVisualStyleBackColor = true;
            this.loadPeriod.Click += new System.EventHandler(this.loadPeriod_Click);
            // 
            // PlannITI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1267, 818);
            this.Controls.Add(this.savePeriod);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ucMgtRoom1);
            this.Controls.Add(this.ucMgtTeacher1);
            this.Controls.Add(this.ucMgtSubject1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private UcMgtSubject ucMgtSubject1;
        private UcMgtTeacher ucMgtTeacher1;
        private UcMgtRoom ucMgtRoom1;
        private UcPromotion ucPromotion1;
        private System.Windows.Forms.Button savePeriod;
        private System.Windows.Forms.Button loadPeriod;



    }
}

