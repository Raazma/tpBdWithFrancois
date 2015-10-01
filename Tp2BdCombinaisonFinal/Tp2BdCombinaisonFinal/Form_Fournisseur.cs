using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp2BdCombinaisonFinal
{
    public partial class Form_Fournisseur : Form
    {
        SqlConnection connexion;
        public Form_Fournisseur()
        {
            InitializeComponent();
        }

        private void Form_Fournisseur_Load(object sender, EventArgs e)
        {
            ConnecterBD();
            UpdateControls();
        }

        private void ConnecterBD()
        {

            String connexionChaine;
            connexionChaine = "Data Source=p104-11\\SQLEXPRESS2012;Initial Catalog=bdOperation;User ID=conOperation;Password=conOperation";
            connexion = new SqlConnection(connexionChaine);
            try
            {
                connexion.Open();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FermerBD()
        {
            try
            {
                connexion.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show("Impossible de fermer la connexion à la base de données");
            }
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            FermerBD();
            this.Close();
        }

        private void Btn_Add_Click(object sender, EventArgs e)
        {
            Ajout_Modif_Fournisseur_Form form = new Ajout_Modif_Fournisseur_Form(connexion);
            this.Hide();

            if (form.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();


            }
            Rechercher(Tb_Search.Text);
            UpdateControls();
        }

        private void Btn_Remove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Ete vous sure de vouloir supprimer le fournisseur #" + Dtv_Info_Fournisseur.SelectedRows[0].Cells[0].Value.ToString() + " ?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                deleteFournisseur(Dtv_Info_Fournisseur.SelectedRows[0].Cells[0].Value.ToString());
                Rechercher(Tb_Search.Text);
                UpdateControls();
            }

        }

        private void Rechercher(String name)
        {
            try
            {
                String researchCommand = "SELECT * FROM FOURNISSEUR WHERE NOMFOURNISSEUR LIKE '%" + name + "%'";
                SqlCommand research = new SqlCommand(researchCommand, connexion);
                SqlDataAdapter values = new SqlDataAdapter(research);
                DataTable data = new DataTable();
                values.Fill(data);
                Dtv_Info_Fournisseur.DataSource = data;
                research.Dispose();
            }
            catch (Exception e)
            { }
          

        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            Rechercher(Tb_Search.Text);
            Dtv_Info_Fournisseur.Refresh();
            UpdateControls();
        }

        private void Btn_Modif_Click(object sender, EventArgs e)
        {
            String id = "-1";
            if (Dtv_Info_Fournisseur.SelectedRows != null)
                id = Dtv_Info_Fournisseur.SelectedRows[0].Cells[0].Value.ToString();

            Ajout_Modif_Fournisseur_Form form = new Ajout_Modif_Fournisseur_Form(connexion, id);
            this.Hide();

            if (form.ShowDialog() == DialogResult.Cancel)
            {
                this.Show();

            }
            Rechercher(Tb_Search.Text);
            UpdateControls();
        }

        private void deleteFournisseur(String id)
        {
            String deleteQuery = "DELETE FROM FOURNISSEUR WHERE IDFOURNISSEUR = " + id;
            SqlCommand delete = new SqlCommand(deleteQuery, connexion);
            if(delete.ExecuteNonQuery()  >= 1)
            MessageBox.Show("Supression réussi du fournisseur #" + id);
            else
             MessageBox.Show("Erreur lors de la supression du fournisseur #" + id);

            delete.Dispose();



        }

        private void Tb_Search_TextChanged(object sender, EventArgs e)
        {



        }

        private void UpdateControls()
        {

            Btn_Modif.Enabled = Btn_Remove.Enabled = Dtv_Info_Fournisseur.Rows.Count >= 1;
                         
        }
    }
}
