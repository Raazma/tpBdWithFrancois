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
    public partial class NouveauInventaire : Form
    {
        SqlConnection connexion;
        bool modification;
        int idInventaire;

        public NouveauInventaire(SqlConnection conn)
        {
            InitializeComponent();

            connexion = conn;

            modification = false;
        }

        public NouveauInventaire(SqlConnection conn, int id)
        {
            InitializeComponent();

            connexion = conn;

            modification = true;
            idInventaire = id;
            BTN_Accepter.Text = "Mettre à jour";
        }

        private void NouveauInventaire_Load(object sender, EventArgs e)
        {
            ChargerListeFournisseur();

            if (modification)
                ChargerInventaire();
        }

        private void ChargerListeFournisseur()
        {
            String sql = "SELECT NOMFOURNISSEUR FROM FOURNISSEUR";
            SqlCommand select = new SqlCommand(sql, connexion);
            SqlDataReader reader = select.ExecuteReader();

            while (reader.Read())
            {
                CMB_Fournisseur.Items.Add(reader.GetString(0));
            }

            reader.Dispose();
            select.Dispose();

            if (CMB_Fournisseur.Items.Count >= 1)
                CMB_Fournisseur.SelectedIndex = 0;
        }

        private void Ajouter()
        {
            String description = TB_Description.Text;
            String fournisseur = TrouverFournisseur();
            String stock = int.Parse((NUD_Stock.Value.ToString())).ToString();
            String minimum = int.Parse((NUD_Minimum.Value.ToString())).ToString();
            String maximum = int.Parse((NUD_Maximum.Value.ToString())).ToString();

            String sql = "INSERT INTO INVENTAIRE(DESCRIPTIONINVENTAIRE, IDFOURNISSEUR, QTESTOCK, QTEMINIMUM, QTEMAXIMUM) " +
                "VALUES('" + description + "'," + fournisseur + "," + stock + "," + minimum + "," + maximum + ")";
            SqlCommand insert = new SqlCommand(sql, connexion);

            if (insert.ExecuteNonQuery() >= 1)
                MessageBox.Show("Produit ajouté avec succès !");
            else
                MessageBox.Show("Erreur lors de l'ajout du produit");

            insert.Dispose();
            this.Close();

        }

        private void Modifier()
        {
            String description = TB_Description.Text;
            String fournisseur = TrouverFournisseur();
            String stock = int.Parse((NUD_Stock.Value.ToString())).ToString();
            String minimum = int.Parse((NUD_Minimum.Value.ToString())).ToString();
            String maximum = int.Parse((NUD_Maximum.Value.ToString())).ToString();

            String sql = "UPDATE INVENTAIRE SET " +
                "DESCRIPTIONINVENTAIRE='" + description + "', " +
                "IDFOURNISSEUR=" + fournisseur + ", " +
                "QTESTOCK=" + stock + ", " +
                "QTEMINIMUM=" + minimum + ", " +
                "QTEMAXIMUM=" + maximum + " WHERE IDINVENTAIRE=" + idInventaire;
            SqlCommand update = new SqlCommand(sql, connexion);

            if (update.ExecuteNonQuery() >= 1)
                MessageBox.Show("Produit mis à jour avec succès !");
            else
                MessageBox.Show("Erreur lors de la mise à jour du produit");

            update.Dispose();
            this.Close();
        }

        private String TrouverFournisseur()
        {
            String sql = "SELECT IDFOURNISSEUR FROM FOURNISSEUR WHERE NOMFOURNISSEUR='" + CMB_Fournisseur.SelectedItem.ToString() + "'";
            SqlCommand select = new SqlCommand(sql, connexion);
            SqlDataReader reader = select.ExecuteReader();
            reader.Read();
            String fournisseur = reader.GetInt16(0).ToString();
            reader.Close();

            select.Dispose();
            return fournisseur;
        }

        private void ChargerInventaire()
        {
            String sql = "SELECT DESCRIPTIONINVENTAIRE, NOMFOURNISSEUR, QTESTOCK, QTEMINIMUM, QTEMAXIMUM FROM INVENTAIRE I " +
                "INNER JOIN FOURNISSEUR F ON I.IDFOURNISSEUR = F.IDFOURNISSEUR " +
                "WHERE IDINVENTAIRE=" + idInventaire.ToString();
            SqlCommand select = new SqlCommand(sql, connexion);
            SqlDataReader reader = select.ExecuteReader();
            reader.Read();

            TB_Description.Text = reader.GetString(0);
            CMB_Fournisseur.SelectedIndex = CMB_Fournisseur.Items.IndexOf(reader.GetString(1));
            NUD_Stock.Value = reader.GetInt16(2);
            NUD_Minimum.Value = reader.GetInt16(3);
            NUD_Maximum.Value = reader.GetInt16(4);

            select.Dispose();
            reader.Close();
        }

        private void UpdateControls()
        {
            BTN_Accepter.Enabled = !String.IsNullOrEmpty(TB_Description.Text) &&
                CMB_Fournisseur.SelectedItem != null &&
                NUD_Minimum.Value < NUD_Maximum.Value;

        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTN_Accepter_Click(object sender, EventArgs e)
        {
            if (modification)
                Modifier();
            else
                Ajouter();
        }

        private void TB_Description_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void CMB_Fournisseur_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void NUD_Stock_ValueChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void NUD_Minimum_ValueChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void NUD_Maximum_ValueChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }
    }
}
