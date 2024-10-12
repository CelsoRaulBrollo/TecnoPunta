using ProyectoTaller.CModelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CDatos
{
    public class MarcaDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public List<Marca> ObtenerMarcas()
        {
            List<Marca> marcas = new List<Marca>();

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT Id_Marcal, Descripcion_Marca FROM Marca"; 
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    marcas.Add(new Marca
                    {
                        Id_Marca = (int)reader["Id_Marca"],
                        Descripcion_Marca = reader["Descripcion_Marca"].ToString()
                    });
                }
            }

            return marcas;
        }
    }
}
