using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Banco
{
    public class Conexion
    {
        
            static string conexion = "server = localhost; port = 3306; uid = 'root'; pwd = ''; database = banco;";
            MySqlConnection cn = new MySqlConnection(conexion);
    }
    
}
