using ProyectoTaller.CModelos;
using ProyectoTaller.Views.Vendedor;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CDatos
{
    public class VentaDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public void registrarVenta( Venta venta)
        {
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                connection.Open();
                string insertVentaQuery = @"
                INSERT INTO Venta (DNI_Vendedor, DNI_Cliente, Total, Id_MetodoDePago) 
                VALUES (@DNI_Vendedor, @DNI_Cliente, @Total, @Id_MetodoDePago );
                SELECT SCOPE_IDENTITY();";

                var command = new SqlCommand(insertVentaQuery, connection);
                command.Parameters.AddWithValue("@DNI_Vendedor", venta.vendedor.DNI_Usuario);
                command.Parameters.AddWithValue("@DNI_Cliente", venta.cliente.DNI_Cliente);
                command.Parameters.AddWithValue("@Total", venta.total);
                command.Parameters.AddWithValue("@Id_MetodoDePago", venta.metodoDePago.id_MetodoDePago);


                var idVenta = Convert.ToInt32(command.ExecuteScalar());

                // Insertar los detalles de la venta
                foreach (var detalle in venta.detalles)
                {
                    string insertDetalleQuery = @"
                    INSERT INTO VentaDetalle (idVenta, Cantidad, SubTotal, Producto) 
                    VALUES (@idVenta, @Cantidad, @SubTotal, @Producto)";

                    var detalleCommand = new SqlCommand(insertDetalleQuery, connection);
                    detalleCommand.Parameters.AddWithValue("@idVenta", idVenta);
                    detalleCommand.Parameters.AddWithValue("@Cantidad", detalle.cantidad);
                    detalleCommand.Parameters.AddWithValue("@SubTotal", detalle.subtotal);
                    detalleCommand.Parameters.AddWithValue("@Producto", detalle.producto.Modelo_Producto);

                    detalleCommand.ExecuteNonQuery();
                }
                string updateCarritoQuery = @"
                    UPDATE Carrito
                    SET Total = 0 
                    WHERE DNI_Vendedor = @DNI_Vendedor";

                var updateCommand = new SqlCommand(updateCarritoQuery, connection);
                updateCommand.Parameters.AddWithValue("@DNI_Vendedor", venta.vendedor.DNI_Usuario);
                updateCommand.ExecuteNonQuery();

                string deleteCarritoQuery = @"
                    DELETE FROM CarritoDetalle 
                    WHERE DNI_Vendedor = @DNI_Vendedor";

                var deleteCommand = new SqlCommand(deleteCarritoQuery, connection);
                deleteCommand.Parameters.AddWithValue("@DNI_Vendedor", venta.vendedor.DNI_Usuario);
                deleteCommand.ExecuteNonQuery();

               
            }
        }

        public List<Venta> BuscarVentasDeUnVendedor(int dniVendedor)
        {
            List<Venta> ventas = new List<Venta>();

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                connection.Open();

                string query = @"
                    SELECT *
                        FROM Venta v
                        JOIN Usuarios u ON v.DNI_Vendedor = u.DNI_Usuario
                        JOIN Clientes c ON v.DNI_Cliente = c.DNI_Cliente
                        JOIN MetodoDePago mp ON v.Id_MetodoDePago = mp.Id_MetodoDePago
                        WHERE v.DNI_Vendedor = @DNI_Vendedor";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@DNI_Vendedor", dniVendedor);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Venta venta = new Venta
                            {
                                idVenta = Convert.ToInt32(reader["idVenta"]),
                                total = Convert.ToDecimal(reader["Total"]),
                                fechaDeVenta = Convert.ToDateTime(reader["FechaVenta"]),
                                vendedor = new Usuario
                                {
                                    DNI_Usuario = Convert.ToInt32(reader["DNI_Usuario"]),
                                    Nombre_Usuario = reader["Nombre_Usuario"].ToString(),
                                    Apellido_Usuario = reader["Apellido_Usuario"].ToString(),
                                
                                },
                                cliente = new Clientes
                                {
                                    DNI_Cliente = Convert.ToInt32(reader["DNI_Cliente"]),
                                    Nombre_Cliente = reader["Nombre_Cliente"].ToString(),
                                    Apellido_Cliente = reader["Apellido_Cliente"].ToString(),
                                    Telefono_Cliente = reader["Telefono_Cliente"].ToString(),
                                    Correo_Cliente = reader["Correo_Cliente"].ToString(),
                                    Direccion_Cliente = reader["Direccion_Cliente"].ToString()
                                },
                                metodoDePago = new MetodoDePagoModel
                                {
                                    id_MetodoDePago = Convert.ToInt32(reader["Id_MetodoDePago"]),
                                    nombre = reader["Descripcion_MetodoDePago"].ToString(),
                                  
                                }
                            };
                            ventas.Add(venta);
                        }
                    }
                }
            }

            return ventas;
        }

        public List<Venta> ObtenerVentasDelDia(int dniVendedor)
        {
            List<Venta> ventas = new List<Venta>();

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                connection.Open();

               
                DateTime fechaActual = DateTime.Now;

                string query = @"
                        SELECT v.*, 
                               u.*, 
                               c.*, 
                               mp.* 
                        FROM Venta v
                        JOIN Usuarios u ON v.DNI_Vendedor = u.DNI_Usuario
                        JOIN Clientes c ON v.DNI_Cliente = c.DNI_Cliente
                        JOIN MetodoDePago mp ON v.Id_MetodoDePago = mp.Id_MetodoDePago
                        WHERE CAST(v.FechaVenta AS DATE) = @FechaVenta AND v.DNI_Vendedor = @DNI_Vendedor";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    
                    command.Parameters.AddWithValue("@FechaVenta", fechaActual.Date);
                    command.Parameters.AddWithValue("@DNI_Vendedor", dniVendedor);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Venta venta = new Venta
                            {
                                idVenta = Convert.ToInt32(reader["idVenta"]),
                                total = Convert.ToDecimal(reader["Total"]),
                                fechaDeVenta = Convert.ToDateTime(reader["FechaVenta"]),
                                vendedor = new Usuario
                                {
                                    DNI_Usuario = Convert.ToInt32(reader["DNI_Usuario"]),
                                    Nombre_Usuario = reader["Nombre_Usuario"].ToString(),
                                    Apellido_Usuario = reader["Apellido_Usuario"].ToString()
                                },
                                cliente = new Clientes
                                {
                                    DNI_Cliente = Convert.ToInt32(reader["DNI_Cliente"]),
                                    Nombre_Cliente = reader["Nombre_Cliente"].ToString(),
                                    Apellido_Cliente = reader["Apellido_Cliente"].ToString()
                                },
                                metodoDePago = new MetodoDePagoModel
                                {
                                    id_MetodoDePago = Convert.ToInt32(reader["Id_MetodoDePago"]),
                                    nombre = reader["Descripcion_MetodoDePago"].ToString()
                                }
                            };

                            ventas.Add(venta);
                        }
                    }
                }
            }

            return ventas;
        }

        public List<Venta> BuscarTodasLasVentas()
        {
            List<Venta> ventas = new List<Venta>();

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                connection.Open();

                string query = @"
                    SELECT *
                        FROM Venta v
                        JOIN Usuarios u ON v.DNI_Vendedor = u.DNI_Usuario
                        JOIN Clientes c ON v.DNI_Cliente = c.DNI_Cliente
                        JOIN MetodoDePago mp ON v.Id_MetodoDePago = mp.Id_MetodoDePago
                        ";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Venta venta = new Venta
                            {
                                idVenta = Convert.ToInt32(reader["idVenta"]),
                                total = Convert.ToDecimal(reader["Total"]),
                                fechaDeVenta = Convert.ToDateTime(reader["FechaVenta"]),
                                vendedor = new Usuario
                                {
                                    DNI_Usuario = Convert.ToInt32(reader["DNI_Usuario"]),
                                    Nombre_Usuario = reader["Nombre_Usuario"].ToString(),
                                    Apellido_Usuario = reader["Apellido_Usuario"].ToString(),

                                },
                                cliente = new Clientes
                                {
                                    DNI_Cliente = Convert.ToInt32(reader["DNI_Cliente"]),
                                    Nombre_Cliente = reader["Nombre_Cliente"].ToString(),
                                    Apellido_Cliente = reader["Apellido_Cliente"].ToString(),
                                    Telefono_Cliente = reader["Telefono_Cliente"].ToString(),
                                    Correo_Cliente = reader["Correo_Cliente"].ToString(),
                                    Direccion_Cliente = reader["Direccion_Cliente"].ToString()
                                },
                                metodoDePago = new MetodoDePagoModel
                                {
                                    id_MetodoDePago = Convert.ToInt32(reader["Id_MetodoDePago"]),
                                    nombre = reader["Descripcion_MetodoDePago"].ToString(),

                                }
                            };
                            ventas.Add(venta);
                        }
                    }
                }
            }

            return ventas;
        }
        public Venta BuscarVentaPorId(int idVenta)
        {
            Venta venta = null;

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                connection.Open();

                string query = @"
                            SELECT v.*, 
                                   u.*, 
                                   c.*, 
                                   mp.*, 
                                   vd.SubTotal AS SubtotalDetalle,
                                   vd.Cantidad AS CantidadDetalle,
                                   p.Modelo_Producto, 
                                   p.Nombre_Producto, 
                                   p.SistemaOperativo_Producto, 
                                   p.Almacenamiento_Producto, 
                                   p.Ram_Producto
                            FROM Venta v
                            JOIN Usuarios u ON v.DNI_Vendedor = u.DNI_Usuario
                            JOIN Clientes c ON v.DNI_Cliente = c.DNI_Cliente
                            JOIN MetodoDePago mp ON v.Id_MetodoDePago = mp.Id_MetodoDePago
                            LEFT JOIN VentaDetalle vd ON v.idVenta = vd.idVenta
                            LEFT JOIN Productos p ON vd.Producto = p.Modelo_Producto
                            WHERE v.idVenta = @idVenta";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@idVenta", idVenta);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read()) // Solo leer una vez
                        {
                            venta = new Venta
                            {
                                idVenta = Convert.ToInt32(reader["idVenta"]),
                                total = Convert.ToDecimal(reader["Total"]),
                                fechaDeVenta = Convert.ToDateTime(reader["FechaVenta"]),
                                vendedor = new Usuario
                                {
                                    DNI_Usuario = Convert.ToInt32(reader["DNI_Usuario"]),
                                    Nombre_Usuario = reader["Nombre_Usuario"].ToString(),
                                    Apellido_Usuario = reader["Apellido_Usuario"].ToString(),
                                },
                                cliente = new Clientes
                                {
                                    DNI_Cliente = Convert.ToInt32(reader["DNI_Cliente"]),
                                    Nombre_Cliente = reader["Nombre_Cliente"].ToString(),
                                    Apellido_Cliente = reader["Apellido_Cliente"].ToString(),
                                    Telefono_Cliente = reader["Telefono_Cliente"].ToString(),
                                    Correo_Cliente = reader["Correo_Cliente"].ToString(),
                                    Direccion_Cliente = reader["Direccion_Cliente"].ToString()
                                },
                                metodoDePago = new MetodoDePagoModel
                                {
                                    id_MetodoDePago = Convert.ToInt32(reader["Id_MetodoDePago"]),
                                    nombre = reader["Descripcion_MetodoDePago"].ToString(),
                                },
                                detalles = new List<VentaDetalle>() // Inicializa la lista aquí
                            };

                            do
                            {
                                // Asegúrate de que no haya valores nulos
                                if (!reader.IsDBNull(reader.GetOrdinal("SubtotalDetalle")))
                                {
                                    var detalle = new VentaDetalle
                                    {
                                        subtotal = Convert.ToDecimal(reader["SubtotalDetalle"]),
                                        cantidad = Convert.ToInt32(reader["CantidadDetalle"]),
                                        producto = new Producto
                                        {
                                            Modelo_Producto = reader["Modelo_Producto"].ToString(),
                                            Nombre_Producto = reader["Nombre_Producto"].ToString(),
                                            SistemaOperativo_Producto = reader["SistemaOperativo_Producto"].ToString(),
                                            Almacenamiento_Producto = reader["Almacenamiento_Producto"].ToString(),
                                            Ram_Producto = reader["Ram_Producto"].ToString()
                                        }
                                    };

                                    venta.detalles.Add(detalle); 
                                }
                            } while (reader.Read());
                        }
                    }
                }
            }

            return venta;
        }
    }
}
