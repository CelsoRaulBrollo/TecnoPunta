
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
    public class CarritoDatos
    {
        private ConexionBD conexion = new ConexionBD();

        public CarritoM ObtenerCarrito(int dniVendedor)
        {
            CarritoM carrito = new CarritoM();

            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                string carritoQuery = "SELECT Total FROM Carrito WHERE DNI_Vendedor = @DNI_Vendedor";
                using (var command = new SqlCommand(carritoQuery, connection))
                {
                    command.Parameters.AddWithValue("@DNI_Vendedor", dniVendedor);
                    var reader = command.ExecuteReader();

                    if (reader.Read())
                    {
                        carrito.DNIVendedor = dniVendedor;
                        carrito.Total = reader.GetDecimal(reader.GetOrdinal("Total"));
                    }
                }

                //ahora agrego los producto del carrito utilizando la tabla intermedia carritodetalle 

                var detallesQuery = @"
                    SELECT 
                        cd.Cantidad, 
                        cd.SubTotal, 
                        p.Modelo_Producto, 
                        p.Nombre_Producto, 
                        p.Precio_Producto, 
                        p.SistemaOperativo_Producto, 
                        p.Almacenamiento_Producto, 
                        p.Ram_Producto, 
                        m.Id_Marca, 
                        m.Nombre_Marca, 
                        c.Id_Condicion, 
                        c.Descripcion_Condicion
                    FROM 
                        CarritoDetalle cd 
                    JOIN 
                        Productos p ON cd.Modelo_Producto = p.Modelo_Producto 
                    JOIN 
                        Marcas m ON p.Id_Marca = m.Id_Marca
                    JOIN 
                        Condicion c ON p.Id_Condicion = c.Id_Condicion
                    WHERE 
                        cd.DNI_Vendedor = @DNI_Vendedor";

                using (var command = new SqlCommand(detallesQuery, connection))
                {
                    command.Parameters.AddWithValue("@DNI_Vendedor", dniVendedor);
                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        var detalle = new DetalleCarrito
                        {
                            cantitad = Convert.ToInt32(reader["Cantidad"]),
                            Subtotal = Convert.ToDecimal(reader["SubTotal"]),
                            producto = new Producto
                            {
                                Modelo_Producto = reader["Modelo_Producto"].ToString(),
                                Nombre_Producto = reader["Nombre_Producto"].ToString(),
                                Precio_Producto = Convert.ToDecimal(reader["Precio_Producto"]),
                                SistemaOperativo_Producto = reader["SistemaOperativo_Producto"].ToString(),
                                Almacenamiento_Producto = reader["Almacenamiento_Producto"].ToString(),
                                Ram_Producto = reader["Ram_Producto"].ToString(),
                                Marca = new Marca
                                {
                                    Id_Marca = Convert.ToInt32(reader["Id_Marca"]),
                                    Nombre_Marca = reader["Nombre_Marca"].ToString()
                                },
                                Condicion = new Condicion
                                {
                                    Id_Condicion = Convert.ToInt32(reader["Id_Condicion"]),
                                    Descripcion_Condicion = reader["Descripcion_Condicion"].ToString()
                                }
                            }
                        };
                        carrito.Detalles.Add(detalle);
                    }
                }
            }

                return carrito;
        }

    }
}
