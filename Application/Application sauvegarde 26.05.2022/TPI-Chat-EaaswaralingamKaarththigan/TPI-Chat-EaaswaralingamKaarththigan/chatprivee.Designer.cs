namespace TPI_Chat_EaaswaralingamKaarththigan
{
    partial class chatprivee
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.canalpriveGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDiscPubliques = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnParametres = new System.Windows.Forms.Button();
            this.btnNvCanal = new System.Windows.Forms.Button();
            this.test = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.canalpriveGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEnvoyer
            // 
            this.btnEnvoyer.BackColor = System.Drawing.Color.Snow;
            this.btnEnvoyer.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnEnvoyer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvoyer.Location = new System.Drawing.Point(709, 521);
            this.btnEnvoyer.Margin = new System.Windows.Forms.Padding(4);
            this.btnEnvoyer.Name = "btnEnvoyer";
            this.btnEnvoyer.Size = new System.Drawing.Size(112, 52);
            this.btnEnvoyer.TabIndex = 1;
            this.btnEnvoyer.Text = "Envoyer";
            this.btnEnvoyer.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(300, 489);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(913, 22);
            this.textBox1.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(300, 66);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(913, 414);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // canalpriveGridView
            // 
            this.canalpriveGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.canalpriveGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.test});
            this.canalpriveGridView.Location = new System.Drawing.Point(16, 66);
            this.canalpriveGridView.Margin = new System.Windows.Forms.Padding(4);
            this.canalpriveGridView.Name = "canalpriveGridView";
            this.canalpriveGridView.RowHeadersWidth = 51;
            this.canalpriveGridView.Size = new System.Drawing.Size(256, 445);
            this.canalpriveGridView.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Canaux privées";
            // 
            // btnDiscPubliques
            // 
            this.btnDiscPubliques.BackColor = System.Drawing.Color.White;
            this.btnDiscPubliques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDiscPubliques.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.btnDiscPubliques.Location = new System.Drawing.Point(16, 590);
            this.btnDiscPubliques.Margin = new System.Windows.Forms.Padding(4);
            this.btnDiscPubliques.Name = "btnDiscPubliques";
            this.btnDiscPubliques.Size = new System.Drawing.Size(395, 71);
            this.btnDiscPubliques.TabIndex = 6;
            this.btnDiscPubliques.Text = "Discussions publiques";
            this.btnDiscPubliques.UseVisualStyleBackColor = false;
            this.btnDiscPubliques.Click += new System.EventHandler(this.btnDiscPubliques_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.button2.Location = new System.Drawing.Point(419, 590);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(395, 71);
            this.button2.TabIndex = 7;
            this.button2.Text = "Discussions privées";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // btnParametres
            // 
            this.btnParametres.BackColor = System.Drawing.Color.White;
            this.btnParametres.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnParametres.Font = new System.Drawing.Font("Bahnschrift Condensed", 14F);
            this.btnParametres.Location = new System.Drawing.Point(821, 590);
            this.btnParametres.Margin = new System.Windows.Forms.Padding(4);
            this.btnParametres.Name = "btnParametres";
            this.btnParametres.Size = new System.Drawing.Size(395, 71);
            this.btnParametres.TabIndex = 8;
            this.btnParametres.Text = "Paramètres";
            this.btnParametres.UseVisualStyleBackColor = false;
            // 
            // btnNvCanal
            // 
            this.btnNvCanal.Location = new System.Drawing.Point(16, 521);
            this.btnNvCanal.Name = "btnNvCanal";
            this.btnNvCanal.Size = new System.Drawing.Size(256, 52);
            this.btnNvCanal.TabIndex = 9;
            this.btnNvCanal.Text = "Nouveau Canal";
            this.btnNvCanal.UseVisualStyleBackColor = true;
            // 
            // test
            // 
            this.test.HeaderText = "test";
            this.test.MinimumWidth = 6;
            this.test.Name = "test";
            this.test.Width = 125;
            // 
            // chatprivee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(1231, 676);
            this.ControlBox = false;
            this.Controls.Add(this.btnNvCanal);
            this.Controls.Add(this.btnParametres);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnDiscPubliques);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canalpriveGridView);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnEnvoyer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "chatprivee";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.canalpriveGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnEnvoyer;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.DataGridView canalpriveGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDiscPubliques;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnParametres;
        private System.Windows.Forms.Button btnNvCanal;
        private System.Windows.Forms.DataGridViewButtonColumn test;
    }
}

