using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_HASTANE_KAYIT_UYGULAMASI
{
    internal class ExecuteNoneQuery
    {
        public void Execute(string query,SqlConnection con)
        {
            SqlCommand command = new SqlCommand(query, con);

            command.ExecuteNonQuery();
        }
    }
}
