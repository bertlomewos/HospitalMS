using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagmentSystem
{
    internal class ConnectionManager
    {
        string  mysqlconn = "server=127.0.0.1;user=root;database=hospitalms;password=";
        public readonly MySqlConnection mySql;
        public ConnectionManager()
        {
            mySql = new MySqlConnection(mysqlconn);
        }
    }
}
