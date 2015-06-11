namespace Plann.Interface
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
            this.subjectNameComboBox = new System.Windows.Forms.ComboBox();
            this.teacherNameComboBox = new System.Windows.Forms.ComboBox();
            this.manageTeachersLink = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label1.Location = new System.Drawing.Point(14, 28);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 18);
            label1.TabIndex = 0;
            label1.Text = "Intitulé";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(156, 28);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(60, 18);
            label2.TabIndex = 1;
            label2.Text = "Couleur";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label3.Location = new System.Drawing.Point(261, 28);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(135, 18);
            label3.TabIndex = 2;
            label3.Text = "Professeur référent";
            // 
            // subjectNameComboBox
            // 
            this.subjectNameComboBox.FormattingEnabled = true;
            this.subjectNameComboBox.Location = new System.Drawing.Point(17, 65);
            this.subjectNameComboBox.Name = "subjectNameComboBox";
            this.subjectNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.subjectNameComboBox.TabIndex = 3;
            // 
            // teacherNameComboBox
            // 
            this.teacherNameComboBox.FormattingEnabled = true;
            this.teacherNameComboBox.Location = new System.Drawing.Point(264, 65);
            this.teacherNameComboBox.Name = "teacherNameComboBox";
            this.teacherNameComboBox.Size = new System.Drawing.Size(121, 24);
            this.teacherNameComboBox.TabIndex = 4;
            // 
            // manageTeachersLink
            // 
            this.manageTeachersLink.AutoSize = true;
            this.manageTeachersLink.Location = new System.Drawing.Point(260, 0);
            this.manageTeachersLink.Name = "manageTeachersLink";
            this.manageTeachersLink.Size = new System.Drawing.Size(146, 17);
            this.manageTeachersLink.TabIndex = 15;
            this.manageTeachersLink.TabStop = true;
            this.manageTeachersLink.Text = "Gérer les professeurs";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 57);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(57, 39);
            this.button1.TabIndex = 16;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // objectListView1
            // 
            this.objectListView1.Location = new System.Drawing.Point(146, 178);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(121, 97);
            this.objectListView1.TabIndex = 17;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // UcManagementSubject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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

    }
}
