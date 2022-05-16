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
        public mainform()
        {
            InitializeComponent();
            chatpublic screenschatpublic = new chatpublic(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(screenschatpublic);
            screenschatpublic.Show();
        }

        public void discprivee()
        {
            chatprivee screenschatprivee = new chatprivee(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(screenschatprivee);
            screenschatprivee.Show();
        }

        public void discpubliques()
        {
            chatpublic screenschatpublic = new chatpublic(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(screenschatpublic);
            screenschatpublic.Show();
        }

        public void parametres()
        {
            parametres screensparametres = new parametres(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            this.panel1.Controls.Add(screensparametres);
            screensparametres.Show();
        }
        private void mainform_Load(object sender, EventArgs e)
        {

        }
    }
}
