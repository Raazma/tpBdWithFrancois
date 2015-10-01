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
    public partial class Ajout_Modif_Fournisseur_Form : Form
    {
          SqlConnection connexion;
        bool IsModificaton = false;
        String id;
        public Ajout_Modif_Fournisseur_Form(SqlConnection connexion)
        {
            InitializeComponent();
            this.connexion = connexion;
        }
        public Ajout_Modif_Fournisseur_Form(SqlConnection connexion,String id)
        {
            InitializeComponent();
            this.id = id;
            Btn_Ajouter.Text = "Modifier";
            this.connexion = connexion;
            IsModificaton = true;
           getFournisseurData(id);
        }

        private void Ajout_Modif_Fournisseur_Form_Load(object sender, EventArgs e)
        {
           
        }

        private void Btn_Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            if (!IsModificaton )
            {
                if (IsValidValue())
                {
                    Ajouter(Tb_Nom.Text, Tb_Adresse.Text, Tb_Ville.Text, Tb_Code_postal.Text, Tb_tel.Text, Tb_Solde.Text, Tb_Courriel.Text);
                    ClearTextBox();
                }
            }
            else
            {
                if (IsValidValue())
                {
                    UpdateFournisseur(id);
                    this.Close();
                }
            }
        }

        private void Ajouter(String name, String adresse, String ville, String codep,String tel, String solde, String courriel)
        {


            String sqlInsert = "INSERT INTO FOURNISSEUR(NOMFOURNISSEUR, ADFOURNISSEUR, VILLEFOURNISSEUR, CPFOURNISSEUR, TELFOURNISSEUR, SOLDEFOURNISSEUR, COURRIELFOURNISSEUR) " +
                   "VALUES('" + name +"', ' " +adresse +"', ' "+ ville+"','"+codep +"', ' "+tel+"'," + solde +", ' " +courriel+"')";

            SqlCommand insert = new SqlCommand(sqlInsert);
            insert.Connection = connexion;

            if (insert.ExecuteNonQuery() >= 1)
                MessageBox.Show("Ajout du fournisseur réussie");
            else
                MessageBox.Show("Erreur Lors de l'ajout");

            insert.Dispose();
        
        }
       
        private void getFournisseurData(String id)
        {
            String researchCommand = "SELECT * FROM FOURNISSEUR WHERE IDFOURNISSEUR=  " + id;
            SqlCommand research = new SqlCommand(researchCommand, connexion);
            SqlDataReader reader;
          
            try
            {
                reader = research.ExecuteReader();

                   if (reader.HasRows)
                   {
                       reader.Read();                     
                      Tb_Nom.Text = reader.GetString(1);
                      Tb_Adresse.Text =  reader.GetString(2);
                      Tb_Ville.Text = reader.GetString(3);
                      Tb_Code_postal.Text = reader.GetString(4);
                      Tb_tel.Text = reader.GetString(5);
                      Tb_Solde.Text = reader.GetInt32(6).ToString();
                      Tb_Courriel.Text = reader.GetString(7);                    
                  }
                   

                reader.Dispose();
                research.Dispose();
            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
            }

            
      
        }
        private void UpdateFournisseur(String id)
        {
             
            String updateQuery = "UPDATE FOURNISSEUR SET NOMFOURNISSEUR = '" + Tb_Nom.Text +"'," +
                                 " VILLEFOURNISSEUR ='" + Tb_Ville.Text + "'," +
                                 " CPFOURNISSEUR = '" + Tb_Code_postal.Text +"'," +
                                 " TELFOURNISSEUR = '" + Tb_tel.Text + "'," +
                                 " SOLDEFOURNISSEUR =" + Tb_Solde.Text +"," +
                                 " COURRIELFOURNISSEUR = '" + Tb_Courriel.Text + "' " +
                                 " WHERE IDFOURNISSEUR =" + id;
            MessageBox.Show(updateQuery);
            SqlCommand update = new SqlCommand(updateQuery,connexion);
            try
            {
                update.ExecuteNonQuery();
                update.Dispose();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
            }

        }
        private void ClearTextBox()
        {
            Tb_Adresse.Text = "";
            Tb_Code_postal.Text = "";
            Tb_Courriel.Text = "";
            Tb_Solde.Text = "";
            Tb_tel.Text = "";
            Tb_Ville.Text = "";          
            Tb_Nom.Text = "";              
        }
        private bool IsValidValue()
        {
            bool isvalid = false;
            try
            {
                if (!String.IsNullOrEmpty(Tb_Adresse.Text)
                    && !String.IsNullOrEmpty(Tb_Code_postal.Text)
                    && !String.IsNullOrEmpty(Tb_Solde.Text)
                    && !String.IsNullOrEmpty(Tb_tel.Text)
                    && !String.IsNullOrEmpty(Tb_Ville.Text)
                    && !String.IsNullOrEmpty(Tb_Nom.Text)
                    && !String.IsNullOrEmpty(Tb_Courriel.Text)
                    && Int32.Parse(Tb_Solde.Text) >= 0)
                {

                    isvalid = true;
                }
                else
                {
                    MessageBox.Show("Valeur Invalide");
                }
            }
            catch (Exception e)
            {

                MessageBox.Show("Erreur de solde");
                isvalid = false;
            }


            return isvalid;           
        
        
        
        
        }
    
    }
}
