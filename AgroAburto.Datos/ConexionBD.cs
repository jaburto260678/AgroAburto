using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgroAburto.Datos
{
    public class ConexionBD
    {
        // Cadena de conexión MySQL
        public static readonly string cadenaConexion =
            "Server=localhost;Port=3306;Database=agroaburto;User ID=root;Password=;";

        // Método para obtener la conexión a la BD
        public static MySqlConnection ObtenerConexion()
        {
            MySqlConnection conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();

            return conexion;
        }
    }
}