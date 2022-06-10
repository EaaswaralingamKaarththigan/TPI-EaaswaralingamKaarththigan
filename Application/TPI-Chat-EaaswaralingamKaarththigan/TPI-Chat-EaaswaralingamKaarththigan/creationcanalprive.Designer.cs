
namespace TPI_Chat_EaaswaralingamKaarththigan
{
    partial class creationcanalprive
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCreerNvCanal = new System.Windows.Forms.Button();
            this.Perso1Txt = new System.Windows.Forms.TextBox();
            this.Perso2Txt = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personne 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 100);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personne 2";
            // 
            // btnCreerNvCanal
            // 
            this.btnCreerNvCanal.Location = new System.Drawing.Point(124, 145);
            this.btnCreerNvCanal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCreerNvCanal.Name = "btnCreerNvCanal";
            this.btnCreerNvCanal.Size = new System.Drawing.Size(81, 44);
            this.btnCreerNvCanal.TabIndex = 12;
            this.btnCreerNvCanal.Text = "Créer un nouveau canal";
            this.btnCreerNvCanal.UseVisualStyleBackColor = true;
            this.btnCreerNvCanal.Click += new System.EventHandler(this.btnCreerNvCanal_Click);
            // 
            // Perso1Txt
            // 
            this.Perso1Txt.Location = new System.Drawing.Point(159, 54);
            this.Perso1Txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Perso1Txt.Name = "Perso1Txt";
            this.Perso1Txt.Size = new System.Drawing.Size(90, 20);
            this.Perso1Txt.TabIndex = 13;
            // 
            // Perso2Txt
            // 
            this.Perso2Txt.Location = new System.Drawing.Point(159, 98);
            this.Perso2Txt.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Perso2Txt.Name = "Perso2Txt";
            this.Perso2Txt.Size = new System.Drawing.Size(90, 20);
            this.Perso2Txt.TabIndex = 14;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(12, 207);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 15;
            // 
            // creationcanalprive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(348, 240);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Perso2Txt);
            this.Controls.Add(this.Perso1Txt);
            this.Controls.Add(this.btnCreerNvCanal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "creationcanalprive";
            this.Text = "creationcanalprive";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCreerNvCanal;
        private System.Windows.Forms.TextBox Perso1Txt;
        private System.Windows.Forms.TextBox Perso2Txt;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}