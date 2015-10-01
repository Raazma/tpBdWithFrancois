namespace Tp2BdCombinaisonFinal
{
    partial class Form_Fournisseur
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
            this.Btn_Search = new System.Windows.Forms.Button();
            this.Tb_Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Remove = new System.Windows.Forms.Button();
            this.Btn_Cancel = new System.Windows.Forms.Button();
            this.Dtv_Info_Fournisseur = new System.Windows.Forms.DataGridView();
            this.Btn_Modif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_Info_Fournisseur)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Search
            // 
            this.Btn_Search.Location = new System.Drawing.Point(394, 33);
            this.Btn_Search.Name = "Btn_Search";
            this.Btn_Search.Size = new System.Drawing.Size(70, 22);
            this.Btn_Search.TabIndex = 1;
            this.Btn_Search.Text = "Recherche";
            this.Btn_Search.UseVisualStyleBackColor = true;
            this.Btn_Search.Click += new System.EventHandler(this.Btn_Search_Click);
            // 
            // Tb_Search
            // 
            this.Tb_Search.Location = new System.Drawing.Point(119, 35);
            this.Tb_Search.Name = "Tb_Search";
            this.Tb_Search.Size = new System.Drawing.Size(264, 20);
            this.Tb_Search.TabIndex = 2;
            this.Tb_Search.TextChanged += new System.EventHandler(this.Tb_Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nom du fournisseur: ";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Location = new System.Drawing.Point(389, 236);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(75, 23);
            this.Btn_Add.TabIndex = 4;
            this.Btn_Add.Text = "Ajouter";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Remove
            // 
            this.Btn_Remove.Location = new System.Drawing.Point(215, 235);
            this.Btn_Remove.Name = "Btn_Remove";
            this.Btn_Remove.Size = new System.Drawing.Size(75, 23);
            this.Btn_Remove.TabIndex = 5;
            this.Btn_Remove.Text = "Supprimer";
            this.Btn_Remove.UseVisualStyleBackColor = true;
            this.Btn_Remove.Click += new System.EventHandler(this.Btn_Remove_Click);
            // 
            // Btn_Cancel
            // 
            this.Btn_Cancel.Location = new System.Drawing.Point(389, 266);
            this.Btn_Cancel.Name = "Btn_Cancel";
            this.Btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.Btn_Cancel.TabIndex = 6;
            this.Btn_Cancel.Text = "Quitter";
            this.Btn_Cancel.UseVisualStyleBackColor = true;
            this.Btn_Cancel.Click += new System.EventHandler(this.Btn_Cancel_Click);
            // 
            // Dtv_Info_Fournisseur
            // 
            this.Dtv_Info_Fournisseur.AllowUserToAddRows = false;
            this.Dtv_Info_Fournisseur.AllowUserToDeleteRows = false;
            this.Dtv_Info_Fournisseur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtv_Info_Fournisseur.Location = new System.Drawing.Point(12, 75);
            this.Dtv_Info_Fournisseur.Name = "Dtv_Info_Fournisseur";
            this.Dtv_Info_Fournisseur.RowHeadersVisible = false;
            this.Dtv_Info_Fournisseur.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dtv_Info_Fournisseur.Size = new System.Drawing.Size(452, 155);
            this.Dtv_Info_Fournisseur.TabIndex = 7;
            // 
            // Btn_Modif
            // 
            this.Btn_Modif.Location = new System.Drawing.Point(308, 235);
            this.Btn_Modif.Name = "Btn_Modif";
            this.Btn_Modif.Size = new System.Drawing.Size(75, 23);
            this.Btn_Modif.TabIndex = 8;
            this.Btn_Modif.Text = "Modifier";
            this.Btn_Modif.UseVisualStyleBackColor = true;
            this.Btn_Modif.Click += new System.EventHandler(this.Btn_Modif_Click);
            // 
            // Form_Fournisseur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(476, 301);
            this.Controls.Add(this.Btn_Modif);
            this.Controls.Add(this.Dtv_Info_Fournisseur);
            this.Controls.Add(this.Btn_Cancel);
            this.Controls.Add(this.Btn_Remove);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_Search);
            this.Controls.Add(this.Btn_Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form_Fournisseur";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Fournisseur_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_Info_Fournisseur)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Search;
        private System.Windows.Forms.TextBox Tb_Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Remove;
        private System.Windows.Forms.Button Btn_Cancel;
        private System.Windows.Forms.DataGridView Dtv_Info_Fournisseur;
        private System.Windows.Forms.Button Btn_Modif;
    }
}