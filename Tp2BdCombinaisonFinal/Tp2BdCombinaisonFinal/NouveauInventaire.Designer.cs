namespace Tp2BdCombinaisonFinal
{
    partial class NouveauInventaire
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LBL_Description = new System.Windows.Forms.Label();
            this.TB_Description = new System.Windows.Forms.TextBox();
            this.CMB_Fournisseur = new System.Windows.Forms.ComboBox();
            this.LBL_Fournisseur = new System.Windows.Forms.Label();
            this.NUD_Stock = new System.Windows.Forms.NumericUpDown();
            this.LBL_Stock = new System.Windows.Forms.Label();
            this.LBL_Minimum = new System.Windows.Forms.Label();
            this.NUD_Minimum = new System.Windows.Forms.NumericUpDown();
            this.NUD_Maximum = new System.Windows.Forms.NumericUpDown();
            this.LBL_Maximum = new System.Windows.Forms.Label();
            this.BTN_Accepter = new System.Windows.Forms.Button();
            this.BTN_Annuler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Minimum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Maximum)).BeginInit();
            this.SuspendLayout();
            // 
            // LBL_Description
            // 
            this.LBL_Description.AutoSize = true;
            this.LBL_Description.Location = new System.Drawing.Point(12, 13);
            this.LBL_Description.Name = "LBL_Description";
            this.LBL_Description.Size = new System.Drawing.Size(60, 13);
            this.LBL_Description.TabIndex = 0;
            this.LBL_Description.Text = "Description";
            // 
            // TB_Description
            // 
            this.TB_Description.Location = new System.Drawing.Point(79, 10);
            this.TB_Description.Name = "TB_Description";
            this.TB_Description.Size = new System.Drawing.Size(193, 20);
            this.TB_Description.TabIndex = 1;
            this.TB_Description.TextChanged += new System.EventHandler(this.TB_Description_TextChanged);
            // 
            // CMB_Fournisseur
            // 
            this.CMB_Fournisseur.FormattingEnabled = true;
            this.CMB_Fournisseur.Location = new System.Drawing.Point(79, 36);
            this.CMB_Fournisseur.Name = "CMB_Fournisseur";
            this.CMB_Fournisseur.Size = new System.Drawing.Size(193, 21);
            this.CMB_Fournisseur.TabIndex = 2;
            this.CMB_Fournisseur.SelectedIndexChanged += new System.EventHandler(this.CMB_Fournisseur_SelectedIndexChanged);
            // 
            // LBL_Fournisseur
            // 
            this.LBL_Fournisseur.AutoSize = true;
            this.LBL_Fournisseur.Location = new System.Drawing.Point(12, 39);
            this.LBL_Fournisseur.Name = "LBL_Fournisseur";
            this.LBL_Fournisseur.Size = new System.Drawing.Size(61, 13);
            this.LBL_Fournisseur.TabIndex = 3;
            this.LBL_Fournisseur.Text = "Fournisseur";
            // 
            // NUD_Stock
            // 
            this.NUD_Stock.Location = new System.Drawing.Point(79, 64);
            this.NUD_Stock.Name = "NUD_Stock";
            this.NUD_Stock.Size = new System.Drawing.Size(193, 20);
            this.NUD_Stock.TabIndex = 4;
            this.NUD_Stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_Stock.ValueChanged += new System.EventHandler(this.NUD_Stock_ValueChanged);
            // 
            // LBL_Stock
            // 
            this.LBL_Stock.AutoSize = true;
            this.LBL_Stock.Location = new System.Drawing.Point(12, 66);
            this.LBL_Stock.Name = "LBL_Stock";
            this.LBL_Stock.Size = new System.Drawing.Size(35, 13);
            this.LBL_Stock.TabIndex = 5;
            this.LBL_Stock.Text = "Stock";
            // 
            // LBL_Minimum
            // 
            this.LBL_Minimum.AutoSize = true;
            this.LBL_Minimum.Location = new System.Drawing.Point(12, 92);
            this.LBL_Minimum.Name = "LBL_Minimum";
            this.LBL_Minimum.Size = new System.Drawing.Size(48, 13);
            this.LBL_Minimum.TabIndex = 6;
            this.LBL_Minimum.Text = "Minimum";
            // 
            // NUD_Minimum
            // 
            this.NUD_Minimum.Location = new System.Drawing.Point(79, 90);
            this.NUD_Minimum.Name = "NUD_Minimum";
            this.NUD_Minimum.Size = new System.Drawing.Size(193, 20);
            this.NUD_Minimum.TabIndex = 4;
            this.NUD_Minimum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_Minimum.ValueChanged += new System.EventHandler(this.NUD_Minimum_ValueChanged);
            // 
            // NUD_Maximum
            // 
            this.NUD_Maximum.Location = new System.Drawing.Point(79, 116);
            this.NUD_Maximum.Name = "NUD_Maximum";
            this.NUD_Maximum.Size = new System.Drawing.Size(193, 20);
            this.NUD_Maximum.TabIndex = 4;
            this.NUD_Maximum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NUD_Maximum.ValueChanged += new System.EventHandler(this.NUD_Maximum_ValueChanged);
            // 
            // LBL_Maximum
            // 
            this.LBL_Maximum.AutoSize = true;
            this.LBL_Maximum.Location = new System.Drawing.Point(12, 118);
            this.LBL_Maximum.Name = "LBL_Maximum";
            this.LBL_Maximum.Size = new System.Drawing.Size(51, 13);
            this.LBL_Maximum.TabIndex = 6;
            this.LBL_Maximum.Text = "Maximum";
            // 
            // BTN_Accepter
            // 
            this.BTN_Accepter.Location = new System.Drawing.Point(197, 142);
            this.BTN_Accepter.Name = "BTN_Accepter";
            this.BTN_Accepter.Size = new System.Drawing.Size(75, 23);
            this.BTN_Accepter.TabIndex = 7;
            this.BTN_Accepter.Text = "Accepter";
            this.BTN_Accepter.UseVisualStyleBackColor = true;
            this.BTN_Accepter.Click += new System.EventHandler(this.BTN_Accepter_Click);
            // 
            // BTN_Annuler
            // 
            this.BTN_Annuler.Location = new System.Drawing.Point(116, 142);
            this.BTN_Annuler.Name = "BTN_Annuler";
            this.BTN_Annuler.Size = new System.Drawing.Size(75, 23);
            this.BTN_Annuler.TabIndex = 7;
            this.BTN_Annuler.Text = "Annuler";
            this.BTN_Annuler.UseVisualStyleBackColor = true;
            this.BTN_Annuler.Click += new System.EventHandler(this.BTN_Annuler_Click);
            // 
            // NouveauInventaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.BTN_Annuler);
            this.Controls.Add(this.BTN_Accepter);
            this.Controls.Add(this.LBL_Maximum);
            this.Controls.Add(this.LBL_Minimum);
            this.Controls.Add(this.LBL_Stock);
            this.Controls.Add(this.NUD_Maximum);
            this.Controls.Add(this.NUD_Minimum);
            this.Controls.Add(this.NUD_Stock);
            this.Controls.Add(this.LBL_Fournisseur);
            this.Controls.Add(this.CMB_Fournisseur);
            this.Controls.Add(this.TB_Description);
            this.Controls.Add(this.LBL_Description);
            this.Name = "NouveauInventaire";
            this.Text = "NouveauInventaire";
            this.Load += new System.EventHandler(this.NouveauInventaire_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Minimum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Maximum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBL_Description;
        private System.Windows.Forms.TextBox TB_Description;
        private System.Windows.Forms.ComboBox CMB_Fournisseur;
        private System.Windows.Forms.Label LBL_Fournisseur;
        private System.Windows.Forms.NumericUpDown NUD_Stock;
        private System.Windows.Forms.Label LBL_Stock;
        private System.Windows.Forms.Label LBL_Minimum;
        private System.Windows.Forms.NumericUpDown NUD_Minimum;
        private System.Windows.Forms.NumericUpDown NUD_Maximum;
        private System.Windows.Forms.Label LBL_Maximum;
        private System.Windows.Forms.Button BTN_Accepter;
        private System.Windows.Forms.Button BTN_Annuler;
    }
}