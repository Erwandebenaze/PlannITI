namespace Plann.Interface
{
    partial class UcMgtPeriod
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.begginingButton = new System.Windows.Forms.Button();
            this.begginingDateText = new System.Windows.Forms.Label();
            this.endingDateText = new System.Windows.Forms.Label();
            this.endingButton = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(29, 37);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(124, 17);
            label1.TabIndex = 0;
            label1.Text = "Nom de la période";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(175, 37);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 17);
            label2.TabIndex = 1;
            label2.Text = "Date début";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(268, 37);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(57, 17);
            label3.TabIndex = 2;
            label3.Text = "Date fin";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(249, 176);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 3;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(32, 70);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 4;
            // 
            // begginingButton
            // 
            this.begginingButton.Location = new System.Drawing.Point(178, 94);
            this.begginingButton.Name = "begginingButton";
            this.begginingButton.Size = new System.Drawing.Size(75, 23);
            this.begginingButton.TabIndex = 5;
            this.begginingButton.Text = "Choisir";
            this.begginingButton.UseVisualStyleBackColor = true;
            this.begginingButton.Click += new System.EventHandler(this.begginingButton_Click);
            // 
            // begginingDateText
            // 
            this.begginingDateText.AutoSize = true;
            this.begginingDateText.Location = new System.Drawing.Point(178, 74);
            this.begginingDateText.Name = "begginingDateText";
            this.begginingDateText.Size = new System.Drawing.Size(0, 17);
            this.begginingDateText.TabIndex = 6;
            // 
            // endingDateText
            // 
            this.endingDateText.AutoSize = true;
            this.endingDateText.Location = new System.Drawing.Point(268, 73);
            this.endingDateText.Name = "endingDateText";
            this.endingDateText.Size = new System.Drawing.Size(0, 17);
            this.endingDateText.TabIndex = 7;
            // 
            // endingButton
            // 
            this.endingButton.Location = new System.Drawing.Point(271, 94);
            this.endingButton.Name = "endingButton";
            this.endingButton.Size = new System.Drawing.Size(75, 23);
            this.endingButton.TabIndex = 8;
            this.endingButton.Text = "Choisir";
            this.endingButton.UseVisualStyleBackColor = true;
            this.endingButton.Click += new System.EventHandler(this.endingButton_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(438, 37);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 17);
            this.linkLabel1.TabIndex = 9;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Retour";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // UcMgtPeriod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.endingButton);
            this.Controls.Add(this.endingDateText);
            this.Controls.Add(this.begginingDateText);
            this.Controls.Add(this.begginingButton);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "UcMgtPeriod";
            this.Size = new System.Drawing.Size(620, 533);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Button begginingButton;
        private System.Windows.Forms.Label begginingDateText;
        private System.Windows.Forms.Label endingDateText;
        private System.Windows.Forms.Button endingButton;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}
