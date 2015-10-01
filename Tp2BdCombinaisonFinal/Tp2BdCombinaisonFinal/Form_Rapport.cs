using CrystalDecisions.CrystalReports.Engine;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tp2BdCombinaisonFinal
{
    public partial class Form_Rapport : Form
    {
        ReportDocument doc;
        public Form_Rapport(ReportDocument doc)
        {
            InitializeComponent();
            this.doc = doc;
        }

        private void Form_Rapport_Load(object sender, EventArgs e)
        {
            CP_Report.ReportSource = doc;
            CP_Report.Refresh();
        }
    }
}
