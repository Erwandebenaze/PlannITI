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
            this.ucManagementSubject1 = new Plann.Interface.UcManagementSubject();
            this.SuspendLayout();
            // 
            // ucManagementSubject1
            // 
            this.ucManagementSubject1.Location = new System.Drawing.Point(131, 12);
            this.ucManagementSubject1.Name = "ucManagementSubject1";
            this.ucManagementSubject1.Size = new System.Drawing.Size(409, 506);
            this.ucManagementSubject1.TabIndex = 0;
            // 
            // PlannITI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 490);
            this.Controls.Add(this.ucManagementSubject1);
            this.Name = "PlannITI";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private UcManagementSubject ucManagementSubject1;
    }
}

