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
    public partial class chatpublic : Form
    {
        SqlConnection con = new SqlConnection("Data Source=sc-c214-pc20\\instancekem;Initial Catalog=TPI;Persist Security Info=True;User ID=sa;Password=Kaarththigan2002");
        public mainform mainform;
        public chatpublic(mainform mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select @Id_Employe,@Nom_ChatPublic,@Message,@Date_envoi_message tblchatpublic from tblchatpublic", con);
            cmd.ExecuteNonQuery();
            listBox1.Items.Add("@Id_Employe \n @Message \n @Date_envoi_message");

            con.Close();
        }

        private void btnDiscPrivees_Click(object sender, EventArgs e)
        {
            this.Close();                                                   // La page du chat public va se fermer
            mainform.discprivee();                                          // La fonction qui permet d'afficher la page du chat privé est appelée
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblchatpublic values(@Id_Employe,@Nom_ChatPublic,@Message,@Date_envoi_message)", con);

            cmd.Parameters.AddWithValue("@Id_Employe", 1);
            cmd.Parameters.AddWithValue("@Nom_ChatPublic", "Test1");
            cmd.Parameters.AddWithValue("@Message", txtMessage.Text);
            cmd.Parameters.AddWithValue("@Date_envoi_message", DateTime.Now);
            cmd.ExecuteNonQuery();

            

            

            con.Close();


        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
