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
    public partial class gestionadmincompte : Form
    {
        SqlConnection con = new SqlConnection("Data Source=sc-c214-pc20\\instancekem;Initial Catalog=TPI;Persist Security Info=True;User ID=sa;Password=Kaarththigan2002"); // making connection 
        public int IdEmploy;
        public gestionadmincompte()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            afficherliste();
            btnSupprimer.Enabled = false;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if(txtIdemploye.Text.Trim() == "" || txtTypeCompte.Text.Trim() == "" || txtPseudo.Text.Trim() == "" || txtMotdepasse.Text.Trim() == "")
            {
                MessageBox.Show("Remplissez tous les champs !!");
            }
            else if (IdEmploy != 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update tblcompteemploye set Id_Employe = @IdEmploye, Id_TypeCompte = @TypeCompte, Pseudonyme = @Pseudonyme, MotDePasse = @MotDePasse where Id_Employe = @IdEmploy", con);
                cmd.Parameters.AddWithValue("@IdEmploye", Convert.ToInt32(txtIdemploye.Text.Trim()));
                cmd.Parameters.AddWithValue("@TypeCompte", Convert.ToInt32(txtTypeCompte.Text.Trim()));
                cmd.Parameters.AddWithValue("@Pseudonyme", txtPseudo.Text.Trim());
                cmd.Parameters.AddWithValue("@MotDePasse", txtMotdepasse.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                afficherliste();
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tblcompteemploye values(@Id_Employe,@Id_TypeCompte,@Pseudonyme,@MotDePasse)", con);
                cmd.Parameters.AddWithValue("@Id_Employe", Convert.ToInt32(txtIdemploye.Text.Trim()));
                cmd.Parameters.AddWithValue("@Id_TypeCompte", Convert.ToInt32(txtTypeCompte.Text.Trim()));
                cmd.Parameters.AddWithValue("@Pseudonyme", txtPseudo.Text.Trim());
                cmd.Parameters.AddWithValue("@MotDePasse", txtMotdepasse.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                afficherliste();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (IdEmploy != 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("delete from tblcompteemploye where Id_Employe = @IdEmploy", con);
                cmd.Parameters.AddWithValue("@IdEmploy", txtIdemploye.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                afficherliste();
                btnSupprimer.Enabled = false;
            }
        }

        void afficherliste()
        {
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select Id_Compte,Id_Employe,Id_TypeCompte,Pseudonyme,MotDePasse from tblcompteemploye", con);
            DataTable employeTable = new DataTable();
            cmd.Fill(employeTable);
            employeGridView.DataSource = employeTable;
            con.Close();
            employeGridView.Columns[0].Visible = false;
        }

        void clear()
        {
            txtIdemploye.Text = txtTypeCompte.Text = txtPseudo.Text = txtMotdepasse.Text = "";
            IdEmploy = 0;
            btnAjouter.Text = "Ajouter";
            btnAjouter.BackColor = Color.White;
            btnSupprimer.Enabled = false;
        }

        private void employeGridView_DoubleClick(object sender, EventArgs e)
        {
            if (employeGridView.CurrentCell.RowIndex != -1)
            {
                txtIdemploye.Text = employeGridView.CurrentRow.Cells[1].Value.ToString();
                txtTypeCompte.Text = employeGridView.CurrentRow.Cells[2].Value.ToString();
                txtPseudo.Text = employeGridView.CurrentRow.Cells[3].Value.ToString();
                txtMotdepasse.Text = employeGridView.CurrentRow.Cells[4].Value.ToString();
                IdEmploy = Convert.ToInt32(employeGridView.CurrentRow.Cells[0].Value.ToString());
                btnAjouter.Text = "Modifier";
                btnAjouter.BackColor = Color.Yellow;
                btnSupprimer.Enabled = true;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            clear();
        }
    }
}
