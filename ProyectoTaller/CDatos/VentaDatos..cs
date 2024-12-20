﻿using ProyectoTaller.CModelos;
using ProyectoTaller.DTO;
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

        public int registrarVenta( Venta venta)
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

                return idVenta;
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
                                vendedor = new Usuarios
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
                                vendedor = new Usuarios
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
                                vendedor = new Usuarios
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
                                vendedor = new Usuarios
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

        public List<VentasPorMesDTO> ObtenerVentasTotalesPorMes()
        {
            List<VentasPorMesDTO> ventasPorMes = new List<VentasPorMesDTO>();

                    string query = @"
                    SELECT 
                        YEAR(FechaVenta) AS Año,
                        MONTH(FechaVenta) AS Mes,
                        SUM(Total) AS Total_Ventas
                    FROM 
                        Venta
                    GROUP BY 
                        YEAR(FechaVenta),
                        MONTH(FechaVenta)
                    ORDER BY 
                        Año DESC, Mes DESC;
                ";

            
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                connection.Open(); 

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ventasPorMes.Add(new VentasPorMesDTO
                            {
                                Año = reader.GetInt32(0),
                                Mes = reader.GetInt32(1),
                                TotalVentas = reader.GetDecimal(2)
                            });
                        }
                    }
                }
            }

            return ventasPorMes;
        }

        public List<VentaInformeRecaudacionDTO> ObtenerVentasTotales()
        {
            List<VentaInformeRecaudacionDTO> ventas = new List<VentaInformeRecaudacionDTO>();

                 string query = @"
                            SELECT 
                                FechaVenta, 
                                Total
                            FROM Venta
                            ORDER BY FechaVenta;
                        ";

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        VentaInformeRecaudacionDTO venta = new VentaInformeRecaudacionDTO
                        {
                            FechaVenta = reader.GetDateTime(0), 
                            TotalVentas = reader.GetDecimal(1)  
                        };
                        ventas.Add(venta);
                    }
                }
            }

            return ventas;
        }


        public List<VentaInformeCantidadDTO> ObtenerVentasPorDia()
        {
            List<VentaInformeCantidadDTO> ventasPorDia = new List<VentaInformeCantidadDTO>();

            string query = @"
                                SELECT 
                                    CAST(v.FechaVenta AS DATE) AS Fecha, 
                                    SUM(vd.Cantidad) AS Cantidad          
                                FROM 
                                    Venta v
                                JOIN 
                                    VentaDetalle vd ON v.idVenta = vd.idVenta
                                GROUP BY 
                                    CAST(v.FechaVenta AS DATE)
                                ORDER BY 
                                    Fecha;
                            ";

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        VentaInformeCantidadDTO venta = new VentaInformeCantidadDTO
                        {
                            FechaVenta = reader.GetDateTime(0),  // Fecha ya sin hora
                            TotalCantidad = reader.GetInt32(1)   // Cantidad total de productos vendidos
                        };

                        ventasPorDia.Add(venta);
                    }
                }
            }

            return ventasPorDia;
        }


        public List<MarcaInformeDTO> ObtenerMarcasMasVendidasPorMes(int mes, int año)
        {
            List<MarcaInformeDTO> marcasVendidas = new List<MarcaInformeDTO>();

            // Consulta SQL para obtener la marca y la cantidad vendida por cada marca en el mes y año seleccionados
            string query = @"
                            SELECT 
                                m.Nombre_Marca, 
                                SUM(vd.Cantidad) AS TotalCantidad
                            FROM 
                                Venta v
                            JOIN 
                                VentaDetalle vd ON v.idVenta = vd.idVenta
                            JOIN 
                                Productos p ON vd.Producto = p.Modelo_Producto
                            JOIN 
                                Marcas m ON p.Id_Marca = m.Id_Marca
                            WHERE 
                                YEAR(v.FechaVenta) = @Año 
                                AND MONTH(v.FechaVenta) = @Mes
                            GROUP BY 
                                m.Nombre_Marca
                            ORDER BY 
                                TotalCantidad DESC;
                        ";

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Año", año);
                command.Parameters.AddWithValue("@Mes", mes);

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        MarcaInformeDTO marca = new MarcaInformeDTO
                        {
                            Marca = reader.GetString(0),
                            TotalVentas = reader.GetInt32(1)
                        };

                        marcasVendidas.Add(marca);
                    }
                }
            }

            return marcasVendidas;
        }

        public List<VentasMensualesPorMarcaDTO> ObtenerVentasMensualesPorMarca(int año)
        {
            List<VentasMensualesPorMarcaDTO> ventasMensualesPorMarca = new List<VentasMensualesPorMarcaDTO>();

                        
                        string query = @"
                    SELECT 
                        MONTH(v.FechaVenta) AS Mes,
                        p.Id_Marca,
                        m.Nombre_Marca,
                        SUM(vd.Cantidad) AS CantidadVendida
                    FROM 
                        Venta v
                    JOIN 
                        VentaDetalle vd ON v.idVenta = vd.idVenta
                    JOIN 
                        Productos p ON p.Modelo_Producto = vd.Producto
                    JOIN 
                        Marcas m ON m.Id_Marca = p.Id_Marca
                    WHERE 
                        YEAR(v.FechaVenta) = @Año
                    GROUP BY 
                        MONTH(v.FechaVenta), p.Id_Marca, m.Nombre_Marca
                    ORDER BY 
                        MONTH(v.FechaVenta), m.Nombre_Marca;
                ";

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Año", año);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ventasMensualesPorMarca.Add(new VentasMensualesPorMarcaDTO
                        {
                            Mes = reader.GetInt32(0),
                            IdMarca = reader.GetInt32(1),
                            NombreMarca = reader.GetString(2),
                            CantidadVendida = reader.GetInt32(3)
                        });
                    }
                }
            }

            return ventasMensualesPorMarca;
        }


        public List<VentaMensualPorClienteDTO> ObtenerVentaMediaPorClientePorMes(DateTime fechaInicio, DateTime fechaFin)
        {
            var ventasMensuales = new List<VentaMensualPorClienteDTO>();

            string query = @"
        SELECT 
            MONTH(v.FechaVenta) AS Mes,
            YEAR(v.FechaVenta) AS Año,
            SUM(v.Total) / COUNT(DISTINCT v.DNI_Cliente) AS VentaMediaPorCliente
        FROM 
            Venta v
        WHERE 
            v.FechaVenta BETWEEN @FechaInicio AND @FechaFin
        GROUP BY 
            YEAR(v.FechaVenta), MONTH(v.FechaVenta)
        ORDER BY 
            Año, Mes;
    ";

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(query, connection);
                cmd.Parameters.AddWithValue("@FechaInicio", fechaInicio);
                cmd.Parameters.AddWithValue("@FechaFin", fechaFin);
                connection.Open();

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        ventasMensuales.Add(new VentaMensualPorClienteDTO
                        {
                            Año = reader.GetInt32(1),  // Año
                            Mes = reader.GetInt32(0),  // Mes
                            VentaMediaPorCliente = reader.GetDecimal(2)  // Venta media por cliente
                        });
                    }
                }
            }

            return ventasMensuales;
        }
    }
}
