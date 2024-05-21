namespace Canlılar_304
{
    partial class ListeleFrom
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
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.dgwCanlilar = new System.Windows.Forms.DataGridView();
            this.txtHabitat = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFotograf)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCanlilar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSayisi
            // 
            this.txtSayisi.Location = new System.Drawing.Point(86, 89);
            this.txtSayisi.Name = "txtSayisi";
            this.txtSayisi.Size = new System.Drawing.Size(153, 20);
            this.txtSayisi.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(265, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Fotograf";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Canlı sayısı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Konum";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Ülke";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(86, 8);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(153, 20);
            this.txtAd.TabIndex = 26;
            // 
            // pbFotograf
            // 
            this.pbFotograf.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pbFotograf.Location = new System.Drawing.Point(326, 8);
            this.pbFotograf.Name = "pbFotograf";
            this.pbFotograf.Size = new System.Drawing.Size(187, 219);
            this.pbFotograf.TabIndex = 25;
            this.pbFotograf.TabStop = false;
            this.pbFotograf.Click += new System.EventHandler(this.pbFotograf_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Canlı adı";
            // 
            // cmbUlke
            // 
            this.cmbUlke.FormattingEnabled = true;
            this.cmbUlke.Location = new System.Drawing.Point(86, 44);
            this.cmbUlke.Name = "cmbUlke";
            this.cmbUlke.Size = new System.Drawing.Size(153, 21);
            this.cmbUlke.TabIndex = 22;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(574, 11);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(201, 100);
            this.btnGuncelle.TabIndex = 21;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(574, 127);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(201, 100);
            this.btnSil.TabIndex = 32;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // dgwCanlilar
            // 
            this.dgwCanlilar.AllowUserToAddRows = false;
            this.dgwCanlilar.AllowUserToDeleteRows = false;
            this.dgwCanlilar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwCanlilar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwCanlilar.Location = new System.Drawing.Point(0, 271);
            this.dgwCanlilar.Name = "dgwCanlilar";
            this.dgwCanlilar.ReadOnly = true;
            this.dgwCanlilar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwCanlilar.Size = new System.Drawing.Size(799, 182);
            this.dgwCanlilar.TabIndex = 33;
            this.dgwCanlilar.SelectionChanged += new System.EventHandler(this.dgwCanlilar_SelectionChanged);
            // 
            // txtHabitat
            // 
            this.txtHabitat.Location = new System.Drawing.Point(86, 127);
            this.txtHabitat.Name = "txtHabitat";
            this.txtHabitat.Size = new System.Drawing.Size(153, 20);
            this.txtHabitat.TabIndex = 34;
            // 
            // ListeleFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtHabitat);
            this.Controls.Add(this.dgwCanlilar);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.txtSayisi);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.pbFotograf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUlke);
            this.Controls.Add(this.btnGuncelle);
            this.Name = "ListeleFrom";
            this.Text = "ListeleFrom";
            this.Load += new System.EventHandler(this.ListeleFrom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFotograf)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwCanlilar)).EndInit();
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
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.DataGridView dgwCanlilar;
        private System.Windows.Forms.TextBox txtHabitat;
    }
}