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
    public partial class creationcanalprive : Form
    {
        SqlConnection con = new SqlConnection("Data Source=sc-c214-pc20\\instancekem;Initial Catalog=TPI;Persist Security Info=True;User ID=sa;Password=Kaarththigan2002"); // making connection 
        public mainform mainform;

        public creationcanalprive(mainform mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void btnCreerNvCanal_Click(object sender, EventArgs e)
        {
                if(mainform.user.id == Convert.ToInt32(Perso1Txt.Text) || mainform.user.id == Convert.ToInt32(Perso2Txt.Text) || Convert.ToInt32(Perso1Txt.Text) == Convert.ToInt32(Perso2Txt.Text))
            {
                MessageBox.Show("Vous ne pouvez pas ajouter plusieurs fois la même personne");
            }
            else { 
                    con.Open();
                    SqlCommand cmd = new SqlCommand("INSERT INTO tblcanalchatprive values(@Createur,@Personne1,@Personne2)", con);
                    cmd.Parameters.AddWithValue("@Createur", mainform.user.id);
                    cmd.Parameters.AddWithValue("@Personne1", Convert.ToInt32(Perso1Txt.Text.Trim()));
                    cmd.Parameters.AddWithValue("@Personne2", Convert.ToInt32(Perso2Txt.Text.Trim()));
                    cmd.ExecuteNonQuery();
                    con.Close();
            }
            
        }
    }
}
