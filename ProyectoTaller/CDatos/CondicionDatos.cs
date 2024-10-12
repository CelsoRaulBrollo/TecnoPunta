using ProyectoTaller.CModelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CDatos
{
    public class CondicionDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public List<Condicion> ObtenerMarcas()
        {
            List<Condicion> condicion = new List<Condicion>();

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT Id_Condicion, Descripcion_Condicion FROM Condicion";
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    condicion.Add(new Condicion
                    {
                        Id_Condicion = (int)reader["Id_Marca"],
                        Descripcion_Condicion = reader["Descripcion_Marca"].ToString()
                    });
                }
            }

            return condicion;
        }
    }
}
