using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _12_HASTANE_KAYIT_UYGULAMASI
{
    public partial class Login : Form
    {
        string connection = "Server=202-HOCAPC\\SQLDERS;Database=HastaneDB;Trusted_Connection=True;";
        public Login()
        {
            InitializeComponent();
        }

        private void btn_gir_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(connection);

                string ka = txt_ka.Text;
                string sfr = txt_sfr.Text;

                //con.Open();
                //MessageBox.Show("BAĞLANTI BAŞARILI!");

                con.Open();
                //string query = $"SELECT * FROM Kullanicilar where KullaniciAdi='{ka}'  and KullaniciSifre='{sfr}' ";

                string query = $"SELECT * FROM Kullanicilar where KullaniciAdi=@kullanici_adi  and KullaniciSifre=@kullanici_sifre ";

                SqlCommand command = new SqlCommand(query, con);

                command.Parameters.AddWithValue("@kullanici_Adi", ka);
                command.Parameters.AddWithValue("@kullanici_sifre", sfr);




                int veri_sayisi = (int)command.ExecuteScalar();

                Console.WriteLine("");
                if (veri_sayisi > 0)
                {
                    MessageBox.Show("GİRİŞ BAŞARILI");
                    this.Hide();
                    Menu menu = new Menu();
                    menu.Show();

                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalıdır!");
                }

                    }
            catch
            {
                MessageBox.Show("HATA!");
            }

        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            this.Hide();
            Kayit_Ol ko = new Kayit_Ol();
            ko.Show();
        }
    }
}
