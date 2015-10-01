namespace Tp2BdCombinaisonFinal
{
    partial class Form_Rapport
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
            this.CP_Report = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CP_Report
            // 
            this.CP_Report.ActiveViewIndex = -1;
            this.CP_Report.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CP_Report.Cursor = System.Windows.Forms.Cursors.Default;
            this.CP_Report.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CP_Report.Location = new System.Drawing.Point(0, 0);
            this.CP_Report.Name = "CP_Report";
            this.CP_Report.Size = new System.Drawing.Size(824, 627);
            this.CP_Report.TabIndex = 0;
            // 
            // Form_Rapport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 627);
            this.Controls.Add(this.CP_Report);
            this.Name = "Form_Rapport";
            this.Text = "Form_Rapport";
            this.Load += new System.EventHandler(this.Form_Rapport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CP_Report;
    }
}