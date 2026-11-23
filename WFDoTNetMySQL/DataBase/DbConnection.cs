using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
   
     internal class DbConnection
    {
        
        private static MySqlConnection Connection = 
            new MySqlConnection("server=localhost;user='seuUsuario';password='suaSenha';database=db_agenda");

        public static MySqlConnection _Connection
        {
            get { return Connection; }
        }

        public static void Open()
        {
            Connection.Open();
        }
        public static void Close()
        {
            Connection.Close();
        }

    }
}
