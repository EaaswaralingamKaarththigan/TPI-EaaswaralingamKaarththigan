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
        private Timer timer1;
        private ContextMenuStrip listboxContextMenu;
        SqlConnection con = new SqlConnection("Data Source=sc-c214-pc20\\instancekem;Initial Catalog=TPI;Persist Security Info=True;User ID=sa;Password=Kaarththigan2002");
        public mainform mainform;
        public chatpublic(mainform mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listboxContextMenu = new ContextMenuStrip();
            listboxContextMenu.Opening += new CancelEventHandler(listboxContextMenu_Opening);
            listBox1.ContextMenuStrip = listboxContextMenu;
            con.Open();
            SqlCommand cmd = new SqlCommand("select tblchatpublic.Id_Employe,tblchatpublic.Message,tblchatpublic.Date_envoi_message,tblemployes.Nom,tblemployes.Prenom from tblchatpublic INNER JOIN tblemployes ON tblchatpublic.Id_Employe = tblemployes.Id_Employe", con);
            SqlDataReader reader = cmd.ExecuteReader();
            MessageBox.Show("test");
            while (reader.Read()) 
            {
                string lastname = Convert.ToString(reader["Nom"]);
                string firstname = Convert.ToString(reader["Prenom"]);
                string text = Convert.ToString(reader["Message"]);
                MessageBox.Show(text);
                Message message = new Message(lastname,firstname,text);
            listBox1.Items.Add(message);
            }
            listBox1.TopIndex = listBox1.Items.Count - 1;
            
            con.Close();

            //InitTimer();

        }

        private void btnDiscPrivees_Click(object sender, EventArgs e)
        {
            this.Close();                                                   // La page du chat public va se fermer
            mainform.discprivee();                                          // La fonction qui permet d'afficher la page du chat privé est appelée
        }

        public void refreshchat(object sender, EventArgs e)
        {
            
            listBox1.Items.Clear();
            con.Open();
            SqlCommand cmd = new SqlCommand("select tblchatpublic.Id_Employe,tblchatpublic.Message,tblchatpublic.Date_envoi_message,tblemployes.Nom,tblemployes.Prenom from tblchatpublic INNER JOIN tblemployes ON tblchatpublic.Id_Employe = tblemployes.Id_Employe", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(string.Format("{0} {1} : {2}", reader["Nom"], reader["Prenom"], reader["Message"]));
            }
            listBox1.TopIndex = listBox1.Items.Count - 1;
            con.Close();
        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(refreshchat);
            timer1.Interval = 2000; // in miliseconds
            timer1.Start();
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblchatpublic values(@Id_Employe,@Nom_ChatPublic,@Message,@Date_envoi_message)", con);

            cmd.Parameters.AddWithValue("@Id_Employe", 2);
            cmd.Parameters.AddWithValue("@Nom_ChatPublic", "Test1");
            cmd.Parameters.AddWithValue("@Message", txtMessage.Text);
            cmd.Parameters.AddWithValue("@Date_envoi_message", DateTime.Now);
            cmd.ExecuteNonQuery();

            listBox1.Items.Clear();
            SqlCommand cmdd = new SqlCommand("select tblchatpublic.Id_Employe,tblchatpublic.Message,tblchatpublic.Date_envoi_message,tblemployes.Nom,tblemployes.Prenom from tblchatpublic INNER JOIN tblemployes ON tblchatpublic.Id_Employe = tblemployes.Id_Employe", con);
            SqlDataReader reader = cmdd.ExecuteReader();
            while (reader.Read())
            {
                listBox1.Items.Add(string.Format("{0} {1} : {2}", reader["Nom"], reader["Prenom"], reader["Message"]));
            }
            listBox1.TopIndex = listBox1.Items.Count - 1;
            con.Close();

            txtMessage.Text = string.Empty;

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtMessage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)                  // Si le bouton "enter" est pressé
            {
                btnEnvoyer.PerformClick();                // Le bouton envoyer sera appuyé
            }
        }
              
        private void listboxContextMenu_Opening(object sender, CancelEventArgs e)
        {
            //clear the menu and add custom items
            listboxContextMenu.Items.Clear();
            listboxContextMenu.Items.Add(string.Format("Edit - {0}", listBox1.SelectedItem.ToString()));
        }

        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                //select the item under the mouse pointer
                listBox1.SelectedIndex = listBox1.IndexFromPoint(e.Location);
                if (listBox1.SelectedIndex != -1)
                {
                    listboxContextMenu.Show();
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(listBox1.SelectedItem.ToString());
        }
    }
}
