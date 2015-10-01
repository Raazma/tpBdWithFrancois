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
    public partial class RechercheInventaire : Form
    {
         SqlConnection connexion;

        public RechercheInventaire()
        {
            InitializeComponent();
        }

        private void RechercheInventaire_Load(object sender, EventArgs e)
        {
            ConnecterBD();
            UpdateControls();
        }

        private void RechercheInventaire_FormClosing(object sender, FormClosingEventArgs e)
        {
            FermerBD();
        }

        private void ConnecterBD()
        {
            String connexionChaine;
            connexionChaine = "Data Source=p104-11\\SQLEXPRESS2012;Initial Catalog=bdOperation;User ID=conOperation;Password=conOperation";
            connexion = new SqlConnection(connexionChaine);
            try
            {
                connexion.Open();
                MessageBox.Show("Connexion ouverte ! ");
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
                MessageBox.Show("Connexion fermée");
            }
            catch (Exception e)
            {
                MessageBox.Show("Impossible de fermer la connexion à la base de données");
            }
        }

        private void Rechercher(String motCle)
        {
            String sql = "SELECT IDINVENTAIRE AS NuméroProduit, DESCRIPTIONINVENTAIRE AS Description, NOMFOURNISSEUR AS Fournisseur, QTESTOCK AS QuantitéEnStock, QTEMINIMUM AS QuantitéMinimum, QTEMAXIMUM AS QuantitéMaximum FROM INVENTAIRE I " +
                "INNER JOIN FOURNISSEUR F ON I.IDFOURNISSEUR = F.IDFOURNISSEUR " +
                "WHERE DESCRIPTIONINVENTAIRE LIKE '%" + motCle + "%'";

            SqlCommand select = new SqlCommand(sql, connexion);

            SqlDataAdapter adapter = new SqlDataAdapter(select);
            DataTable resultats = new DataTable();
            adapter.Fill(resultats);
            DGV_Inventaire.DataSource = resultats;

            adapter.Dispose();
            select.Dispose();
        }

        private void Supprimer(int id)
        {
            if (Confirmer("Êtes-vous sûr de vouloir supprimer le produit #" + id.ToString() + " ?"))
            {
                String sql = "DELETE FROM INVENTAIRE WHERE IDINVENTAIRE=" + id.ToString();
                SqlCommand delete = new SqlCommand(sql, connexion);

                if (delete.ExecuteNonQuery() >= 1)
                    MessageBox.Show("Produit #" + id.ToString() + " supprimé avec succès");
                else
                    MessageBox.Show("Erreur lors de la suppression du produit #" + id.ToString());

                delete.Dispose();
            }
        }

        private bool Confirmer(String message)
        {
            return MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void UpdateControls()
        {
            BTN_Modifier.Enabled = BTN_Supprimer.Enabled = DGV_Inventaire.Rows.Count >= 1;
        }

        private void BTN_Recherche_Click(object sender, EventArgs e)
        {
            Rechercher(TB_Recherche.Text);
            UpdateControls();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            NouveauInventaire ajout = new NouveauInventaire(connexion);
            ajout.ShowDialog();
            Rechercher(TB_Recherche.Text);
            UpdateControls();
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DGV_Inventaire.SelectedCells[0].Value.ToString());
            NouveauInventaire modifier = new NouveauInventaire(connexion, id);
            modifier.ShowDialog();
            Rechercher(TB_Recherche.Text);
            UpdateControls();
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DGV_Inventaire.SelectedCells[0].Value.ToString());
            Supprimer(id);
            Rechercher(TB_Recherche.Text);
            UpdateControls();
        }

        private void BTN_Commandes_Click(object sender, EventArgs e)
        {
            Commandes commandes = new Commandes(connexion);
            commandes.ShowDialog();
            Rechercher(TB_Recherche.Text);
            UpdateControls();
        }

        
    
    }
}
