namespace TPI_Chat_EaaswaralingamKaarththigan
{
    partial class chatpublic
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEnvoyer = new System.Windows.Forms.Button();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiscPubliques = new System.Windows.Forms.Button();
            this.btnDiscPrivees = new System.Windows.Forms.Button();
            this.btnParametres = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.BackColor = System.Drawing.Color.Snow;
            this.btnEnvoyer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEnvoyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvoyer.Location = new System.Drawing.Point(532, 423);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(84, 42);
            this.btnEnvoyer.TabIndex = 1;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = false;
            this.btnEnvoyer.Click += new System.EventHandler(this.btnEnvoyer_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(225, 397);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(686, 20);
            this.txtMessage.TabIndex = 2;
            this.txtMessage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMessage_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 54);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(192, 411);
            this.dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "Canaux publics";
            // 
            // btnDiscPubliques
            // 
            this.btnDiscPubliques.BackColor = System.Drawing.Color.White;
            this.btnDiscPubliques.Enabled = false;
            this.btnDiscPubliques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscPubliques.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.btnDiscPubliques.Location = new System.Drawing.Point(12, 479);
            this.btnDiscPubliques.Name = "btnDiscPubliques";
            this.btnDiscPubliques.Size = new System.Drawing.Size(296, 58);
            this.btnDiscPubliques.TabIndex = 6;
            this.btnDiscPubliques.Text = "Discussions publiques";
            this.btnDiscPubliques.UseVisualStyleBackColor = false;
            // 
            // btnDiscPrivees
            // 
            this.btnDiscPrivees.BackColor = System.Drawing.Color.White;
            this.btnDiscPrivees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscPrivees.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.btnDiscPrivees.Location = new System.Drawing.Point(314, 479);
            this.btnDiscPrivees.Name = "btnDiscPrivees";
            this.btnDiscPrivees.Size = new System.Drawing.Size(296, 58);
            this.btnDiscPrivees.TabIndex = 7;
            this.btnDiscPrivees.Text = "Discussions privées";
            this.btnDiscPrivees.UseVisualStyleBackColor = false;
            this.btnDiscPrivees.Click += new System.EventHandler(this.btnDiscPrivees_Click);
            // 
            // btnParametres
            // 
            this.btnParametres.BackColor = System.Drawing.Color.White;
            this.btnParametres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametres.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.btnParametres.Location = new System.Drawing.Point(616, 479);
            this.btnParametres.Name = "btnParametres";
            this.btnParametres.Size = new System.Drawing.Size(296, 58);
            this.btnParametres.TabIndex = 8;
            this.btnParametres.Text = "Paramètres";
            this.btnParametres.UseVisualStyleBackColor = false;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(225, 55);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(686, 329);
            this.listBox1.TabIndex = 9;
            this.listBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox1_MouseDown);
            // 
            // chatpublic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(923, 549);
            this.ControlBox = false;
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnParametres);
            this.Controls.Add(this.btnDiscPrivees);
            this.Controls.Add(this.btnDiscPubliques);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.btnEnvoyer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "chatpublic";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDiscPubliques;
        private System.Windows.Forms.Button btnDiscPrivees;
        private System.Windows.Forms.Button btnParametres;
        private System.Windows.Forms.ListBox listBox1;
    }
}

