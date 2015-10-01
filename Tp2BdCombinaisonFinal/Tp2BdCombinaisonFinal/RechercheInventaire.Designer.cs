namespace Tp2BdCombinaisonFinal
{
    partial class RechercheInventaire
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
            this.TB_Recherche = new System.Windows.Forms.TextBox();
            this.LBL_Description = new System.Windows.Forms.Label();
            this.BTN_Recherche = new System.Windows.Forms.Button();
            this.DGV_Inventaire = new System.Windows.Forms.DataGridView();
            this.BTN_Ajouter = new System.Windows.Forms.Button();
            this.BTN_Modifier = new System.Windows.Forms.Button();
            this.BTN_Supprimer = new System.Windows.Forms.Button();
            this.BTN_Commandes = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventaire)).BeginInit();
            this.SuspendLayout();
            // 
            // TB_Recherche
            // 
            this.TB_Recherche.Location = new System.Drawing.Point(78, 14);
            this.TB_Recherche.Name = "TB_Recherche";
            this.TB_Recherche.Size = new System.Drawing.Size(456, 20);
            this.TB_Recherche.TabIndex = 0;
          
            // 
            // LBL_Description
            // 
            this.LBL_Description.AutoSize = true;
            this.LBL_Description.Location = new System.Drawing.Point(12, 17);
            this.LBL_Description.Name = "LBL_Description";
            this.LBL_Description.Size = new System.Drawing.Size(60, 13);
            this.LBL_Description.TabIndex = 1;
            this.LBL_Description.Text = "Description";
            // 
            // BTN_Recherche
            // 
            this.BTN_Recherche.Location = new System.Drawing.Point(540, 12);
            this.BTN_Recherche.Name = "BTN_Recherche";
            this.BTN_Recherche.Size = new System.Drawing.Size(75, 23);
            this.BTN_Recherche.TabIndex = 2;
            this.BTN_Recherche.Text = "Rechercher";
            this.BTN_Recherche.UseVisualStyleBackColor = true;
            this.BTN_Recherche.Click += new System.EventHandler(this.BTN_Recherche_Click);
            // 
            // DGV_Inventaire
            // 
            this.DGV_Inventaire.AllowUserToAddRows = false;
            this.DGV_Inventaire.AllowUserToDeleteRows = false;
            this.DGV_Inventaire.AllowUserToResizeColumns = false;
            this.DGV_Inventaire.AllowUserToResizeRows = false;
            this.DGV_Inventaire.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Inventaire.Location = new System.Drawing.Point(15, 40);
            this.DGV_Inventaire.MultiSelect = false;
            this.DGV_Inventaire.Name = "DGV_Inventaire";
            this.DGV_Inventaire.ReadOnly = true;
            this.DGV_Inventaire.RowHeadersVisible = false;
            this.DGV_Inventaire.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Inventaire.Size = new System.Drawing.Size(600, 207);
            this.DGV_Inventaire.TabIndex = 3;
            // 
            // BTN_Ajouter
            // 
            this.BTN_Ajouter.Location = new System.Drawing.Point(540, 253);
            this.BTN_Ajouter.Name = "BTN_Ajouter";
            this.BTN_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Ajouter.TabIndex = 4;
            this.BTN_Ajouter.Text = "Ajouter";
            this.BTN_Ajouter.UseVisualStyleBackColor = true;
            this.BTN_Ajouter.Click += new System.EventHandler(this.BTN_Ajouter_Click);
            // 
            // BTN_Modifier
            // 
            this.BTN_Modifier.Location = new System.Drawing.Point(459, 253);
            this.BTN_Modifier.Name = "BTN_Modifier";
            this.BTN_Modifier.Size = new System.Drawing.Size(75, 23);
            this.BTN_Modifier.TabIndex = 5;
            this.BTN_Modifier.Text = "Modifier";
            this.BTN_Modifier.UseVisualStyleBackColor = true;
            this.BTN_Modifier.Click += new System.EventHandler(this.BTN_Modifier_Click);
            // 
            // BTN_Supprimer
            // 
            this.BTN_Supprimer.Location = new System.Drawing.Point(378, 253);
            this.BTN_Supprimer.Name = "BTN_Supprimer";
            this.BTN_Supprimer.Size = new System.Drawing.Size(75, 23);
            this.BTN_Supprimer.TabIndex = 6;
            this.BTN_Supprimer.Text = "Supprimer";
            this.BTN_Supprimer.UseVisualStyleBackColor = true;
            this.BTN_Supprimer.Click += new System.EventHandler(this.BTN_Supprimer_Click);
            // 
            // BTN_Commandes
            // 
            this.BTN_Commandes.Location = new System.Drawing.Point(15, 253);
            this.BTN_Commandes.Name = "BTN_Commandes";
            this.BTN_Commandes.Size = new System.Drawing.Size(122, 23);
            this.BTN_Commandes.TabIndex = 7;
            this.BTN_Commandes.Text = "Produits à commander";
            this.BTN_Commandes.UseVisualStyleBackColor = true;
            this.BTN_Commandes.Click += new System.EventHandler(this.BTN_Commandes_Click);
            // 
            // RechercheInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 283);
            this.Controls.Add(this.BTN_Commandes);
            this.Controls.Add(this.BTN_Supprimer);
            this.Controls.Add(this.BTN_Modifier);
            this.Controls.Add(this.BTN_Ajouter);
            this.Controls.Add(this.DGV_Inventaire);
            this.Controls.Add(this.BTN_Recherche);
            this.Controls.Add(this.LBL_Description);
            this.Controls.Add(this.TB_Recherche);
            this.Name = "RechercheInventaire";
            this.Text = "Gestion de l\'inventaire";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RechercheInventaire_FormClosing);
            this.Load += new System.EventHandler(this.RechercheInventaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Inventaire)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Recherche;
        private System.Windows.Forms.Label LBL_Description;
        private System.Windows.Forms.Button BTN_Recherche;
        private System.Windows.Forms.DataGridView DGV_Inventaire;
        private System.Windows.Forms.Button BTN_Ajouter;
        private System.Windows.Forms.Button BTN_Modifier;
        private System.Windows.Forms.Button BTN_Supprimer;
        private System.Windows.Forms.Button BTN_Commandes;
    }
}