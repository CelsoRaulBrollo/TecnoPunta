using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using ProyectoTaller.CModelos;

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
                        r.Descripcion_Rol AS Rol
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
                return cmd.ExecuteNonQuery() > 0; 
            }
        }

        public bool GuardarUsuario(Usuario usuario)
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
                
                if(usuario.Rol_Usuario == 3)
                {
                    string queryCarrito = @"
                    INSERT INTO Carrito (DNI_Vendedor, Total)
                    VALUES (@DNI, 0)";

                    SqlCommand cmdCarrito = new SqlCommand(queryCarrito, connection);
                    cmdCarrito.Parameters.AddWithValue("@DNI", usuario.DNI_Usuario);
                    cmdCarrito.ExecuteNonQuery();
                }
                return cmd.ExecuteNonQuery() > 0;
            }

        }
    }
}
