﻿using System;
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
    public partial class chatprivee : Form
    {
        public mainform mainform;
        public chatprivee(mainform mainform)
        {
            InitializeComponent();
            this.mainform = mainform;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDiscPubliques_Click(object sender, EventArgs e)
        {
            this.Close();
            mainform.discpubliques();
        }
    }
}
