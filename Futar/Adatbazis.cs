using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Futar
{
    public class Adatbazis
    {
        string server = "localhost";
        string user = "root";
        string database = "futar";

        MySqlConnection conn;

        public MySqlConnection Conn { get => conn; set => conn = value; }

        public Adatbazis()
        {
            string kapcs = $"server={server};user={user};database={database}";

            conn = new MySqlConnection(kapcs);
        }
    }
}
