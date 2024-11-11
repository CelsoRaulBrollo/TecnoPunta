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

        public bool ActualizarUsuario(Usuario usuario)
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
                    Usuario = @Usuario_Login,
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
                cmd.Parameters.AddWithValue("@Usuario_Login", usuario.Usuario_Login);
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

        public void GuardarUsuario(Usuario usuario)
        {
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = @"
                INSERT INTO Usuarios (DNI_Usuario,Usuario, Nombre_Usuario, Apellido_Usuario,Correo_Usuario,Sueldo_Usuario , Telefono_Usuario, 
                                      Contraseña, Sexo_Usuario, Rol_Usuario)
                VALUES (@DNI, @Usuario,@Nombre, @Apellido, @Correo, @Sueldo, @Telefono,@Contraseña ,@Id_Sexo, @Id_Rol )";

                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@DNI", usuario.DNI_Usuario);
                cmd.Parameters.AddWithValue("@Usuario", usuario.Usuario_Login);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre_Usuario);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido_Usuario);
                cmd.Parameters.AddWithValue("@Correo", usuario.Correo_Usuario);
                cmd.Parameters.AddWithValue("@Sueldo", usuario.Sueldo_Usuario);
                cmd.Parameters.AddWithValue("@Telefono", usuario.Telefono_Usuario);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.Add("@Id_Sexo", SqlDbType.Int).Value = usuario.Sexo_Usuario; 
                cmd.Parameters.Add("@Id_Rol", SqlDbType.Int).Value = usuario.Rol_Usuario;



                connection.Open();

                if (cmd.ExecuteNonQuery() > 0)
                {
                    //si inserto los datos agrega el carrito para el vendedor
                    if (usuario.Rol_Usuario == 3)
                    {
                        string queryCarrito = @"
                                INSERT INTO Carrito (DNI_Vendedor, Total)
                                VALUES (@DNI, 0)";

                        using (SqlCommand cmdCarrito = new SqlCommand(queryCarrito, connection))
                        {
                            cmdCarrito.Parameters.AddWithValue("@DNI", usuario.DNI_Usuario);
                            cmdCarrito.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    throw new Exception("No se pudo guardar el usuario.");
                }

            }

        }

        public Usuario buscarUsuario(int dni)
        {
            Usuario usuario = null;

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
                            usuario = new Usuario
                            {
                                DNI_Usuario = Convert.ToInt32(reader["DNI_Usuario"]),
                                Usuario_Login = reader["Usuario"].ToString(),
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

        public Usuario autenticacion(string nombreUsuario, string contraseña)
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
                            
                            return new Usuario
                            {
                                DNI_Usuario = Convert.ToInt32(reader["DNI_Usuario"]),
                                Usuario_Login = reader["Usuario"].ToString(),
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
