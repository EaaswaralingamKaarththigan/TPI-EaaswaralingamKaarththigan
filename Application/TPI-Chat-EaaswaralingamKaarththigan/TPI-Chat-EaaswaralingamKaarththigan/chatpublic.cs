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
        public mainform mainform;
        public chatpublic(mainform mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnDiscPrivees_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform.discprivee();
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=SC-C214-PC20\\INSTANCEKEM;Initial Catalog=PreTPI;Persist Security Info=True;User ID=sa;Password=Kaarththigan2002");
            con.Open();

            /* using (SqlConnection client6 = SqlConnection.GetClient())
            { 
                client.SetParameter("sender", mUsername);
            client.SetParameter("message", textBox1.Text);
            client.ExecuteNonQuery("INSERT INTO program_messages ('sender','message','timesent') VALUES (@sender,@message,GETDATE())");
            }*/
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
