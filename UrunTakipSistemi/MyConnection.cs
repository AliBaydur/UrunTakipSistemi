using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UrunTakipSistemi
{
    class MyConnection
    {
        string ConnectionString = @"Server=ALI\SQLEXPRESS; Database=ETicaretFilm; Trusted_Connection=True";
        public SqlConnection connection()
        {
            SqlConnection cnn = new SqlConnection(ConnectionString);
            if (cnn.State != System.Data.ConnectionState.Open)
            {
                try
                {
                    cnn.Open();
                }
                catch
                {
                    
                }
            }
            return cnn;
        }
    }
}
