namespace Plann.Interface
{
    partial class UcMgtPromotion
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberOfStudentsTextBox = new System.Windows.Forms.TextBox();
            this.mailTextBox = new System.Windows.Forms.TextBox();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.nameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.numberOfStudentsColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.mailColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.validate = new System.Windows.Forms.Button();
            this.retour = new System.Windows.Forms.LinkLabel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 33);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(74, 17);
            label1.TabIndex = 0;
            label1.Text = "Nom/Code";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(108, 33);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(114, 17);
            label2.TabIndex = 1;
            label2.Text = "Nombre d\'élèves";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(245, 33);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(89, 17);
            label3.TabIndex = 2;
            label3.Text = "Adresse mail";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(3, 67);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 22);
            this.nameTextBox.TabIndex = 3;
            // 
            // numberOfStudentsTextBox
            // 
            this.numberOfStudentsTextBox.Location = new System.Drawing.Point(122, 67);
            this.numberOfStudentsTextBox.Name = "numberOfStudentsTextBox";
            this.numberOfStudentsTextBox.Size = new System.Drawing.Size(100, 22);
            this.numberOfStudentsTextBox.TabIndex = 4;
            // 
            // mailTextBox
            // 
            this.mailTextBox.Location = new System.Drawing.Point(248, 67);
            this.mailTextBox.Name = "mailTextBox";
            this.mailTextBox.Size = new System.Drawing.Size(100, 22);
            this.mailTextBox.TabIndex = 5;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.nameColumn);
            this.objectListView1.AllColumns.Add(this.numberOfStudentsColumn);
            this.objectListView1.AllColumns.Add(this.mailColumn);
            this.objectListView1.AlternateRowBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.numberOfStudentsColumn,
            this.mailColumn});
            this.objectListView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.objectListView1.Location = new System.Drawing.Point(0, 133);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.ShowGroups = false;
            this.objectListView1.Size = new System.Drawing.Size(381, 362);
            this.objectListView1.TabIndex = 6;
            this.objectListView1.UseAlternatingBackColors = true;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            this.objectListView1.CellClick += new System.EventHandler<BrightIdeasSoftware.CellClickEventArgs>(this.objectListView1_CellClick);
            // 
            // nameColumn
            // 
            this.nameColumn.AspectName = "Name";
            this.nameColumn.MinimumWidth = 75;
            this.nameColumn.Text = "Nom";
            this.nameColumn.UseFiltering = false;
            this.nameColumn.Width = 75;
            // 
            // numberOfStudentsColumn
            // 
            this.numberOfStudentsColumn.AspectName = "NumberOfStudents";
            this.numberOfStudentsColumn.MinimumWidth = 100;
            this.numberOfStudentsColumn.Text = "Nombre d\'élèves";
            this.numberOfStudentsColumn.UseFiltering = false;
            this.numberOfStudentsColumn.Width = 100;
            // 
            // mailColumn
            // 
            this.mailColumn.AspectName = "Mail";
            this.mailColumn.MinimumWidth = 100;
            this.mailColumn.UseFiltering = false;
            this.mailColumn.Width = 100;
            // 
            // validate
            // 
            this.validate.Location = new System.Drawing.Point(122, 104);
            this.validate.Name = "validate";
            this.validate.Size = new System.Drawing.Size(86, 31);
            this.validate.TabIndex = 7;
            this.validate.Text = "Valider";
            this.validate.UseVisualStyleBackColor = true;
            this.validate.Click += new System.EventHandler(this.validate_Click);
            // 
            // retour
            // 
            this.retour.AutoSize = true;
            this.retour.Location = new System.Drawing.Point(292, 110);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(51, 17);
            this.retour.TabIndex = 8;
            this.retour.TabStop = true;
            this.retour.Text = "Retour";
            this.retour.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.retour_LinkClicked);
            // 
            // UcMgtPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.retour);
            this.Controls.Add(this.validate);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.mailTextBox);
            this.Controls.Add(this.numberOfStudentsTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(label3);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Name = "UcMgtPromotion";
            this.Size = new System.Drawing.Size(381, 495);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numberOfStudentsTextBox;
        private System.Windows.Forms.TextBox mailTextBox;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn nameColumn;
        private BrightIdeasSoftware.OLVColumn numberOfStudentsColumn;
        private BrightIdeasSoftware.OLVColumn mailColumn;
        private System.Windows.Forms.Button validate;
        private System.Windows.Forms.LinkLabel retour;
    }
}
