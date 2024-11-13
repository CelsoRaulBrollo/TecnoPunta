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
        private ConexionBD conexion = new ConexionBD();


        public List<Clientes> listaDeClientes()
        {
            List<Clientes> listaClientes = new List<Clientes>();
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string query = "SELECT * from Clientes order by Estado_Cliente";
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
                                Estado = reader["Estado_Cliente"].ToString(),
                                Genero = reader["genero"].ToString()
                            };
                            listaClientes.Add(cliente);
                        }
                    }
                }
                return listaClientes;

            }
        }

      
       

        public void AgregarCliente(Clientes cliente)
        {
            try
            {
                using (SqlConnection connection = conexion.ObtenerConexion())
                {
                    string query = "INSERT INTO Clientes (DNI_cliente, Nombre_Cliente, Apellido_Cliente, Telefono_Cliente, Correo_Cliente, Direccion_Cliente, genero) VALUES (@DNI_Cliente, @Nombre_Cliente, @Apellido_Cliente, @Telefono_Cliente, @Correo_Cliente, @Direccion_Cliente ,@Genero_Cliente)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DNI_Cliente", cliente.DNI_Cliente);
                    command.Parameters.AddWithValue("@Nombre_Cliente", cliente.Nombre_Cliente);
                    command.Parameters.AddWithValue("@Apellido_Cliente", cliente.Apellido_Cliente);
                    command.Parameters.AddWithValue("@Telefono_Cliente", cliente.Telefono_Cliente);
                    command.Parameters.AddWithValue("@Correo_Cliente", cliente.Correo_Cliente);
                    command.Parameters.AddWithValue("@Direccion_Cliente", cliente.Direccion_Cliente);
                    command.Parameters.AddWithValue("@Genero_Cliente", cliente.Genero);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al agregar cliente: {ex.Message}");
            }
        }

        public void EditarCliente(Clientes cliente)
        {
            try
            {
                using (SqlConnection connection = conexion.ObtenerConexion())
                {
                    string query = "UPDATE Clientes SET Nombre_Cliente=@Nombre_Cliente, Apellido_Cliente=@Apellido_Cliente, Telefono_Cliente=@Telefono_Cliente, Correo_Cliente=@Correo_Cliente, Direccion_Cliente=@Direccion_Cliente, genero = @Genero_Cliente WHERE DNI_cliente=@DNI_Cliente";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DNI_Cliente", cliente.DNI_Cliente);
                    command.Parameters.AddWithValue("@Nombre_Cliente", cliente.Nombre_Cliente);
                    command.Parameters.AddWithValue("@Apellido_Cliente", cliente.Apellido_Cliente);
                    command.Parameters.AddWithValue("@Telefono_Cliente", cliente.Telefono_Cliente);
                    command.Parameters.AddWithValue("@Correo_Cliente", cliente.Correo_Cliente);
                    command.Parameters.AddWithValue("@Direccion_Cliente", cliente.Direccion_Cliente);
                    command.Parameters.AddWithValue("@Genero_Cliente", cliente.Genero);

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

        public void altaCliente(int dniCliente)
        {
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                connection.Open();
                string query = @"
                            UPDATE Clientes
                            SET Estado_Cliente = 'ACTIVO'
                            WHERE DNI_Cliente = @DNI_Cliente";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DNI_Cliente", dniCliente);
                    command.ExecuteNonQuery();
                }
            }
        }


        public void bajaCliente(int dniCliente)
        {
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                connection.Open();
                string query = @"
                        UPDATE Clientes
                        SET Estado_Cliente = 'BAJA'
                        WHERE DNI_Cliente = @DNI_Cliente";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DNI_Cliente", dniCliente);
                    command.ExecuteNonQuery();
                }
            }
        }

        public DataTable GenerarInformeClientes(DateTime desde, DateTime hasta)
        {
            DataTable dtClientes = new DataTable();

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                connection.Open();

                
                string query = @"
                SELECT c.genero AS Estado, COUNT(c.DNI_Cliente) AS Cantidad
                FROM Clientes c
                WHERE 
                    c.fechaCreacion >= @Desde 
                    AND c.fechaCreacion < @Hasta
                GROUP BY c.genero";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@Desde", desde);
                    command.Parameters.AddWithValue("@Hasta", hasta.AddDays(1));

                    
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dtClientes);
                    }
                }
            }

            return dtClientes;
        }

        public DataTable ObtenerInformeClientesGenero()
        {
            DataTable dataTable = new DataTable();

        
                        string query = @"
                                SELECT
                                YEAR(fechaCreacion) AS Año,
                                MONTH(fechaCreacion) AS Mes,
                                genero,
                                COUNT(*) AS Cantidad_Clientes
                            FROM
                                Clientes
                            
                            GROUP BY
                                YEAR(fechaCreacion),
                                MONTH(fechaCreacion),
                                genero
                            ORDER BY
                                Año,
                                Mes,
                                genero;;";

            
            ConexionBD conexion = new ConexionBD();

            using (SqlConnection connection = conexion.ObtenerConexion()) 
            {
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    

                    try
                    {
                        connection.Open();

                        
                        using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
                        {
                            dataAdapter.Fill(dataTable); 
                        }
                    }
                    catch (Exception ex)
                    {
                        throw new Exception($"Error al obtener los datos de clientes: {ex.Message}");
                    }
                }
            }

            return dataTable;
        }

    }
}

