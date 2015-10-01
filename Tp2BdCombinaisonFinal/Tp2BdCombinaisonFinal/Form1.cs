using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp2BdCombinaisonFinal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Gestion_F_Click(object sender, EventArgs e)
        {
            Form_Fournisseur form = new Form_Fournisseur();

            if (form.ShowDialog() == DialogResult.OK)
            { 
            
            
            }
        }

        private void Btn_Gestion_P_Click(object sender, EventArgs e)
        {
            RechercheInventaire form = new RechercheInventaire();

            if(form.ShowDialog() == DialogResult.OK)
            {


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
