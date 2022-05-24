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
        public login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))                 // Si le champ username est vide
            {
                MessageBox.Show("Veuillez remplir les différents champs svp", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsername.Focus();
                return;
            }

            else
            {
                SqlConnection con = new SqlConnection(@"Data Source=sc-c214-pc20\instancekem;Initial Catalog=TPI;Persist Security Info=True;User ID=sa;Password=Kaarththigan2002"); // making connection 
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT COUNT(*) FROM tblcompte WHERE Pseudonyme='" + txtUsername.Text + "' AND MotDePasse='" + txtPassword.Text + "'", con);
                SqlCommand cmd = new SqlCommand("SELECT tblcompte.Pseudonyme,tblcompte.Id_Employe,tblcompte.Id_TypeCompte FROM tblcompte WHERE Pseudonyme='" + txtUsername.Text + "' AND MotDePasse='" + txtPassword.Text + "'", con);
               
                    DataTable virtualTable = new DataTable();
                    sda.Fill(virtualTable);
                    if (virtualTable.Rows[0][0].ToString() == "1")
                    {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        int id = Convert.ToInt32(reader["Id_Employe"]);
                        int idtypecompte = Convert.ToInt32(reader["Id_TypeCompte"]);
                        string user = Convert.ToString(reader["Pseudonyme"]);
                        utilisateur loggedUser = new utilisateur(id, user, idtypecompte);
                        this.Hide();

                        mainform form = new mainform();
                        form.SetUser(loggedUser);
                        form.Show();
                    }
                    }
                    else
                        MessageBox.Show("Nom d'utilisateur ou/et mot de passe erroné(e)");
                con.Close();
                
                }
        }

        private void txtUsername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)                  // Si le bouton "enter" est pressé
            {
                txtPassword.Focus();                    // Le placement sera dans le textbox Password
                e.Handled = true;
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)                  // Si la touche "enter" est pressé
            {
                btnLogin.PerformClick();                // Le bouton login sera appuyé
            }
        }
    }
}
