using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using ProyectoTaller.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ProyectoTaller.CNegocio
{
    public class CarritoNegocio
    {
        private CarritoDatos carritoDatos;
        private ProductoDatos productoDatos;

        public CarritoNegocio()
        {
            carritoDatos = new CarritoDatos();
            productoDatos = new ProductoDatos();
        }

        public CarritoDTO cargarCarrito(int dniVendedor)
        {
            CarritoDTO carritoDTO = new CarritoDTO
            {
                detalles = new List<CarritoDetalleDTO>()
            };

            string connectionString = @"Server=CELSOBRO\SQLEXPRESS;Database=TecnoPuntaBD;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT Modelo, Descripcion, Cantidad, Precio FROM Carrito WHERE DNI_Vendedor = @dniVendedor";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@dniVendedor", dniVendedor);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            CarritoDetalleDTO detalle = new CarritoDetalleDTO
                            {
                                Modelo = reader["Modelo"].ToString(),
                                Descripcion = reader["Descripcion"].ToString(),
                                cantidad = Convert.ToInt32(reader["Cantidad"]),
                                precio = Convert.ToDecimal(reader["Precio"])
                            };
                            carritoDTO.detalles.Add(detalle);
                        }
                    }
                }
            }

            return carritoDTO;
        }

        public bool agregarProducto(Producto producto, int cantidad, int dniVendedor)
        {
            bool resultado = false;
            string connectionString = @"Server=CELSOBRO\SQLEXPRESS;Database=TecnoPuntaBD;Trusted_Connection=True;";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Verificar si el vendedor existe
                    string queryVerificarVendedor = "SELECT COUNT(*) FROM Usuarios WHERE DNI_Usuario = @dniVendedor";
                    using (SqlCommand commandVerificarVendedor = new SqlCommand(queryVerificarVendedor, connection))
                    {
                        commandVerificarVendedor.Parameters.AddWithValue("@dniVendedor", dniVendedor);
                        int vendedorCount = (int)commandVerificarVendedor.ExecuteScalar();

                        if (vendedorCount == 0)
                        {
                            MessageBox.Show("El DNI del vendedor no existe.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return resultado; // Salir si el vendedor no existe
                        }
                    }

                    // Verificar si el producto ya está en el carrito
                    string queryVerificarCarrito = "SELECT Cantidad FROM Carrito WHERE DNI_Vendedor = @dniVendedor AND Modelo = @modelo";
                    using (SqlCommand commandVerificarCarrito = new SqlCommand(queryVerificarCarrito, connection))
                    {
                        commandVerificarCarrito.Parameters.AddWithValue("@dniVendedor", dniVendedor);
                        commandVerificarCarrito.Parameters.AddWithValue("@modelo", producto.Modelo_Producto);

                        object cantidadExistente = commandVerificarCarrito.ExecuteScalar();

                        if (cantidadExistente != null) // Si el producto ya está en el carrito
                        {
                            // Actualizar la cantidad
                            int nuevaCantidad = Convert.ToInt32(cantidadExistente) + cantidad;

                            // Calcular el nuevo subtotal (nueva cantidad por precio)
                            decimal nuevoSubtotal = nuevaCantidad * producto.Precio_Producto;

                            string queryActualizar = "UPDATE Carrito SET Cantidad = @nuevaCantidad, Subtotal = @nuevoSubtotal WHERE DNI_Vendedor = @dniVendedor AND Modelo = @modelo";
                            using (SqlCommand commandActualizar = new SqlCommand(queryActualizar, connection))
                            {
                                commandActualizar.Parameters.AddWithValue("@nuevaCantidad", nuevaCantidad);
                                commandActualizar.Parameters.AddWithValue("@nuevoSubtotal", nuevoSubtotal);
                                commandActualizar.Parameters.AddWithValue("@dniVendedor", dniVendedor);
                                commandActualizar.Parameters.AddWithValue("@modelo", producto.Modelo_Producto);
                                commandActualizar.ExecuteNonQuery();
                            }
                            resultado = true; // La cantidad y subtotal se actualizaron correctamente
                        }
                        else // Si no existe, agregar un nuevo registro
                        {
                            // Calcular el subtotal (cantidad por precio)
                            decimal subtotal = cantidad * producto.Precio_Producto;

                            string queryInsertar = "INSERT INTO Carrito (DNI_Vendedor, Modelo, Descripcion, Cantidad, Precio, Subtotal) VALUES (@dniVendedor, @modelo, @descripcion, @cantidad, @precio, @subtotal)";

                            using (SqlCommand commandInsertar = new SqlCommand(queryInsertar, connection))
                            {
                                commandInsertar.Parameters.AddWithValue("@dniVendedor", dniVendedor);
                                commandInsertar.Parameters.AddWithValue("@modelo", producto.Modelo_Producto);
                                commandInsertar.Parameters.AddWithValue("@descripcion", producto.Nombre_Producto);
                                commandInsertar.Parameters.AddWithValue("@cantidad", cantidad);
                                commandInsertar.Parameters.AddWithValue("@precio", producto.Precio_Producto);
                                commandInsertar.Parameters.AddWithValue("@subtotal", subtotal);

                                commandInsertar.ExecuteNonQuery(); // Inserta el nuevo producto con el subtotal calculado
                                resultado = true; // El producto se agregó correctamente
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al agregar el producto al carrito: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error inesperado: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return resultado; // Devuelve el resultado de la operación
        }









        public class ProductoDatos
        {
            private string connectionString = @"Server=CELSOBRO\SQLEXPRESS;Database=TecnoPuntaBD;Trusted_Connection=True;";

            public Producto ObtenerProductoPorModelo(string modelo)
            {
                Producto producto = null;

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT Modelo, Nombre_Producto, Precio_Producto FROM Productos WHERE Modelo = @modelo";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@modelo", modelo);
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                producto = new Producto
                                {
                                    Modelo_Producto = reader["Modelo"].ToString(),
                                    Nombre_Producto = reader["Nombre_Producto"].ToString(),
                                    Precio_Producto = Convert.ToDecimal(reader["Precio_Producto"])
                                };
                            }
                        }
                    }
                }

                return producto;
            }
        }

        public bool eliminarProducto(string modelo, int dniVendedor)
        {
            return carritoDatos.EliminarProductoDelCarrito(dniVendedor, modelo);
        }

        public bool vaciarCarrito(int dniVendedor)
        {
            return carritoDatos.LimpiarCarrito(dniVendedor);
        }
    }
}
