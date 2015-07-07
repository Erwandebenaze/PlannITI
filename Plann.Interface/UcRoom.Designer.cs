namespace Plann.Interface
{
    partial class UcRoom
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
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            this.promotionComboBox = new System.Windows.Forms.ComboBox();
            this.sectorComboBox = new System.Windows.Forms.ComboBox();
            this.managePromotionsLink = new System.Windows.Forms.LinkLabel();
            this.subjectComboBox = new System.Windows.Forms.ComboBox();
            this.roomComboBox = new System.Windows.Forms.ComboBox();
            this.teacherComboBox = new System.Windows.Forms.ComboBox();
            this.manageSubjectsLink = new System.Windows.Forms.LinkLabel();
            this.manageRoomsLink = new System.Windows.Forms.LinkLabel();
            this.manageTeachersLink = new System.Windows.Forms.LinkLabel();
            this.texBoxAddText = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(13, 139);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(54, 13);
            label1.TabIndex = 0;
            label1.Text = "Promotion";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(108, 139);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(34, 13);
            label2.TabIndex = 1;
            label2.Text = "Filière";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(10, 106);
            label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(87, 20);
            label3.TabIndex = 5;
            label3.Text = "Affectation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(12, 195);
            label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(42, 13);
            label4.TabIndex = 6;
            label4.Text = "Matière";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(12, 11);
            label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(30, 13);
            label5.TabIndex = 8;
            label5.Text = "Salle";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(12, 261);
            label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(57, 13);
            label6.TabIndex = 10;
            label6.Text = "Professeur";
            // 
            // promotionComboBox
            // 
            this.promotionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.promotionComboBox.FormattingEnabled = true;
            this.promotionComboBox.Location = new System.Drawing.Point(15, 155);
            this.promotionComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.promotionComboBox.Name = "promotionComboBox";
            this.promotionComboBox.Size = new System.Drawing.Size(92, 21);
            this.promotionComboBox.TabIndex = 2;
            this.promotionComboBox.Click += new System.EventHandler(this.promotionComboBox_Click);
            // 
            // sectorComboBox
            // 
            this.sectorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sectorComboBox.FormattingEnabled = true;
            this.sectorComboBox.Items.AddRange(new object[] {
            "",
            "IL",
            "SR"});
            this.sectorComboBox.Location = new System.Drawing.Point(110, 155);
            this.sectorComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.sectorComboBox.Name = "sectorComboBox";
            this.sectorComboBox.Size = new System.Drawing.Size(92, 21);
            this.sectorComboBox.TabIndex = 3;
            // 
            // managePromotionsLink
            // 
            this.managePromotionsLink.AutoSize = true;
            this.managePromotionsLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.managePromotionsLink.Location = new System.Drawing.Point(206, 155);
            this.managePromotionsLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.managePromotionsLink.Name = "managePromotionsLink";
            this.managePromotionsLink.Size = new System.Drawing.Size(103, 13);
            this.managePromotionsLink.TabIndex = 4;
            this.managePromotionsLink.TabStop = true;
            this.managePromotionsLink.Text = "Gérer les promotions";
            this.managePromotionsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.managePromotionsLink_LinkClicked);
            // 
            // subjectComboBox
            // 
            this.subjectComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subjectComboBox.FormattingEnabled = true;
            this.subjectComboBox.Location = new System.Drawing.Point(13, 211);
            this.subjectComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.subjectComboBox.Name = "subjectComboBox";
            this.subjectComboBox.Size = new System.Drawing.Size(92, 21);
            this.subjectComboBox.TabIndex = 7;
            this.subjectComboBox.SelectedIndexChanged += new System.EventHandler(this.subjectComboBox_SelectedIndexChanged);
            this.subjectComboBox.Click += new System.EventHandler(this.subjectComboBox_Click);
            // 
            // roomComboBox
            // 
            this.roomComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roomComboBox.FormattingEnabled = true;
            this.roomComboBox.Location = new System.Drawing.Point(13, 27);
            this.roomComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.roomComboBox.Name = "roomComboBox";
            this.roomComboBox.Size = new System.Drawing.Size(92, 21);
            this.roomComboBox.TabIndex = 9;
            this.roomComboBox.SelectedIndexChanged += new System.EventHandler(this.roomComboBox_SelectedIndexChanged);
            this.roomComboBox.Click += new System.EventHandler(this.roomComboBox_Click);
            // 
            // teacherComboBox
            // 
            this.teacherComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.teacherComboBox.FormattingEnabled = true;
            this.teacherComboBox.Location = new System.Drawing.Point(13, 277);
            this.teacherComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.teacherComboBox.Name = "teacherComboBox";
            this.teacherComboBox.Size = new System.Drawing.Size(92, 21);
            this.teacherComboBox.TabIndex = 11;
            // 
            // manageSubjectsLink
            // 
            this.manageSubjectsLink.AutoSize = true;
            this.manageSubjectsLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.manageSubjectsLink.Location = new System.Drawing.Point(108, 217);
            this.manageSubjectsLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manageSubjectsLink.Name = "manageSubjectsLink";
            this.manageSubjectsLink.Size = new System.Drawing.Size(91, 13);
            this.manageSubjectsLink.TabIndex = 12;
            this.manageSubjectsLink.TabStop = true;
            this.manageSubjectsLink.Text = "Gérer les matières";
            this.manageSubjectsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manageSubjectsLink_LinkClicked);
            // 
            // manageRoomsLink
            // 
            this.manageRoomsLink.AutoSize = true;
            this.manageRoomsLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.manageRoomsLink.Location = new System.Drawing.Point(108, 29);
            this.manageRoomsLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manageRoomsLink.Name = "manageRoomsLink";
            this.manageRoomsLink.Size = new System.Drawing.Size(78, 13);
            this.manageRoomsLink.TabIndex = 13;
            this.manageRoomsLink.TabStop = true;
            this.manageRoomsLink.Text = "Gérer les salles";
            this.manageRoomsLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manageRoomsLink_LinkClicked);
            // 
            // manageTeachersLink
            // 
            this.manageTeachersLink.AutoSize = true;
            this.manageTeachersLink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(241)))), ((int)(((byte)(243)))));
            this.manageTeachersLink.Location = new System.Drawing.Point(108, 283);
            this.manageTeachersLink.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manageTeachersLink.Name = "manageTeachersLink";
            this.manageTeachersLink.Size = new System.Drawing.Size(106, 13);
            this.manageTeachersLink.TabIndex = 14;
            this.manageTeachersLink.TabStop = true;
            this.manageTeachersLink.Text = "Gérer les professeurs";
            this.manageTeachersLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.manageTeachersLink_LinkClicked);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(12, 325);
            label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(88, 13);
            label7.TabIndex = 20;
            label7.Text = "Texte additionnel";
            // 
            // texBoxAddText
            // 
            this.texBoxAddText.Location = new System.Drawing.Point(13, 341);
            this.texBoxAddText.Name = "texBoxAddText";
            this.texBoxAddText.Size = new System.Drawing.Size(100, 20);
            this.texBoxAddText.TabIndex = 19;
            // 
            // UcRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(label7);
            this.Controls.Add(this.texBoxAddText);
            this.Controls.Add(this.manageTeachersLink);
            this.Controls.Add(this.manageRoomsLink);
            this.Controls.Add(this.manageSubjectsLink);
            this.Controls.Add(this.teacherComboBox);
            this.Controls.Add(label6);
            this.Controls.Add(this.roomComboBox);
            this.Controls.Add(label5);
            this.Controls.Add(this.subjectComboBox);
            this.Controls.Add(label4);
            this.Controls.Add(label3);
            this.Controls.Add(this.managePromotionsLink);
            this.Controls.Add(this.sectorComboBox);
            this.Controls.Add(this.promotionComboBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UcRoom";
            this.Size = new System.Drawing.Size(307, 411);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel managePromotionsLink;
        private System.Windows.Forms.LinkLabel manageSubjectsLink;
        private System.Windows.Forms.LinkLabel manageRoomsLink;
        private System.Windows.Forms.LinkLabel manageTeachersLink;
        internal System.Windows.Forms.ComboBox promotionComboBox;
        internal System.Windows.Forms.ComboBox sectorComboBox;
        internal System.Windows.Forms.ComboBox subjectComboBox;
        internal System.Windows.Forms.ComboBox teacherComboBox;
        internal System.Windows.Forms.ComboBox roomComboBox;
        internal System.Windows.Forms.TextBox texBoxAddText;
    }
}
