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
using MySql.Data.MySqlClient;

namespace Canlılar_304
{
    public partial class ListeleFrom : Form
    {
        string baglanti = "Server=localhost;Database=endangered_species_db;Uid=root;Pwd='';";
        string yeniAd;
        public ListeleFrom()
        {
            InitializeComponent();
        }

        private void ListeleFrom_Load(object sender, EventArgs e)
        {
             CmbDoldur();
            DgwDoldur();
        }

        private void dgwCanlilar_SelectionChanged(object sender, EventArgs e)
        {
           
            if (dgwCanlilar.SelectedRows.Count > 0)
            {
                txtAd.Text = dgwCanlilar.SelectedRows[0].Cells["name"].Value.ToString();
                cmbUlke.SelectedValue = dgwCanlilar.SelectedRows[0].Cells["country"].Value.ToString();
                txtSayisi.Text = dgwCanlilar.SelectedRows[0].Cells["population"].Value.ToString();
                txtHabitat.Text = dgwCanlilar.SelectedRows[0].Cells["habitat"].Value.ToString();
               

                string dosyaYolu = Path.Combine(Environment.CurrentDirectory, "fotograf", dgwCanlilar.SelectedRows[0].Cells["photo_path"].Value.ToString());

               pbFotograf.Image = null;
                if (File.Exists(dosyaYolu))
                {
                    pbFotograf.Image = Image.FromFile(dosyaYolu);
                    pbFotograf.SizeMode = PictureBoxSizeMode.StretchImage;
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
                cmbUlke.ValueMember = "country";

            }

        }
        void DgwDoldur()
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "SELECT * FROM  EndangeredSpecies;";

                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);
                dgwCanlilar.DataSource = dt;

            }
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

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            using (MySqlConnection baglan = new MySqlConnection(baglanti))
            {
                baglan.Open();
                string sorgu = "UPDATE  EndangeredSpecies SET name=@ad,  country=@yaşadığı_ülke,  photo_path=@gorsel, population= @popülasyon  , habitat = @habitat WHERE id = @id";
                MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                cmd.Parameters.AddWithValue("@ad", txtAd.Text);
                cmd.Parameters.AddWithValue("@yaşadığı_ülke", cmbUlke.SelectedValue);
                cmd.Parameters.AddWithValue("@habitat", txtHabitat.Text);
                cmd.Parameters.AddWithValue("@popülasyon", txtSayisi.Text);
                cmd.Parameters.AddWithValue("@gorsel", yeniAd);

                int id = Convert.ToInt32(dgwCanlilar.SelectedRows[0].Cells["id"].Value);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@fotograf", yeniAd);

                cmd.ExecuteNonQuery();
                DgwDoldur();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgwCanlilar.SelectedRows[0];

            int id = Convert.ToInt32(dr.Cells[0].Value);

            DialogResult cevap = MessageBox.Show("Kayıtı silmek istediğinizden emin misiniz?",
                                                 "Kayıtı sil", MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Warning);

            if (cevap == DialogResult.Yes)
            {

                using (MySqlConnection baglan = new MySqlConnection(baglanti))
                {
                    int hid = Convert.ToInt32(dgwCanlilar.SelectedRows[0].Cells["id"].Value);
                    baglan.Open();
                    string sorgu = "DELETE FROM EndangeredSpecies WHERE id=@id;";
                    MySqlCommand cmd = new MySqlCommand(sorgu, baglan);
                    cmd.Parameters.AddWithValue("@id", hid);
                    cmd.ExecuteNonQuery();

                    DgwDoldur();
                }

            }
        }
    }
}
