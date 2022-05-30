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
    public partial class gestionadmin : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=TPI;User ID=sa;Password=Pa$$w0rd"); // making connection 
        public int IdEmploy;
        public gestionadmin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            afficherliste();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            if (IdEmploy != 0)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("update tblemploye set Nom = @Nom, Prenom = @Prenom where Id_Employe = @IdEmploy", con);
                cmd.Parameters.AddWithValue("@Nom", txtNom.Text.Trim());
                cmd.Parameters.AddWithValue("@Prenom", txtPrenom.Text.Trim());
                cmd.Parameters.AddWithValue("@IdEmploy", IdEmploy);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                afficherliste();
            }
            else
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into tblemploye values(@Nom,@Prenom)", con);
                cmd.Parameters.AddWithValue("@Nom", txtNom.Text.Trim());
                cmd.Parameters.AddWithValue("@Prenom", txtPrenom.Text.Trim());
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                afficherliste();
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {

        }

        void afficherliste()
        {
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select Id_Employe,Nom,Prenom from tblemploye", con);
            DataTable employeTable = new DataTable();
            cmd.Fill(employeTable);
            employeGridView.DataSource = employeTable;
            con.Close();
            employeGridView.Columns[0].Visible = false;
        }

        void clear()
        {
            txtNom.Text = txtPrenom.Text = "";
            IdEmploy = 0;
            btnAjouter.Text = "Ajouter";
            btnAjouter.BackColor = Color.White;
        }

        private void employeGridView_DoubleClick(object sender, EventArgs e)
        {
            if(employeGridView.CurrentCell.RowIndex != -1)
            {
                txtNom.Text = employeGridView.CurrentRow.Cells[1].Value.ToString();
                txtPrenom.Text = employeGridView.CurrentRow.Cells[2].Value.ToString();
                IdEmploy = Convert.ToInt32(employeGridView.CurrentRow.Cells[0].Value.ToString());
                btnAjouter.Text = "Modifier";
                btnAjouter.BackColor = Color.Yellow;
            }
        }
    }
}
