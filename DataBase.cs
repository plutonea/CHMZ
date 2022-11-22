using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Threading.Tasks;

namespace CHMZ
{
    internal class DataBase
    {
        //это база
        MySqlConnection connection = new MySqlConnection("server=10.90.12.110;port=33333;user=st_2_20_5;database=is_2_20_st5_KURS;password=58224653;");
        
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection gConn()
        {
            return connection;
        }


    }
}
