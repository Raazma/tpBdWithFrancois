using CrystalDecisions.CrystalReports.Engine;
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

    public partial class Form1 : Form
    {
        SqlConnection connexion;
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ConnecterBD();
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
        private void Btn_Gestion_F_Click(object sender, EventArgs e)
        {
            Form_Fournisseur form = new Form_Fournisseur(connexion);

            if (form.ShowDialog() == DialogResult.OK)
            {


            }
        }

        private void Btn_Gestion_P_Click(object sender, EventArgs e)
        {
            RechercheInventaire form = new RechercheInventaire(connexion);

            if (form.ShowDialog() == DialogResult.OK)
            {


            }
        }

        private void Btn_Rapport_fournisseur_Click(object sender, EventArgs e)
        {

            AfficherRapport("SELECT * FROM FOURNISSEUR", "..\\..\\ListeFournisseurs.rpt");

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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FermerBD();
        }

        private void AfficherRapport(String query, String path)
        {

            DataSet data = new DataSet("dataTable");
            SqlDataAdapter adp = new SqlDataAdapter();
            ReportDocument dcm = new ReportDocument();


            adp.SelectCommand = new SqlCommand(query, connexion);
            adp.Fill(data, "dataTable");
            MessageBox.Show(data.Tables["dataTable"].Rows.Count.ToString());
            dcm.Load(path);

            Form_Rapport form = new Form_Rapport(dcm);

            data.Clear();
            adp.Dispose();

            form.ShowDialog();
        }

        private void Btn_Publipostage_Click(object sender, EventArgs e)
        {
            AfficherRapport("SELECT * FROM FOURNISSEUR", "..\\..\\FournisseurPublipostage.rpt");
        }

        private void Btn_Rapport_Inventaire_Click(object sender, EventArgs e)
        {
            String query = "SELECT IDINVENTAIRE, DESCRIPTIONINVENTAIRE, NOMFOURNISSEUR , QTESTOCK , QTEMINIMUM , QTEMAXIMUM FROM INVENTAIRE I "
                   + "INNER JOIN FOURNISSEUR F ON I.IDFOURNISSEUR = F.IDFOURNISSEUR WHERE QTESTOCK > 0";

            AfficherRapport(query, "..\\..\\Inventaire.rpt");
        }

        private void Btn_RapportCommande_Click(object sender, EventArgs e)
        {
            String commande = "SELECT IDINVENTAIRE, DESCRIPTIONINVENTAIRE , NOMFOURNISSEUR " +
                "FROM INVENTAIRE I INNER JOIN FOURNISSEUR F ON I.IDFOURNISSEUR = F.IDFOURNISSEUR " +
                "WHERE QTESTOCK < QTEMINIMUM";

            AfficherRapport(commande,"..\\..\\Inventaire.rpt");
        }

    }


}
