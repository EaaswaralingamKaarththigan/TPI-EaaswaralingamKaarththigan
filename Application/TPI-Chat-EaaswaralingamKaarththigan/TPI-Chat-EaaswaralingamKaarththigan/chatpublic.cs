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
        public int selectedId;
        public int selectEmployId;
        public int lastmessageid;
        public int idtypecompte;
        
        public chatpublic(mainform mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.selectedId = -1;
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            if(mainform.user.idtypecompte == 3)
            {
                btnGestionadmin.Visible = true;
                btnGestioncol.Visible = true;
            }
            else
            {
                btnGestionadmin.Visible = false;
                btnGestioncol.Visible = false;
            }
            listboxContextMenu = new ContextMenuStrip();
            listBox1.ContextMenuStrip = listboxContextMenu;
            

            
            con.Open();
            SqlCommand cmd = new SqlCommand("select tblmessagechatpublic.Id_MessageChatPublic,tblmessagechatpublic.Id_Employe,tblmessagechatpublic.ContenuMessage,tblmessagechatpublic.DateEnvoi,tblemploye.Nom,tblemploye.Prenom,tblemploye.Id_Employe,tblcompteemploye.Pseudonyme,tblcompteemploye.Id_TypeCompte from tblmessagechatpublic INNER JOIN tblemploye ON tblmessagechatpublic.Id_Employe = tblemploye.Id_Employe INNER JOIN tblcompteemploye on tblmessagechatpublic.Id_Employe = tblcompteemploye.Id_Employe", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read()) 
            {
                int Id = Convert.ToInt32(reader["Id_MessageChatPublic"]);
                string lastname = Convert.ToString(reader["Nom"]);
                string firstname = Convert.ToString(reader["Prenom"]);
                string username = Convert.ToString(reader["Pseudonyme"]);
                string text = string.Format("{0} {1} : {2}", reader["Nom"], reader["Prenom"], reader["ContenuMessage"]);
                int idemploye = Convert.ToInt32(reader["Id_Employe"]);
                int idtypecompte = Convert.ToInt32(reader["Id_TypeCompte"]);
                Message message = new Message(lastname, firstname, text, Id, username, idemploye, idtypecompte);
                listBox1.Items.Add(message);
            }
            listBox1.TopIndex = listBox1.Items.Count - 1;
            con.Close();

            
            InitTimer();
            
        }

        public void checknewmessage(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT COUNT(Id_MessageChatPublic) FROM tblmessagechatpublic", con);
            Int32 count = (Int32)cmd.ExecuteScalar();
            lastmessageid = count;
           
            con.Close();
            int NombreMsgLstbox = listBox1.Items.Count;
            //int test2 = Convert.ToInt32(test1);
            if (NombreMsgLstbox != lastmessageid)
            {
                NombreMsgLstbox = lastmessageid;
                afficherchat();
            }
        }

        public void afficherchat()
        {
            con.Open();
            listBox1.Items.Clear();

            SqlCommand cmd = new SqlCommand("select tblmessagechatpublic.Id_MessageChatPublic,tblmessagechatpublic.Id_Employe,tblmessagechatpublic.ContenuMessage,tblmessagechatpublic.DateEnvoi,tblemploye.Nom,tblemploye.Prenom,tblemploye.Id_Employe,tblcompteemploye.Pseudonyme,tblcompteemploye.Id_TypeCompte from tblmessagechatpublic INNER JOIN tblemploye ON tblmessagechatpublic.Id_Employe = tblemploye.Id_Employe INNER JOIN tblcompteemploye on tblmessagechatpublic.Id_Employe = tblcompteemploye.Id_Employe", con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Id = Convert.ToInt32(reader["Id_MessageChatPublic"]);
                string lastname = Convert.ToString(reader["Nom"]);
                string firstname = Convert.ToString(reader["Prenom"]);
                string username = Convert.ToString(reader["Pseudonyme"]);
                string text = string.Format("{0} {1} : {2}", reader["Nom"], reader["Prenom"], reader["ContenuMessage"]);
                int idemploye = Convert.ToInt32(reader["Id_Employe"]);
                int idtypecompte = Convert.ToInt32(reader["Id_TypeCompte"]);
                Message message = new Message(lastname, firstname, text, Id, username, idemploye, idtypecompte);
                listBox1.Items.Add(message);
            }
            listBox1.TopIndex = listBox1.Items.Count - 1;
            con.Close();

        }

        private void btnDiscPrivees_Click(object sender, EventArgs e)
        {
            this.Close();                                                   // La page du chat public va se fermer
            mainform.discprivee();                                          // La fonction qui permet d'afficher la page du chat privé est appelée
        }

        public void opencontextmenu()
        {
            if (mainform.user.idtypecompte == 2 || mainform.user.idtypecompte == 3)
            {
                if(mainform.user.id == selectEmployId)
                {
                    listboxContextMenu.Items.Clear();
                    listboxContextMenu.Items.Add("Modifier").Name = "Modifier";
                    listboxContextMenu.Items.Add("Supprimer").Name = "Supprimer";
                }
                else
                {
                    listboxContextMenu.Items.Clear();
                    listboxContextMenu.Items.Add("Supprimer").Name = "Supprimer";
                }
            }
            else if (selectEmployId == mainform.user.id)
            {

                listboxContextMenu.Items.Clear();
                listboxContextMenu.Items.Add("Modifier").Name = "Modifier";
                listboxContextMenu.Items.Add("Supprimer").Name = "Supprimer";
                
            }
            else
            {
                listboxContextMenu.Items.Clear();
            }
            listboxContextMenu.ItemClicked += new ToolStripItemClickedEventHandler(listboxContextMenu_ItemClicked);


        }

        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(checknewmessage);
            timer1.Interval = 200; // in miliseconds
            timer1.Start();
        }

        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            con.Open();
                SqlCommand cmd = new SqlCommand("insert into tblmessagechatpublic values(@Id_Employe,@DateEnvoi,@ContenuMessage)", con);
                int test = 1;
                cmd.Parameters.AddWithValue("@Id_Employe", mainform.user.id);
                //cmd.Parameters.AddWithValue("@Id_MessageChatPublic", );
                cmd.Parameters.AddWithValue("@ContenuMessage", txtMessage.Text);
                cmd.Parameters.AddWithValue("@DateEnvoi", DateTime.Now);
            
            cmd.ExecuteNonQuery();
            con.Close();
            con.Open();
            listBox1.Items.Clear();
            con.Close();
            afficherchat();
            

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
             
        
        private void listboxContextMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            con.Open();
            //throw new NotImplementedException();

            

            switch (e.ClickedItem.Name.ToString())
            {
                case "Modifier":

                break;

                case "Supprimer":
                    SqlCommand cmd = new SqlCommand("DELETE FROM tblmessagechatpublic WHERE Id_MessageChatPublic = @Id", con);
                    cmd.Parameters.AddWithValue("@Id", selectedId);
                    cmd.ExecuteNonQuery();
                    //afficherchat();
                    break;
            }
            con.Close();
        }








        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                
                //select the item under the mouse pointer
                listBox1.SelectedIndex = listBox1.IndexFromPoint(e.Location);
                if (listBox1.SelectedIndex != -1)
                {
                    //if(selectEmployId == )
                    listboxContextMenu.Show();
                }
            }
                        
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex != -1)
            {
            ListBox lb = (ListBox)sender;
            Message message = (Message)lb.Items[lb.SelectedIndex];
            selectedId = message.Id;
            selectEmployId = message.idemploye;
            idtypecompte = message.idtypecompte;
            opencontextmenu();
            }
        }

        private void btnParametres_Click(object sender, EventArgs e)
        {
            gestionadmin gestionadmin = new gestionadmin();
            gestionadmin.Show();
        }

        private void btnGestionadmin_Click(object sender, EventArgs e)
        {
            gestionadmincompte gestioncompteadm = new gestionadmincompte();
            gestioncompteadm.Show();
        }

        private void btnGestioncol_Click(object sender, EventArgs e)
        {
            gestionadmin gestionadmincol = new gestionadmin();
            gestionadmincol.Show();
        }
    }
}
