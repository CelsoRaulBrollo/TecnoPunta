using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using ProyectoTaller.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using static ProyectoTaller.Views.Vendedor.AgregarCliente;

namespace ProyectoTaller.CNegocio
{
    public class VentaNegocio
    {
        private VentaDatos ventaDatos;
        private ClienteNegocio clienteNegocio;
        private UsuarioNegocio usarioNegocio;
        private ProductoNegocio productoNegocio;
        private MetodoDePagoNegocio metodoNegocio;

        public int rigistrarVenta(CarritoDTO carritoRegistrar,int idMetodoDePago, int dniCliente, int dniVendedor)
        {
            clienteNegocio = new ClienteNegocio();
            Clientes clientee = clienteNegocio.buscarCliente(dniCliente);

            usarioNegocio = new UsuarioNegocio();
            Usuario usuario = usarioNegocio.buscarUsuarioByDNI(dniVendedor);
            ventaDatos = new VentaDatos();

            metodoNegocio = new MetodoDePagoNegocio();

            Venta venta = new Venta
            {
                metodoDePago = metodoNegocio.buscarMetodoDePago(idMetodoDePago),
                vendedor = usuario,
                cliente = clientee,
                total = carritoRegistrar.total,
                detalles = new List<VentaDetalle>(),

            };

            productoNegocio = new ProductoNegocio();
            foreach (CarritoDetalleDTO detalle in carritoRegistrar.detalles)
            {
                VentaDetalle ventaDetalle = new VentaDetalle();
                ventaDetalle.cantidad = detalle.cantidad;
                ventaDetalle.producto = productoNegocio.buscarProductoBYID(detalle.Modelo);
                ventaDetalle.subtotal = detalle.cantidad * productoNegocio.buscarProductoBYID(detalle.Modelo).Precio_Producto;

                venta.detalles.Add(ventaDetalle);
            };



            return ventaDatos.registrarVenta(venta);
        }

        public List<VentasDTO> buscarVentaPorVendedor(int dniVendedor)
        {
            ventaDatos = new VentaDatos();
            List<VentasDTO> ventasDTO = new List<VentasDTO>();
            foreach (Venta venta in ventaDatos.BuscarVentasDeUnVendedor(dniVendedor))
            {
                VentasDTO ventaDTO = new VentasDTO
                {
                    CodigoVenta = venta.idVenta,
                    Cliente = venta.cliente.Nombre_Cliente + " " + venta.cliente.Apellido_Cliente,
                    FechaDeFacturacion = venta.fechaDeVenta,
                    MetodoDePago = venta.metodoDePago.nombre,
                    Total = venta.total,
                };
                ventasDTO.Add(ventaDTO);
            }



            return ventasDTO;
        }

        public int cantidadDeVentasDelDia(int dniVendedor)
        {

            ventaDatos = new VentaDatos();
            return ventaDatos.ObtenerVentasDelDia( dniVendedor).Count;
        }

        public decimal montoRecaudadoDelDia(int dniVendedor)
        {
            decimal totalRecaudado = 0;
            ventaDatos = new VentaDatos();

            foreach (var venta in ventaDatos.ObtenerVentasDelDia(dniVendedor))
            {
                totalRecaudado += venta.total; 
            }
            
            return totalRecaudado;
        }

        public List<VentasAdmDTO> obtenerTodasLasVentas()
        {
            ventaDatos = new VentaDatos();
            List<VentasAdmDTO> ventasDTO = new List<VentasAdmDTO>();
            foreach (Venta venta in ventaDatos.BuscarTodasLasVentas())
            {
                VentasAdmDTO ventaDTO = new VentasAdmDTO
                {
                    CodigoVenta = venta.idVenta,
                    Cliente = venta.cliente.Nombre_Cliente + " " + venta.cliente.Apellido_Cliente,
                    Vendedor = venta.vendedor.Nombre_Usuario + " " + venta.vendedor.Apellido_Usuario,
                    FechaDeFacturacion = venta.fechaDeVenta,
                    MetodoDePago = venta.metodoDePago.nombre,
                    Total = venta.total,
                };
                ventasDTO.Add(ventaDTO);
            }



            return ventasDTO;

        }

        public Venta buscarVentaPorId(int idVenta)
        {
            ventaDatos = new VentaDatos();
            return ventaDatos.BuscarVentaPorId(idVenta);
        }

    }
}
