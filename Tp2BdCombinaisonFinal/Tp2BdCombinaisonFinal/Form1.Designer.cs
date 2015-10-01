namespace Tp2BdCombinaisonFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Gestion_F = new System.Windows.Forms.Button();
            this.Btn_Gestion_P = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Rapport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_Gestion_F
            // 
            this.Btn_Gestion_F.Location = new System.Drawing.Point(56, 74);
            this.Btn_Gestion_F.Name = "Btn_Gestion_F";
            this.Btn_Gestion_F.Size = new System.Drawing.Size(218, 45);
            this.Btn_Gestion_F.TabIndex = 0;
            this.Btn_Gestion_F.Text = "Gestion des Fournisseur";
            this.Btn_Gestion_F.UseVisualStyleBackColor = true;
            this.Btn_Gestion_F.Click += new System.EventHandler(this.Btn_Gestion_F_Click);
            // 
            // Btn_Gestion_P
            // 
            this.Btn_Gestion_P.Location = new System.Drawing.Point(56, 153);
            this.Btn_Gestion_P.Name = "Btn_Gestion_P";
            this.Btn_Gestion_P.Size = new System.Drawing.Size(218, 45);
            this.Btn_Gestion_P.TabIndex = 1;
            this.Btn_Gestion_P.Text = "Gestion des Produit";
            this.Btn_Gestion_P.UseVisualStyleBackColor = true;
            this.Btn_Gestion_P.Click += new System.EventHandler(this.Btn_Gestion_P_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(123, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Menu";
            // 
            // Btn_Rapport
            // 
            this.Btn_Rapport.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Rapport.Location = new System.Drawing.Point(56, 232);
            this.Btn_Rapport.Name = "Btn_Rapport";
            this.Btn_Rapport.Size = new System.Drawing.Size(218, 45);
            this.Btn_Rapport.TabIndex = 3;
            this.Btn_Rapport.Text = "Gestion des rapports";
            this.Btn_Rapport.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 354);
            this.Controls.Add(this.Btn_Rapport);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Gestion_P);
            this.Controls.Add(this.Btn_Gestion_F);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Gestion_F;
        private System.Windows.Forms.Button Btn_Gestion_P;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Rapport;
    }
}

