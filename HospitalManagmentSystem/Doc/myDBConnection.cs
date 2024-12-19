using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Doc
{
    class myDBConnection
    {
        public MySqlConnection? cn;
        public void Connect()
        {
            string connectionString = "Server=localhost;Database=hospitalms;Uid=root;Pwd=;";
            cn = new MySqlConnection(connectionString);
        }

    }
}

