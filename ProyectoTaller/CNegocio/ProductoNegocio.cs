using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using ProyectoTaller.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CNegocio
{
    public class ProductoNegocio
    {
        private ProductoDatos productosDatos;
        public List<ProductoDTO> listarProductos() { 
            List<ProductoDTO> listaProductos = new List<ProductoDTO>();
            productosDatos = new ProductoDatos();

            foreach (var p in productosDatos.ObtenerProductos())
            {
                ProductoDTO productoDTO = new ProductoDTO
                {
                    Modelo = p.Modelo_Producto,
                    Nombre = p.Nombre_Producto,
                    SistemaOperativo = p.SistemaOperativo_Producto,
                    Almacenamiento = p.Almacenamiento_Producto,
                    Ram = p.Ram_Producto,
                    Precio = p.Precio_Producto,
                    Stock = p.Stock_Producto,
                    Marca = p.Marca?.Nombre_Marca,
                    Condicion = p.Condicion?.Descripcion_Condicion
                };

                listaProductos.Add(productoDTO); 
            }

            return listaProductos;

        }

        public void actualizarProducto(Producto producto)
        {
            productosDatos = new ProductoDatos();
            productosDatos.ActualizarProducto(producto);   

        }

        public void guardarProducto(Producto producto)
        {
            productosDatos = new ProductoDatos();
            productosDatos.guardarProducto(producto);
            
        }

        public Producto buscarProductoBYID(string modelo)
        {
            productosDatos = new ProductoDatos();
            return productosDatos.buscarProductoByID(modelo);
        }
    }
}
