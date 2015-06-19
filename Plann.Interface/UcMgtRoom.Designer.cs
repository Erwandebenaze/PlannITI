namespace Plann.Interface
{
    partial class UcMgtRoom
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
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.numberOfSeatsTextBox = new System.Windows.Forms.TextBox();
            this.objectListView1 = new BrightIdeasSoftware.ObjectListView();
            this.nameColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.mailColumn = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.validateButton = new System.Windows.Forms.Button();
            this.returnLink = new System.Windows.Forms.LinkLabel();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(27, 22);
            label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(79, 13);
            label1.TabIndex = 0;
            label1.Text = "Nom de la salle";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(139, 22);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(93, 13);
            label2.TabIndex = 1;
            label2.Text = "Nombre de places";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(29, 47);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(76, 20);
            this.nameTextBox.TabIndex = 2;
            // 
            // numberOfSeatsTextBox
            // 
            this.numberOfSeatsTextBox.Location = new System.Drawing.Point(141, 47);
            this.numberOfSeatsTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.numberOfSeatsTextBox.Name = "numberOfSeatsTextBox";
            this.numberOfSeatsTextBox.Size = new System.Drawing.Size(76, 20);
            this.numberOfSeatsTextBox.TabIndex = 3;
            // 
            // objectListView1
            // 
            this.objectListView1.AllColumns.Add(this.nameColumn);
            this.objectListView1.AllColumns.Add(this.mailColumn);
            this.objectListView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn,
            this.mailColumn});
            this.objectListView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.objectListView1.Location = new System.Drawing.Point(0, 119);
            this.objectListView1.Margin = new System.Windows.Forms.Padding(2);
            this.objectListView1.Name = "objectListView1";
            this.objectListView1.Size = new System.Drawing.Size(304, 228);
            this.objectListView1.TabIndex = 4;
            this.objectListView1.UseCompatibleStateImageBehavior = false;
            this.objectListView1.View = System.Windows.Forms.View.Details;
            // 
            // nameColumn
            // 
            this.nameColumn.AspectName = "Name";
            this.nameColumn.Groupable = false;
            this.nameColumn.Text = "Nom de la salle";
            this.nameColumn.Width = 147;
            // 
            // mailColumn
            // 
            this.mailColumn.AspectName = "NumberOfSeats";
            this.mailColumn.FillsFreeSpace = true;
            this.mailColumn.Text = "Nombre de places";
            this.mailColumn.Width = 61;
            // 
            // validateButton
            // 
            this.validateButton.Location = new System.Drawing.Point(97, 96);
            this.validateButton.Margin = new System.Windows.Forms.Padding(2);
            this.validateButton.Name = "validateButton";
            this.validateButton.Size = new System.Drawing.Size(56, 19);
            this.validateButton.TabIndex = 5;
            this.validateButton.Text = "Valider";
            this.validateButton.UseVisualStyleBackColor = true;
            this.validateButton.Click += new System.EventHandler(this.validateButton_Click);
            // 
            // returnLink
            // 
            this.returnLink.AutoSize = true;
            this.returnLink.Location = new System.Drawing.Point(233, 96);
            this.returnLink.Name = "returnLink";
            this.returnLink.Size = new System.Drawing.Size(39, 13);
            this.returnLink.TabIndex = 6;
            this.returnLink.TabStop = true;
            this.returnLink.Text = "Retour";
            this.returnLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.returnLink_LinkClicked);
            // 
            // UcMgtRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.returnLink);
            this.Controls.Add(this.validateButton);
            this.Controls.Add(this.objectListView1);
            this.Controls.Add(this.numberOfSeatsTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(label2);
            this.Controls.Add(label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UcMgtRoom";
            this.Size = new System.Drawing.Size(304, 347);
            ((System.ComponentModel.ISupportInitialize)(this.objectListView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox numberOfSeatsTextBox;
        private BrightIdeasSoftware.ObjectListView objectListView1;
        private BrightIdeasSoftware.OLVColumn nameColumn;
        private BrightIdeasSoftware.OLVColumn mailColumn;
        private System.Windows.Forms.Button validateButton;
        private System.Windows.Forms.LinkLabel returnLink;
    }
}
