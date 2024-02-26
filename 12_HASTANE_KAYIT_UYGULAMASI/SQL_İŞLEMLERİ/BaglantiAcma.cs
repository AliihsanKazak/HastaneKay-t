using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _12_HASTANE_KAYIT_UYGULAMASI
{
    internal class BaglantiAcma
    {
        public SqlConnection BaglantiAc()
        {
            string connection = "Server=202-HOCAPC\\SQLDERS;Database=HastaneDB;Trusted_Connection=True;";
            SqlConnection con = new SqlConnection(connection);
            con.Open();
            return con;
            
        }
        public void BaglantiKapat(SqlConnection con)
        {
            con.Close();
        }
    }
}
