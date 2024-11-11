using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using ProyectoTaller.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CNegocio
{
    public class CarritoNegocio
    {
        private CarritoDatos carritoDatos;

        public CarritoDTO cargarCarito(int dniVendedor)
        {
            CarritoDTO carritoRespuesta = new CarritoDTO();
            carritoDatos = new CarritoDatos();

            CarritoM carrito = carritoDatos.ObtenerCarrito(dniVendedor);

            carritoRespuesta.total = carrito.Total;

            foreach (DetalleCarrito detalle in carrito.Detalles)
            {
                CarritoDetalleDTO detalleCarrito = new CarritoDetalleDTO();
                detalleCarrito.Modelo = detalle.producto.Modelo_Producto;
                detalleCarrito.precio = detalle.producto.Precio_Producto;
                detalleCarrito.cantidad = detalle.cantitad;
                detalleCarrito.Descripcion = "Nombre: " + detalle.producto.Nombre_Producto + " Sistema Operativo: " + detalle.producto.SistemaOperativo_Producto + " Ram: " + detalle.producto.Ram_Producto + " Almacenamiento: " + detalle.producto.Almacenamiento_Producto;
                carritoRespuesta.detalles.Add(detalleCarrito);
            }

            return carritoRespuesta;
        }

        public bool agregarProducto(string modelo, int dniVendedor)
        {
            carritoDatos = new CarritoDatos();
            return carritoDatos.AgregarProductoAlCarrito(dniVendedor, modelo);

        }

        public bool eliminarProducto(string Modelo, int dniVendedor)
        {
            carritoDatos = new CarritoDatos();
            return carritoDatos.EliminarProductoDelCarrito(dniVendedor, Modelo);
        }

        public bool vaciarCarrito(int dniVendedor)
        {
            carritoDatos = new CarritoDatos();
            return carritoDatos.LimpiarCarrito(dniVendedor);
        }

    }
}