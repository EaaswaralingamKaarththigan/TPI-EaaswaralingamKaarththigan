
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(125, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personne 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(125, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Personne 2";
            // 
            // btnCreerNvCanal
            // 
            this.btnCreerNvCanal.Location = new System.Drawing.Point(166, 179);
            this.btnCreerNvCanal.Name = "btnCreerNvCanal";
            this.btnCreerNvCanal.Size = new System.Drawing.Size(108, 54);
            this.btnCreerNvCanal.TabIndex = 12;
            this.btnCreerNvCanal.Text = "Créer un nouveau canal";
            this.btnCreerNvCanal.UseVisualStyleBackColor = true;
            this.btnCreerNvCanal.Click += new System.EventHandler(this.btnCreerNvCanal_Click);
            // 
            // Perso1Txt
            // 
            this.Perso1Txt.Location = new System.Drawing.Point(212, 67);
            this.Perso1Txt.Name = "Perso1Txt";
            this.Perso1Txt.Size = new System.Drawing.Size(119, 22);
            this.Perso1Txt.TabIndex = 13;
            // 
            // Perso2Txt
            // 
            this.Perso2Txt.Location = new System.Drawing.Point(212, 120);
            this.Perso2Txt.Name = "Perso2Txt";
            this.Perso2Txt.Size = new System.Drawing.Size(119, 22);
            this.Perso2Txt.TabIndex = 14;
            // 
            // creationcanalprive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 296);
            this.Controls.Add(this.Perso2Txt);
            this.Controls.Add(this.Perso1Txt);
            this.Controls.Add(this.btnCreerNvCanal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
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
    }
}