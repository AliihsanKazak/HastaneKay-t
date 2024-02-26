using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_HASTANE_KAYIT_UYGULAMASI
{
    public partial class Menu : Form
    {
        List<Hasta> hastalar = new List<Hasta>();
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void btn_randevu_olustur_Click(object sender, EventArgs e)
        {
            this.Hide();
            Randevu_Ekrani re = new Randevu_Ekrani();
            re.Show();
        }

        private void btn_kullanici_bilgileri_Click(object sender, EventArgs e)
        {

        }
    }
}
