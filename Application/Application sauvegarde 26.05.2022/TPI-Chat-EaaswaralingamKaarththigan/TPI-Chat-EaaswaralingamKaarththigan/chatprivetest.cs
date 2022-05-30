using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_Chat_EaaswaralingamKaarththigan
{
    public partial class chatprivetest : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=TPI;User ID=sa;Password=Pa$$w0rd");
        private Timer timer1;                                                           // Servira dans la fonction "InitTimer"                                     
        private ContextMenuStrip listboxContextMenu;
        public mainform mainform;
        public int selectedId;
        public int selectEmployId;
        public int lastmessageid;
        public int idtypecompte;
        public int idcanal = 0;

        public chatprivetest(mainform mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
            this.selectedId = -1;
        }


        // Au chargement de la fenêtre
        private void Form1_Load(object sender, EventArgs e)
        {
            listboxContextMenu = new ContextMenuStrip();
            listBox1.ContextMenuStrip = listboxContextMenu;

            affichercanal();

            if (idcanal == 0)
            {
                listBox1.Enabled = false;
                btnEnvoyer.Enabled = false;
                txtMessage.Enabled = false;
            }
            else
            { 
            
            }

        }

        // Fonction qui va permettre d'afficher les messages du canal privée en double cliquant sur la cellule du gridview
        private void canalpriveGridView_DoubleClick(object sender, EventArgs e)
        {
            if (canalpriveGridView.CurrentCell.RowIndex != -1)
            {
                string idcanalgridview = canalpriveGridView.CurrentRow.Cells[0].Value.ToString();
                idcanal = Convert.ToInt32(idcanalgridview);

                afficherchat();
                txtMessage.Enabled = true;
                listBox1.Enabled = true;
                btnEnvoyer.Enabled = true;
                InitTimer();
            }
        }

        // Fonction permettant d'afficher les différents canaux privés existant
        void affichercanal()
        {
            con.Open();
            SqlDataAdapter cmd = new SqlDataAdapter("select Id_CanalChatPrive from tblcanalchatprive WHERE Createur = @UtilisateurCo OR Personne2 = @UtilisateurCo OR Personne3 = @UtilisateurCo", con);
            cmd.SelectCommand.Parameters.AddWithValue("@UtilisateurCo", mainform.user.id);
            DataTable employeTable = new DataTable();
            cmd.Fill(employeTable);
            canalpriveGridView.DataSource = employeTable;
            con.Close();
            canalpriveGridView.Columns[0].Visible = false;
        }

        // Fonction qui va checker la table des messages et raffraîchir la listbox s'il y a un changement dans cette table.
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

        // Fonction permettant d'afficher le chat dans le listbox
        public void afficherchat()
        {

            con.Open();
            listBox1.Items.Clear();
            SqlCommand cmd = new SqlCommand("select tblmessagechatprive.Id_MessageChatPrive,tblmessagechatprive.Id_Employe,tblmessagechatprive.ContenuMessage,tblmessagechatprive.DateEnvoi,tblemploye.Nom,tblemploye.Prenom,tblemploye.Id_Employe,tblcompteemploye.Pseudonyme,tblcompteemploye.Id_TypeCompte from tblmessagechatprive INNER JOIN tblemploye ON tblmessagechatprive.Id_Employe = tblemploye.Id_Employe INNER JOIN tblcompteemploye on tblmessagechatprive.Id_Employe = tblcompteemploye.Id_Employe where Id_CanalChatPrive = @idcanalchatprive", con);
            cmd.Parameters.AddWithValue("@idcanalchatprive", idcanal);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int Id = Convert.ToInt32(reader["Id_MessageChatPrive"]);
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

        // Fonction permettant de créer un menu lorsque l'on fait clic droit sur l'un des messages affichés. C'est grâce à cela que l'on peut supprimer ou modifier un message.
        public void opencontextmenu()
        {
            if (mainform.user.idtypecompte == 2 || mainform.user.idtypecompte == 3)
            {
                if (mainform.user.id == selectEmployId)
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

        // Fonction permettant d'initier un timer qui va checker tout les x temps si la table des messages a changé
        public void InitTimer()
        {
            timer1 = new Timer();
            timer1.Tick += new EventHandler(checknewmessage);
            timer1.Interval = 200; // in miliseconds
            timer1.Start();
        }

        // Fonction permettant d'envoyer des messages
        private void btnEnvoyer_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblmessagechatprive values(@Id_CanalChatPrive,@Id_Employe,@DateEnvoi,@ContenuMessage)", con);
            int test = 1;
            cmd.Parameters.AddWithValue("@Id_CanalChatPrive", idcanal);
            cmd.Parameters.AddWithValue("@Id_Employe", mainform.user.id);
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

        // Fonction permettant d'utiliser la touche "enter" en tant que bouton "envoyer" du message
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
                    SqlCommand cmd = new SqlCommand("DELETE FROM tblmessagechatprive WHERE Id_MessageChatPrive = @Id", con);
                    cmd.Parameters.AddWithValue("@Id", selectedId);
                    cmd.ExecuteNonQuery();
                    //afficherchat();
                    break;
            }
            con.Close();
        }

        //Fonction qui récupère ce qui se trouve en dessous de la souris
        private void listBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                //Selectionner l'item qui se trouve en dessous de la souris
                listBox1.SelectedIndex = listBox1.IndexFromPoint(e.Location);
                if (listBox1.SelectedIndex != -1)
                {
                    listboxContextMenu.Show();
                }
            }

        }

        // Fonction qui permet de récupérer l'item choisi dans la listbox
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                ListBox lb = (ListBox)sender;
                Message message = (Message)lb.Items[lb.SelectedIndex];
                selectedId = message.Id;
                selectEmployId = message.idemploye;
                idtypecompte = message.idtypecompte;
                opencontextmenu();
            }
        }

        

        private void btnNvCanal_Click(object sender, EventArgs e)
        {
            creationcanalprive canalprive = new creationcanalprive(mainform);
            canalprive.Show();
        }
    }
}
