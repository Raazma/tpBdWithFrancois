namespace Tp2BdCombinaisonFinal
{
    partial class Commandes
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
            this.DGV_Commandes = new System.Windows.Forms.DataGridView();
            this.BTN_Commander = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Commandes)).BeginInit();
            this.SuspendLayout();
            // 
            // DGV_Commandes
            // 
            this.DGV_Commandes.AllowUserToAddRows = false;
            this.DGV_Commandes.AllowUserToDeleteRows = false;
            this.DGV_Commandes.AllowUserToResizeColumns = false;
            this.DGV_Commandes.AllowUserToResizeRows = false;
            this.DGV_Commandes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_Commandes.Location = new System.Drawing.Point(12, 12);
            this.DGV_Commandes.MultiSelect = false;
            this.DGV_Commandes.Name = "DGV_Commandes";
            this.DGV_Commandes.RowHeadersVisible = false;
            this.DGV_Commandes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV_Commandes.Size = new System.Drawing.Size(403, 150);
            this.DGV_Commandes.TabIndex = 0;
            // 
            // BTN_Commander
            // 
            this.BTN_Commander.Location = new System.Drawing.Point(340, 167);
            this.BTN_Commander.Name = "BTN_Commander";
            this.BTN_Commander.Size = new System.Drawing.Size(75, 23);
            this.BTN_Commander.TabIndex = 1;
            this.BTN_Commander.Text = "Commander";
            this.BTN_Commander.UseVisualStyleBackColor = true;
            this.BTN_Commander.Click += new System.EventHandler(this.BTN_Commander_Click);
            // 
            // Commandes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 202);
            this.Controls.Add(this.BTN_Commander);
            this.Controls.Add(this.DGV_Commandes);
            this.Name = "Commandes";
            this.Text = "Commandes";
            this.Load += new System.EventHandler(this.Commandes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_Commandes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGV_Commandes;
        private System.Windows.Forms.Button BTN_Commander;
    }
}