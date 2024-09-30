using System.Data.SqlClient;

namespace ProyectoTaller.CDatos
{
    public class ConexionBD
    {
        private string cadenaConexion = @"Server=CELSOBRO\SQLEXPRESS;Database=TecnoPuntaBD;Trusted_Connection=True;";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}