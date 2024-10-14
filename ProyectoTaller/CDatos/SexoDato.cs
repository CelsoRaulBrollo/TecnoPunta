using ProyectoTaller.CModelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CDatos
{
    public class SexoDato
    {
        private ConexionBD conexion = new ConexionBD();

        public List<Sexo> ObtenerSexo()
        {
            List<Sexo> listaSexos = new List<Sexo>();

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT Id_Sexo, Descripcion_Sexo FROM Sexo"; 
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    listaSexos.Add(new Sexo
                    {
                        Id_Sexo = (int)reader["Id_Sexo"],
                        Descripcion_Sexo = reader["Descripcion_Sexo"].ToString()
                    });
                }
            }

            return listaSexos;
        }

        public int buscarIDSexoPorDescripcion(string descripcion)
        {
            int id = -1;
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT Id_Sexo FROM Sexo WHERE Descripcion_Sexo = @Descripcion_Sexo";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Descripcion_Sexo", descripcion);

                    connection.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        id = Convert.ToInt32(result);
                    }
                }
            }


            return id;
        }
    }
}
