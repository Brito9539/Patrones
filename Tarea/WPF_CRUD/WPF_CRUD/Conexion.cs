using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WPF_CRUD
{
    class Conexion
    {
        public static MySqlConnection conectar()
        {
            MySqlConnection conect = new MySqlConnection("server=127.0.0.1; database=universidad; Uid=root; pwd=root;");
            conect.Open();
            return conect;
        }
    }
}
