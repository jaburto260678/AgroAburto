using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgroAburto.Datos
{
    public class ConexionBD
    {
        public static readonly string cadenaConexion =
            "Server=localhost;Port=3306;Database=agroaburto;User ID=root;Password=;";

        public static MySqlConnection ObtenerConexion()
        {
            return new MySqlConnection(cadenaConexion);
        }
    }
}