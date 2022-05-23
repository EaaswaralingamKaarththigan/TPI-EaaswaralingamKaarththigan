using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TPI_Chat_EaaswaralingamKaarththigan
{
    public partial class mainform : Form
    {
        public utilisateur user;
        public mainform()
        {
            InitializeComponent();
            chatpublic screenschatpublic = new chatpublic(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };                        // Le programme affiche, dès le lancement, le chat public
            this.panel1.Controls.Add(screenschatpublic);
            screenschatpublic.Show();
        }

        public void discprivee()                                                                                                                    // Fonction pour afficher le chat privé
        {
            chatprivee screenschatprivee = new chatprivee(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(screenschatprivee);
            screenschatprivee.Show();
        }
        /// <summary>
        /// 
        /// </summary>
        public void discpubliques()                                                                                                                 // Fonction pour afficher le chat public
        {
            chatpublic screenschatpublic = new chatpublic(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(screenschatpublic);
            screenschatpublic.Show();
        }

        public void parametres()                                                                                                                    // Fonction pour afficher les paramètres
        {
            parametres screensparametres = new parametres(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(screensparametres);
            screensparametres.Show();
        }
        private void mainform_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        
        public void SetUser(utilisateur user)
        {
            this.user = user;
        }
    }
}
