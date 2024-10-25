﻿
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
                connection.Open();

                // Obtener el total del carrito
                string carritoQuery = "SELECT Total FROM Carrito WHERE DNI_Vendedor = @DNI_Vendedor";
                using (var command = new SqlCommand(carritoQuery, connection))
                {
                    command.Parameters.AddWithValue("@DNI_Vendedor", dniVendedor);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            carrito.DNIVendedor = dniVendedor;
                            carrito.Total = reader.GetDecimal(reader.GetOrdinal("Total"));
                        }
                    }
                }

                // Ahora agrego los productos del carrito utilizando la tabla intermedia CarritoDetalle 
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
                    c.Descripcion_Estado
                FROM 
                    CarritoDetalle cd 
                JOIN 
                    Productos p ON cd.Producto = p.Modelo_Producto 
                JOIN 
                    Marcas m ON p.Id_Marca = m.Id_Marca
                JOIN 
                    Condicion c ON p.Id_Condicion = c.Id_Condicion
                WHERE 
                    cd.DNI_Vendedor = @DNI_Vendedor";

                using (var command = new SqlCommand(detallesQuery, connection))
                {
                    command.Parameters.AddWithValue("@DNI_Vendedor", dniVendedor);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            DetalleCarrito detalle = new DetalleCarrito
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
                                        Descripcion_Condicion = reader["Descripcion_Estado"].ToString()
                                    }
                                }
                            };
                            carrito.Detalles.Add(detalle);
                        }
                    }
                }
            }

            return carrito;
        }

        public bool AgregarProductoAlCarrito(int dniVendedor, string modeloProducto)
        {
            //Breve explicacion
            //En este algoritmo, primero voy a buscar si existe alguno producto con el mismo modelo en el carrito
            //Si existe le agrego UNA unidad
            //De lo contrario, creo un registro, es decir, agrego un producto y una unidad.
            //Luego modifico la tabla producto para mantener coherencia 
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                connection.Open();

                //Consulto si hay producto con modelo que ingreso como parametro  y obtengo su cantidad
                string checkQuery = @"
                                SELECT Cantidad 
                                FROM CarritoDetalle 
                                WHERE DNI_Vendedor = @DNI_Vendedor AND Producto = @Modelo_Producto";

                int cantidadExistente = -1; // Varible Bandera

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@DNI_Vendedor", dniVendedor);
                    checkCmd.Parameters.AddWithValue("@Modelo_Producto", modeloProducto);

                    using (SqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cantidadExistente = Convert.ToInt32(reader["Cantidad"]); 
                        }
                    }
                }

                // Si el producto ya existe en el carrito, actualizar la cantidad y agrego UNA unidad. 
                //De lo contrario se agrega un nuevo registro a la tabla carritodetalle y se le asigna UNA unidad.
                if (cantidadExistente != -1)
                {
                    // Incrementar la cantidad en 1 unidad
                    string updateQuantityQuery = @"
                        UPDATE CarritoDetalle 
                        SET Cantidad = Cantidad + 1, SubTotal = Cantidad * (SELECT Precio_Producto FROM Productos WHERE Modelo_Producto = @Modelo_Producto)
                        WHERE DNI_Vendedor = @DNI_Vendedor AND Producto = @Modelo_Producto";

                    using (SqlCommand updateCmd = new SqlCommand(updateQuantityQuery, connection))
                    {
                        updateCmd.Parameters.AddWithValue("@DNI_Vendedor", dniVendedor);
                        updateCmd.Parameters.AddWithValue("@Modelo_Producto", modeloProducto);
                        updateCmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    //Si el producto no está en el carrito, se lo agrega y se le asigna una unidad
                    string insertQuery = @"
                        INSERT INTO CarritoDetalle (Cantidad, SubTotal, DNI_Vendedor, Producto)
                        VALUES (1, (SELECT Precio_Producto FROM Productos WHERE Modelo_Producto = @Modelo_Producto), @DNI_Vendedor, @Modelo_Producto)";

                    using (SqlCommand insertCmd = new SqlCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@Modelo_Producto", modeloProducto);
                        insertCmd.Parameters.AddWithValue("@DNI_Vendedor", dniVendedor);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                // Actualiza la tabla producto.
                string updateStockQuery = @"
                                UPDATE Productos 
                                SET Stock_Producto = Stock_Producto - 1 
                                WHERE Modelo_Producto = @Modelo_Producto AND Stock_Producto > 0";

                using (SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, connection))
                {
                    updateStockCmd.Parameters.AddWithValue("@Modelo_Producto", modeloProducto);
                    int rowsAffected = updateStockCmd.ExecuteNonQuery();

                    
                }

                return true;
            }
        }


        public bool EliminarProductoDelCarrito(int dniVendedor, string modeloProducto)
        {

            //El algoritmo es el mismo al anterior, ahora RESTO UNA UNIDAD.
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                connection.Open();

                
                string checkQuery = @"
                            SELECT Cantidad 
                            FROM CarritoDetalle 
                            WHERE DNI_Vendedor = @DNI_Vendedor AND Producto = @Modelo_Producto";

                int cantidadExistente = -1;

                using (SqlCommand checkCmd = new SqlCommand(checkQuery, connection))
                {
                    checkCmd.Parameters.AddWithValue("@DNI_Vendedor", dniVendedor);
                    checkCmd.Parameters.AddWithValue("@Modelo_Producto", modeloProducto);

                    using (SqlDataReader reader = checkCmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            cantidadExistente = Convert.ToInt32(reader["Cantidad"]);
                        }
                    }
                }

             
                if (cantidadExistente != -1)
                {
                    if (cantidadExistente > 1)
                    {
                     
                        string updateQuantityQuery = @"
                                    UPDATE CarritoDetalle 
                                    SET Cantidad = Cantidad - 1, SubTotal = Cantidad * (SELECT Precio_Producto FROM Productos WHERE Modelo_Producto = @Modelo_Producto)
                                    WHERE DNI_Vendedor = @DNI_Vendedor AND Producto = @Modelo_Producto";

                        using (SqlCommand updateCmd = new SqlCommand(updateQuantityQuery, connection))
                        {
                            updateCmd.Parameters.AddWithValue("@DNI_Vendedor", dniVendedor);
                            updateCmd.Parameters.AddWithValue("@Modelo_Producto", modeloProducto);
                            updateCmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        //Como es es la ultima unidad, se borra el producto en el carrito. 
                        string deleteQuery = @"
                                DELETE FROM CarritoDetalle 
                                WHERE DNI_Vendedor = @DNI_Vendedor AND Producto = @Modelo_Producto";

                        using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection))
                        {
                            deleteCmd.Parameters.AddWithValue("@DNI_Vendedor", dniVendedor);
                            deleteCmd.Parameters.AddWithValue("@Modelo_Producto", modeloProducto);
                            deleteCmd.ExecuteNonQuery();
                        }
                    }

                    //Actualizo la tabla producto. Agrego una unidad.
                    string updateStockQuery = @"
                                UPDATE Productos 
                                SET Stock_Producto = Stock_Producto + 1 
                                WHERE Modelo_Producto = @Modelo_Producto";

                    using (SqlCommand updateStockCmd = new SqlCommand(updateStockQuery, connection))
                    {
                        updateStockCmd.Parameters.AddWithValue("@Modelo_Producto", modeloProducto);
                        updateStockCmd.ExecuteNonQuery();
                    }
                }

                return true; 
            }
        }

        public bool LimpiarCarrito(int dniVendedor)
        {
            using (SqlConnection connection = conexion.ObtenerConexion())
            {
                connection.Open();

                string deleteQuery = @"
                        DELETE FROM CarritoDetalle 
                        WHERE DNI_Vendedor = @DNI_Vendedor";

                using (SqlCommand deleteCmd = new SqlCommand(deleteQuery, connection))
                {
                    deleteCmd.Parameters.AddWithValue("@DNI_Vendedor", dniVendedor);
                    int rowsAffected = deleteCmd.ExecuteNonQuery();
                    return rowsAffected > 0; 
                }
            }
        }



    }
}
