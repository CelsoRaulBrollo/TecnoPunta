using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyectoTaller.CModelos;
using System.Security.Policy;
using ProyectoTaller.Views.Vendedor;

namespace ProyectoTaller.CDatos
{
    public class UsuarioDatos
    {
        private ConexionBD conexion = new ConexionBD();
        public DataTable ListarUsuario()
        {
            DataTable lista = new DataTable();

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = @"SELECT
                        u.DNI_Usuario AS DNI,
                        u.Usuario AS Usuario,
                        u.Nombre_Usuario AS Nombre,
                        u.Apellido_Usuario AS Apellido,
                        u.Correo_Usuario AS Correo,
                        u.Sueldo_Usuario AS Sueldo,
                        u.Telefono_Usuario AS Telefono,
                        u.Contraseña AS Contraseña,
                        s.Descripcion_Sexo AS Sexo,
                        r.Descripcion_Rol AS Rol,
                        u.Estado_Usuarios As Estado
                        FROM 
                            Usuarios u
                        JOIN 
                            Sexo s ON u.Sexo_Usuario = s.Id_Sexo
                        JOIN 
                            Roles r ON u.Rol_Usuario = r.Id_Rol;";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.CommandType = CommandType.Text;

                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    try
                    {
                        lista.Load(reader);
                    }
                    catch (Exception ex) { 

                        lista = new DataTable();
                    }
                    

                }
            }

            return lista;
        }

        public bool ActualizarUsuario(Usuarios usuario)
        {
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = @"
                UPDATE Usuarios
                SET Nombre_Usuario = @Nombre,
                    Apellido_Usuario = @Apellido,
                    Telefono_Usuario = @Telefono,
                    Correo_Usuario = @Correo,
                    Sueldo_Usuario = @Sueldo,

                    Contraseña = @Contraseña,
                    Usuario = @Usuario,
                    Sexo_Usuario = @Id_Sexo,
                    Rol_Usuario = @Id_Rol
                WHERE DNI_Usuario = @DNI";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre_Usuario);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido_Usuario);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono_Usuario);
                cmd.Parameters.AddWithValue("@Correo", usuario.Correo_Usuario);
                cmd.Parameters.AddWithValue("@Sueldo", usuario.Sueldo_Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                cmd.Parameters.Add("@Id_Sexo", SqlDbType.Int).Value = usuario.Sexo_Usuario;
                
                cmd.Parameters.Add("@Id_Rol", SqlDbType.Int).Value = usuario.Rol_Usuario;
                cmd.Parameters.AddWithValue("@DNI", usuario.DNI_Usuario);
                connection.Open();
                bool resultado = cmd.ExecuteNonQuery() > 0;

                

                if (usuario.Sexo_Usuario == 3)
                {
                    CrearCarrito(usuario.DNI_Usuario);
                }
                return resultado; 
            }
        }

        public void CrearCarrito(int dniVendedor)
        {
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string insertCarritoQuery = "INSERT INTO Carrito (DNI_Vendedor, Total) VALUES (@DNI_Vendedor, 0)";
                using (var command = new SqlCommand(insertCarritoQuery, connection))
                {
                    command.Parameters.AddWithValue("@DNI_Vendedor", dniVendedor);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public void GuardarUsuario(Usuarios usuario)
        {
            try
            {
                using (SqlConnection connection = conexion.ObtenerConexion())
                {
                    string query = @"
    INSERT INTO Usuarios (DNI_Usuario, Usuario, Nombre_Usuario, Apellido_Usuario, Correo_Usuario, Sueldo_Usuario, Telefono_Usuario, 
                          Contraseña, Sexo_Usuario, Rol_Usuario)
    VALUES (@DNI, @Usuario, @Nombre, @Apellido, @Correo, @Sueldo, @Telefono, @Contraseña, @Id_Sexo, @Id_Rol)";

                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@DNI", usuario.DNI_Usuario);
                    cmd.Parameters.AddWithValue("@Usuario", usuario.Usuario);
                    cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre_Usuario);
                    cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido_Usuario);
                    cmd.Parameters.AddWithValue("@Correo", usuario.Correo_Usuario);
                    cmd.Parameters.AddWithValue("@Sueldo", usuario.Sueldo_Usuario);
                    cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono_Usuario);
                    cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                    cmd.Parameters.Add("@Id_Sexo", SqlDbType.Int).Value = usuario.Sexo_Usuario;
                    cmd.Parameters.Add("@Id_Rol", SqlDbType.Int).Value = usuario.Rol_Usuario;

                    connection.Open();
                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException sqlEx)
            {
                throw new Exception("Error al guardar el usuario: " + sqlEx.Message, sqlEx);
            }
        }


        public bool EsDniExistente(int dni)
        {
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE DNI_Usuario = @DNI";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DNI", dni);
                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public bool EsCorreoExistente(string correo)
        {
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Correo_Usuario = @Correo";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Correo", correo);
                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public bool EsUsuarioExistente(string nombreUsuario)
        {
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM Usuarios WHERE Usuario = @Usuario";
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@Usuario", nombreUsuario);
                connection.Open();
                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }

        public Usuarios buscarUsuario(int dni)
        {
            Usuarios usuario = null;

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Usuarios WHERE DNI_Usuario = @DNI_Usuario";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DNI_Usuario", dni);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            usuario = new Usuarios
                            {
                                DNI_Usuario = Convert.ToInt32(reader["DNI_Usuario"]),
                                Usuario = reader["Usuario"].ToString(),
                                Nombre_Usuario = reader["Nombre_Usuario"].ToString(),
                                Apellido_Usuario = reader["Apellido_Usuario"].ToString(),
                                Correo_Usuario = reader["Correo_Usuario"].ToString(),
                                Sueldo_Usuario = Convert.ToDecimal(reader["Sueldo_Usuario"]),
                                Telefono_Usuario = reader["Telefono_Usuario"].ToString(),
                                Sexo_Usuario = Convert.ToInt32(reader["Sexo_Usuario"]),
                                Rol_Usuario = Convert.ToInt32(reader["Rol_Usuario"]),
                                Estado = reader["Estado_Usuarios"].ToString()
                            };
                        }
                    }
                }
            }

            return usuario;
        }

        public Usuarios autenticacion(string nombreUsuario, string contraseña)
        {
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT * FROM Usuarios WHERE Usuario = @Usuario AND Contraseña = @Contraseña";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@Usuario", nombreUsuario);
                    command.Parameters.AddWithValue("@Contraseña", contraseña);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            
                            return new Usuarios
                            {
                                DNI_Usuario = Convert.ToInt32(reader["DNI_Usuario"]),
                                Usuario = reader["Usuario"].ToString(),
                                Nombre_Usuario = reader["Nombre_Usuario"].ToString(),
                                Apellido_Usuario = reader["Apellido_Usuario"].ToString(),
                                Correo_Usuario = reader["Correo_Usuario"].ToString(),
                                Sueldo_Usuario = Convert.ToDecimal(reader["Sueldo_Usuario"]),
                                Telefono_Usuario = reader["Telefono_Usuario"].ToString(),
                                Sexo_Usuario = Convert.ToInt32(reader["Sexo_Usuario"]),
                                Rol_Usuario = Convert.ToInt32(reader["Rol_Usuario"]),
                                Estado = reader["Estado_Usuarios"].ToString()
                            };
                        }
                        else
                        {
                           
                            return null; 
                        }
                    }

                }
            }
        }

        public void actualizarEstado(int dni_Usuario)
        {
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                connection.Open();
                string selectQuery = @"
                    SELECT Estado_Usuarios 
                    FROM Usuarios 
                    WHERE DNI_Usuario = @DNI_Usuario";

                var buscarUltimoEstadoCommand = new SqlCommand(selectQuery, connection);
                buscarUltimoEstadoCommand.Parameters.AddWithValue("@DNI_Usuario", dni_Usuario);

                var estadoActual = buscarUltimoEstadoCommand.ExecuteScalar() as string;

                string nuevoEstado = (estadoActual == "ACTIVO") ? "BAJA" : "ACTIVO";

                string updateQuery = @"
                    UPDATE Usuarios 
                    SET Estado_Usuarios = @NuevoEstado 
                    WHERE DNI_Usuario = @DNI_Usuario";

                var ActualizarCommand = new SqlCommand(updateQuery, connection);
                ActualizarCommand.Parameters.AddWithValue("@NuevoEstado", nuevoEstado);
                ActualizarCommand.Parameters.AddWithValue("@DNI_Usuario", dni_Usuario);

                ActualizarCommand.ExecuteNonQuery();

            }
        }
    }
}
