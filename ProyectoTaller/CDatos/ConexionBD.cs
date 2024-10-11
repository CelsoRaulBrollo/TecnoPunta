using System.Configuration;
using System.Data.SqlClient;

namespace ProyectoTaller.CDatos
{
    public class ConexionBD
    {
        public string cadenaConexion = ConfigurationManager.ConnectionStrings["TecnoPuntaDB"].ConnectionString;

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}