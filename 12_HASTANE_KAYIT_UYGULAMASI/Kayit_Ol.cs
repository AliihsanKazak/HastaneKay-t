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
    
    public partial class Kayit_Ol : Form
    {
        string connection = "Server=202-HOCAPC\\SQLDERS;Database=HastaneDB;Trusted_Connection=True;";


        List<Hasta> hastalar = new List<Hasta>();
        public Kayit_Ol()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kayit_Ol_Load(object sender, EventArgs e)
        {

        }

        private void btn_kayitol_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            string cinsiyet = "";
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string tc = txt_TC.Text;
            string mail = txt_mail.Text;
            string tel = txt_tel.Text;
            if(rdb_erkek.Checked)
            {
               cinsiyet = rdb_erkek.Text;
            }
            else if(rdb_kadin.Checked)
            {
                cinsiyet = rdb_kadin.Text;
            }
            


            string insert_query = $"insert into Hastalar (HastaAd,HastaSoyad,HastaMail,HastaTel,HastaCinsiyet,HastaTC)values('{isim}','{soyisim}','{mail}','{tel}','{cinsiyet}','{tc}')";

            SqlCommand command = new SqlCommand(insert_query,con);

            command.ExecuteNonQuery();


        }
    }
}
