namespace Canlılar_304
{
    partial class YeniEkleFrom
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
            this.txtSayisi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.pbFotograf = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbUlke = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.txtHabitat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotograf)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSayisi
            // 
            this.txtSayisi.Location = new System.Drawing.Point(81, 95);
            this.txtSayisi.Name = "txtSayisi";
            this.txtSayisi.Size = new System.Drawing.Size(153, 20);
            this.txtSayisi.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fotograf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Canlı sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Konum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Ülke";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(81, 14);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(153, 20);
            this.txtAd.TabIndex = 15;
            // 
            // pbFotograf
            // 
            this.pbFotograf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbFotograf.Location = new System.Drawing.Point(81, 181);
            this.pbFotograf.Name = "pbFotograf";
            this.pbFotograf.Size = new System.Drawing.Size(153, 143);
            this.pbFotograf.TabIndex = 14;
            this.pbFotograf.TabStop = false;
            this.pbFotograf.Click += new System.EventHandler(this.pbFotograf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Canlı adı";
            // 
            // cmbUlke
            // 
            this.cmbUlke.FormattingEnabled = true;
            this.cmbUlke.Location = new System.Drawing.Point(81, 50);
            this.cmbUlke.Name = "cmbUlke";
            this.cmbUlke.Size = new System.Drawing.Size(153, 21);
            this.cmbUlke.TabIndex = 11;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(1, 330);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(201, 100);
            this.btnKaydet.TabIndex = 10;
            this.btnKaydet.Text = "Ekle";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // txtHabitat
            // 
            this.txtHabitat.Location = new System.Drawing.Point(81, 133);
            this.txtHabitat.Name = "txtHabitat";
            this.txtHabitat.Size = new System.Drawing.Size(153, 20);
            this.txtHabitat.TabIndex = 21;
            // 
            // YeniEkleFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 450);
            this.Controls.Add(this.txtHabitat);
            this.Controls.Add(this.txtSayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.pbFotograf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUlke);
            this.Controls.Add(this.btnKaydet);
            this.Name = "YeniEkleFrom";
            this.Text = "YeniEkleFrom";
            this.Load += new System.EventHandler(this.YeniEkleFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotograf)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSayisi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.PictureBox pbFotograf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbUlke;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtHabitat;
    }
}