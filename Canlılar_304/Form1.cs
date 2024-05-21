using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Canlılar_304
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            YeniEkleFrom yeniekleForm =  new YeniEkleFrom();
            yeniekleForm.ShowDialog();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            ListeleFrom listeleForm = new ListeleFrom();
            listeleForm.ShowDialog();
        }
    }
}
