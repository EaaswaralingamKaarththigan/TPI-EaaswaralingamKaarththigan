using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TPI_Chat_EaaswaralingamKaarththigan
{
    public partial class login : Form
    {
        SqlConnection con = new SqlConnection("Data Source=sc-c214-pc20\\instancekem;Initial Catalog=TPI;Persist Security Info=True;User ID=sa;Password=Kaarththigan2002"); // making connection 
        public login()
        {
            InitializeComponent();
        }

        // Si le bouton login est cliqué
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))                 // Si le champ username est vide
            {
                MessageBox.Show("Veuillez remplir les différents champs svp", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);                     // Affiche un message d'alerte comme quoi tous les champs ne sont pas remplis
                txtUsername.Focus();                                                                                                                        // Le curseur se place dans le champs à remplir "utilisateur"
                return;
            }

            else
            {
                
                con.Open();                                                                                                 // Ouverture de la connexion à la base de données
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tblcompteemploye WHERE Pseudonyme='" + txtUsername.Text + "' AND MotDePasse='" + txtPassword.Text + "'", con);                                                                        // Cette commande permet de compter le nombre de ligne dans la table "compteemploye" qui correspont au nom d'utilisateur et mot de passe qu'a entré l'utilisateur
                SqlCommand cmd = new SqlCommand("SELECT tblcompteemploye.Pseudonyme,tblcompteemploye.Id_Employe,tblcompteemploye.Id_TypeCompte FROM tblcompteemploye WHERE Pseudonyme='" + txtUsername.Text + "' AND MotDePasse='" + txtPassword.Text + "'", con);  // Cette commande permet de récupérer différentes information du compte avec lequel l'utilisateur s'est connecté
               
                    DataTable virtualTable = new DataTable();                                   // Création d'une table virtuelle
                    sda.Fill(virtualTable);                                                     // Remplissage de la table virtuelle avec la donnée récupérée dans la commande "sda"
                    if (virtualTable.Rows[0][0].ToString() == "1")                              // Cette commande vérifie si la première cellule du tableau correspond à "1", cette vérification permet de savoir si l'utilisateur a entré des données existantes dans le login
                    {
                    SqlDataReader reader = cmd.ExecuteReader();                                 // Cette commande permet de pouvoir lire les données récupérées dans la commande "cmd"
                    while (reader.Read())                                                       // Pendant que la fonction "Reader" est actif
                    {
                        int id = Convert.ToInt32(reader["Id_Employe"]);                         // Récupération de l'id de l'employé dans une variable nommé "id"
                        int idtypecompte = Convert.ToInt32(reader["Id_TypeCompte"]);            // Récupération de l'id du type de compte de l'employé dans une variable nommé "idtypecompte"
                        string user = Convert.ToString(reader["Pseudonyme"]);                   // Récupération du pseudonyme du compte de l'employé dans une variable nommée "user"
                        utilisateur loggedUser = new utilisateur(id, user, idtypecompte);       // Envoie de toutes les variables dont les données récupérées y sont stockées, dans la classe "utilisateur"
                        this.Hide();                                                            // Fermer la fenêtre du login

                        mainform form = new mainform();
                        form.SetUser(loggedUser);                                               // Envoi des données stockées dans la classe utilisateur
                        form.Show();                                                            // Afficher la page du canevas 
                    }
                    }
                    else
                        MessageBox.Show("Nom d'utilisateur ou/et mot de passe erroné(e)");
                con.Close();                                                                                            // Fermeture de la connexion à la base de données
                
                }
        }

        // Fonction si une touche spécifique est pressé dans le champ "utilisateur"
        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)                  // Si le bouton "enter" est pressé
            {
                txtPassword.Focus();                    // Le curseur se placera sera dans le textbox Password
                e.Handled = true;
            }
        }

        // Fonction si une touche spécifique est pressé dans le champ "mot de passe"
        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)                  // Si la touche "enter" est pressé
            {
                btnLogin.PerformClick();                // Le bouton login sera appuyé
            }
        }
    }
}
