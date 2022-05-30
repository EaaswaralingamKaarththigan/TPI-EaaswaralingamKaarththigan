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
    public partial class chatprivee : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=TPI;User ID=sa;Password=Pa$$w0rd"); // making connection 
        public mainform mainform;
        public chatprivee(mainform mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            affichercanal();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        void affichercanal()
        {
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select Id_CanalChatPrive from tblcanalchatprive WHERE Createur = @UtilisateurCo OR Personne2 = @UtilisateurCo OR Personne3 = @UtilisateurCo OR Personne4 = @UtilisateurCo", con);
            cmd.SelectCommand.Parameters.AddWithValue("@UtilisateurCo", mainform.user.id);
            DataTable employeTable = new DataTable();
            cmd.Fill(employeTable);
            canalpriveGridView.DataSource = employeTable;
            con.Close();
            canalpriveGridView.Columns[0].Visible = false;
        }

        private void btnDiscPubliques_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform.discpubliques();
        }
    }
}
