using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using MySql.Data.MySqlClient;

namespace Canlılar_304
{
    public partial class YeniEkleFrom : Form
    {
        string baglanti = "Server=localhost;Database=endangered_species_db;Uid=root;Pwd='';";
        string yeniAd;
        public YeniEkleFrom()
        {
          
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
           
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                string sorgu = "INSERT INTO EndangeredSpecies VALUES(NULL, @name ,@country ,@population ,@habitat ,@photo_pat);";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@name",txtAd.Text);
                cmd.Parameters.AddWithValue("@country", cmbUlke.SelectedValue);
                cmd.Parameters.AddWithValue("@population", txtSayisi.Text);
                cmd.Parameters.AddWithValue("@habitat",txtHabitat.Text);
                cmd.Parameters.AddWithValue("@photo_pat", yeniAd);

                if (cmd.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Kayıt Eklendi");
                }
            }
         
        }
        void CmbDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT DISTINCT country FROM EndangeredSpecies;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                cmbUlke.DataSource = dt;

                cmbUlke.DisplayMember = "country";
               cmbUlke .ValueMember = "country";

            }

        }

        private void YeniEkleFrom_Load(object sender, EventArgs e)
        {
            CmbDoldur();
        }

        private void pbFotograf_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            DialogResult result = openFileDialog.ShowDialog(this);

            if (result != DialogResult.OK) return;

            string kaynakDosya = openFileDialog.FileName;
            yeniAd = Guid.NewGuid().ToString() + Path.GetExtension(kaynakDosya);
            string hedefDosya = Path.Combine(Environment.CurrentDirectory, "fotograf", yeniAd);

            File.Copy(kaynakDosya, hedefDosya);

            pbFotograf.Image = null;
            if (File.Exists(hedefDosya))
            {
                pbFotograf.Image = Image.FromFile(hedefDosya);
                pbFotograf.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

    }
    
}
