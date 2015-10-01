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
    public partial class Commandes : Form
    {
        SqlConnection connexion;

        public Commandes(SqlConnection conn)
        {
            InitializeComponent();

            connexion = conn;
        }

        private void Commandes_Load(object sender, EventArgs e)
        {
            AfficherCommandes();
            UpdateControls();
        }

        private void AfficherCommandes()
        {
            String sql = "SELECT IDINVENTAIRE AS NuméroProduit, DESCRIPTIONINVENTAIRE AS Description, NOMFOURNISSEUR AS Fournisseur, QTEMINIMUM - QTESTOCK AS QuantitéÀCommander " +
                "FROM INVENTAIRE I INNER JOIN FOURNISSEUR F ON I.IDFOURNISSEUR = F.IDFOURNISSEUR " +
                "WHERE QTESTOCK < QTEMINIMUM";

            SqlCommand select = new SqlCommand(sql, connexion);

            SqlDataAdapter adapter = new SqlDataAdapter(select);
            DataTable resultats = new DataTable();
            adapter.Fill(resultats);
            DGV_Commandes.DataSource = resultats;

            adapter.Dispose();
            select.Dispose();
        }

        private bool Confirmer(String message)
        {
            return MessageBox.Show(message, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes;
        }

        private void Commander(int id)
        {
            int quantiteCommande = int.Parse(DGV_Commandes.SelectedCells[3].Value.ToString());
            String descriptionProduit = (String)DGV_Commandes.SelectedCells[1].Value;
            if (Confirmer("Êtes-vous sûr de vouloir commander " + quantiteCommande.ToString() + " \"" + descriptionProduit + "\" ?"))
            {
                String sql = "UPDATE INVENTAIRE SET QTESTOCK=QTEMINIMUM WHERE IDINVENTAIRE=" + id.ToString();
                SqlCommand update = new SqlCommand(sql, connexion);
                if (update.ExecuteNonQuery() >= 1)
                    MessageBox.Show("Commande effectuée avec succès");
                else
                    MessageBox.Show("Erreur lors de la commande");

                update.Dispose();
            }
        }

        private void BTN_Commander_Click(object sender, EventArgs e)
        {
            int id = int.Parse(DGV_Commandes.SelectedCells[0].Value.ToString());
            Commander(id);
            AfficherCommandes();
            UpdateControls();
        }

        private void UpdateControls()
        {
            BTN_Commander.Enabled = DGV_Commandes.Rows.Count > 0;
        }
    }
}
