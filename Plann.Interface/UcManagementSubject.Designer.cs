﻿namespace Plann.Interface
{
    partial class UcManagementSubject
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
            this.subjectNameComboBox = new System.Windows.Forms.ComboBox();
            this.teacherNameComboBox = new System.Windows.Forms.ComboBox();
            this.manageTeachersLink = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.validateButton = new System.Windows.Forms.Button();
            this.nameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colorColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.teacherColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(16, 7);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 18);
            label1.TabIndex = 0;
            label1.Text = "Intitulé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(145, 7);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 18);
            label2.TabIndex = 1;
            label2.Text = "Couleur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(239, 7);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 18);
            label3.TabIndex = 2;
            label3.Text = "Professeur référent";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.Location = new System.Drawing.Point(204, 7);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(0, 18);
            label4.TabIndex = 18;
            // 
            // subjectNameComboBox
            // 
            this.subjectNameComboBox.FormattingEnabled = true;
            this.subjectNameComboBox.Location = new System.Drawing.Point(3, 36);
            this.subjectNameComboBox.Name = "subjectNameComboBox";
            this.subjectNameComboBox.Size = new System.Drawing.Size(124, 24);
            this.subjectNameComboBox.TabIndex = 3;
            // 
            // teacherNameComboBox
            // 
            this.teacherNameComboBox.FormattingEnabled = true;
            this.teacherNameComboBox.Location = new System.Drawing.Point(242, 36);
            this.teacherNameComboBox.Name = "teacherNameComboBox";
            this.teacherNameComboBox.Size = new System.Drawing.Size(143, 24);
            this.teacherNameComboBox.TabIndex = 4;
            // 
            // manageTeachersLink
            // 
            this.manageTeachersLink.AutoSize = true;
            this.manageTeachersLink.Location = new System.Drawing.Point(239, 63);
            this.manageTeachersLink.Name = "manageTeachersLink";
            this.manageTeachersLink.Size = new System.Drawing.Size(146, 17);
            this.manageTeachersLink.TabIndex = 15;
            this.manageTeachersLink.TabStop = true;
            this.manageTeachersLink.Text = "Gérer les professeurs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 39);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.nameColumn);
            this.objectListView1.AllColumns.Add(this.colorColumn);
            this.objectListView1.AllColumns.Add(this.teacherColumn);
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.colorColumn,
            this.teacherColumn});
            this.objectListView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.objectListView1.Location = new System.Drawing.Point(0, 126);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(409, 380);
            this.objectListView1.TabIndex = 17;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(117, 92);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(183, 28);
            this.validateButton.TabIndex = 19;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            // 
            // nameColumn
            // 
            this.nameColumn.AspectName = "name";
            this.nameColumn.Text = "Nom";
            // 
            // colorColumn
            // 
            this.colorColumn.AspectName = "color";
            this.colorColumn.Text = "Couleur";
            // 
            // teacherColumn
            // 
            this.teacherColumn.AspectName = "referentTeacher";
            this.teacherColumn.Text = "Professeur référent";
            // 
            // UcManagementSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.validateButton);
            this.Controls.Add(label4);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.manageTeachersLink);
            this.Controls.Add(this.teacherNameComboBox);
            this.Controls.Add(this.subjectNameComboBox);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "UcManagementSubject";
            this.Size = new System.Drawing.Size(409, 506);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox subjectNameComboBox;
        private System.Windows.Forms.ComboBox teacherNameComboBox;
        private System.Windows.Forms.LinkLabel manageTeachersLink;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private System.Windows.Forms.Button validateButton;
        private BrightIdeasSoftware.OLVColumn nameColumn;
        private BrightIdeasSoftware.OLVColumn colorColumn;
        private BrightIdeasSoftware.OLVColumn teacherColumn;

    }
}
