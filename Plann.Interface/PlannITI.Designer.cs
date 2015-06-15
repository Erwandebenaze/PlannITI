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
            this.ucMgtTeacher1 = new Plann.Interface.UcMgtTeacher();
            this.ucMgtSubject1 = new Plann.Interface.UcMgtSubject();
            this.ucMgtRoom1 = new Plann.Interface.UcMgtRoom();
            this.SuspendLayout();
            // 
            // ucMgtTeacher1
            // 
            this.ucMgtTeacher1.Location = new System.Drawing.Point(399, -27);
            this.ucMgtTeacher1.Name = "ucMgtTeacher1";
            this.ucMgtTeacher1.Size = new System.Drawing.Size(405, 427);
            this.ucMgtTeacher1.TabIndex = 1;
            // 
            // ucMgtSubject1
            // 
            this.ucMgtSubject1.Location = new System.Drawing.Point(-16, -10);
            this.ucMgtSubject1.Name = "ucMgtSubject1";
            this.ucMgtSubject1.Size = new System.Drawing.Size(409, 506);
            this.ucMgtSubject1.TabIndex = 0;
            // 
            // ucMgtRoom1
            // 
            this.ucMgtRoom1.Location = new System.Drawing.Point(301, 226);
            this.ucMgtRoom1.Name = "ucMgtRoom1";
            this.ucMgtRoom1.Size = new System.Drawing.Size(405, 427);
            this.ucMgtRoom1.TabIndex = 2;
            // 
            // PlannITI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 665);
            this.Controls.Add(this.ucMgtRoom1);
            this.Controls.Add(this.ucMgtTeacher1);
            this.Controls.Add(this.ucMgtSubject1);
            this.Name = "PlannITI";
            this.Text = "Plann";
            this.ResumeLayout(false);

        }

        #endregion

        private UcMgtSubject ucMgtSubject1;
        private UcMgtTeacher ucMgtTeacher1;
        private UcMgtRoom ucMgtRoom1;



    }
}

