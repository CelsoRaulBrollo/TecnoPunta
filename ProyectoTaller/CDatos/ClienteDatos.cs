using ProyectoTaller.CModelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoTaller.CDatos
{
    public class ClienteDatos
    {
        private  ConexionBD conexion = new ConexionBD();


        public List<Clientes> listaDeClientes()
        {
            List<Clientes> listaClientes = new List<Clientes>();
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT * from Clientes";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Clientes cliente = new Clientes
                            {
                                DNI_Cliente = Convert.ToInt32(reader["DNI_Cliente"]),
                                Nombre_Cliente = reader["Nombre_Cliente"].ToString(),
                                Apellido_Cliente = reader["Apellido_Cliente"].ToString(),
                                Telefono_Cliente = reader["Telefono_Cliente"].ToString(),
                                Correo_Cliente = reader["Correo_Cliente"].ToString(),
                                Direccion_Cliente = reader["Direccion_Cliente"].ToString(),
                                Estado = reader["Estado_Cliente"].ToString()
                            };
                            listaClientes.Add(cliente);
                        }
                    }
                }
                return listaClientes;

            }
        }


        public DataTable ObtenerClientes()
        {
            try
            {
                using (SqlConnection connection = conexion.ObtenerConexion())
                {
                    SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Clientes", connection);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al obtener clientes: {ex.Message}");
                return null;
            }
        }

        public void AgregarCliente(int dni, string nombre, string apellido, int telefono, string correo, string direccion)
        {
            try
            {
                using (SqlConnection connection = conexion.ObtenerConexion())
                {
                    string query = "INSERT INTO Clientes (DNI_cliente, Nombre_Cliente, Apellido_Cliente, Telefono_Cliente, Correo_Cliente, Direccion_Cliente) VALUES (@DNI_Cliente, @Nombre_Cliente, @Apellido_Cliente, @Telefono_Cliente, @Correo_Cliente, @Direccion_Cliente)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DNI_Cliente", dni);
                    command.Parameters.AddWithValue("@Nombre_Cliente", nombre);
                    command.Parameters.AddWithValue("@Apellido_Cliente", apellido);
                    command.Parameters.AddWithValue("@Telefono_Cliente", telefono);
                    command.Parameters.AddWithValue("@Correo_Cliente", correo);
                    command.Parameters.AddWithValue("@Direccion_Cliente", direccion);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar cliente: {ex.Message}");
            }
        }

        public void EditarCliente(int dni, string nombre, string apellido, int telefono, string correo, string direccion)
        {
            try
            {
                using (SqlConnection connection = conexion.ObtenerConexion())
                {
                    string query = "UPDATE Clientes SET Nombre_Cliente=@Nombre_Cliente, Apellido_Cliente=@Apellido_Cliente, Telefono_Cliente=@Telefono_Cliente, Correo_Cliente=@Correo_Cliente, Direccion_Cliente=@Direccion_Cliente WHERE DNI_cliente=@DNI_Cliente";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DNI_Cliente", dni);
                    command.Parameters.AddWithValue("@Nombre_Cliente", nombre);
                    command.Parameters.AddWithValue("@Apellido_Cliente", apellido);
                    command.Parameters.AddWithValue("@Telefono_Cliente", telefono);
                    command.Parameters.AddWithValue("@Correo_Cliente", correo);
                    command.Parameters.AddWithValue("@Direccion_Cliente", direccion);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al editar cliente: {ex.Message}");
            }
        }

        public void BorrarCliente(int dni)
        {
            try
            {
                using (SqlConnection connection = conexion.ObtenerConexion())
                {
                    string query = "DELETE FROM Clientes WHERE DNI_cliente=@DNI_Cliente";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DNI_Cliente", dni);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al borrar cliente: {ex.Message}");
            }
        }

        public bool VerificarDNIExistente(int dniCliente)
        {
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT COUNT(1) FROM Clientes WHERE DNI_cliente = @DNICliente";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DNICliente", dniCliente);

                    connection.Open();
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

        public bool VerificarTelefono(string telefono)
        {
            using (var con = conexion.ObtenerConexion())
            {
                con.Open();
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Clientes WHERE Telefono_Cliente = @Telefono", con))
                {
                    cmd.Parameters.AddWithValue("@Telefono", telefono);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }



        public bool VerificarCorreo(string correo)
        {
            using (var con = conexion.ObtenerConexion())
            {
                con.Open();
                using (var cmd = new SqlCommand("SELECT COUNT(*) FROM Clientes WHERE Correo_Cliente = @Correo", con))
                {
                    cmd.Parameters.AddWithValue("@Correo", correo);
                    int count = (int)cmd.ExecuteScalar();
                    return count > 0;
                }
            }
        }

        public Clientes buscarCliente(int dniCliente)
        {
            Clientes cliente = null;
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT DNI_Cliente, Nombre_Cliente, Apellido_Cliente, Telefono_Cliente, Correo_Cliente, Direccion_Cliente " +
                      "FROM Clientes WHERE DNI_Cliente = @DNI_Cliente";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DNI_Cliente", dniCliente);

        
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                     
                        if (reader.Read())
                        {
                            cliente = new Clientes
                            {
                                DNI_Cliente = reader.GetInt32(reader.GetOrdinal("DNI_Cliente")),
                                Nombre_Cliente = reader["Nombre_Cliente"].ToString(),
                                Apellido_Cliente = reader["Apellido_Cliente"].ToString(),
                                Telefono_Cliente = reader["Telefono_Cliente"].ToString(),
                                Correo_Cliente = reader["Correo_Cliente"].ToString(),
                                Direccion_Cliente = reader["Direccion_Cliente"].ToString()
                            };
                        }
                    }
                }
            }

             return cliente;
        }

    }
}

