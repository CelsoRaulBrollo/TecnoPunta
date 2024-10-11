using ProyectoTaller.CModelos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CDatos
{
    public class RolDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public List<Rol> ObtenerRoles()
        {
            List<Rol> roles = new List<Rol>();

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT Id_Rol, Descripcion_Rol FROM Roles"; // Asegúrate de tener la tabla Roles
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    roles.Add(new Rol
                    {
                        Id_Rol = (int)reader["Id_Rol"],
                        Descripcion_Rol = reader["Descripcion_Rol"].ToString()
                    });
                }
            }

            return roles;
        }

        public int buscarIDRolPorDescripcion(string descripcion)
        {
            int id = -1;
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT Id_Rol FROM Roles WHERE Descripcion_Rol = @Descripcion_Rol";

                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Descripcion_Rol", descripcion);

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
