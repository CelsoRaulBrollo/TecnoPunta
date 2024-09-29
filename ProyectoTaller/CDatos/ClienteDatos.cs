using System;
using System.Data;
using System.Data.SqlClient;

namespace ProyectoTaller.CDatos
{
    public class ClienteDatos
    {
        private string cadenaConexion = @"Server=CELSOBRO\SQLEXPRESS;Database=BaseTecnoPunta;Trusted_Connection=True;";

        public DataTable ObtenerClientes()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
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
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    string query = "INSERT INTO Clientes (DNI, Nombre, Apellido, Telefono, Correo, Direccion) VALUES (@DNI, @Nombre, @Apellido, @Telefono, @Correo, @Direccion)";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Direccion", direccion);

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
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    string query = "UPDATE Clientes SET Nombre=@Nombre, Apellido=@Apellido, Telefono=@Telefono, Correo=@Correo, Direccion=@Direccion WHERE DNI=@DNI";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DNI", dni);
                    command.Parameters.AddWithValue("@Nombre", nombre);
                    command.Parameters.AddWithValue("@Apellido", apellido);
                    command.Parameters.AddWithValue("@Telefono", telefono);
                    command.Parameters.AddWithValue("@Correo", correo);
                    command.Parameters.AddWithValue("@Direccion", direccion);

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
                using (SqlConnection connection = new SqlConnection(cadenaConexion))
                {
                    string query = "DELETE FROM Clientes WHERE DNI=@DNI";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@DNI", dni);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al borrar cliente: {ex.Message}");
            }
        }
    }
}
