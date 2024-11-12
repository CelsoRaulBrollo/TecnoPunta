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

        public List<VentasPorMesDTO> listarVentasPorMesAñoActual()
        {
            ventaDatos = new VentaDatos();
            return ventaDatos.ObtenerVentasTotalesPorMes();

        }

        public List<VentasPorAñoDTO> ObtenerVentasAnuales(DateTime desde, DateTime hasta)
        {
            ventaDatos = new VentaDatos();
            var todasLasVentas = ventaDatos.ObtenerVentasTotales(); 

            var ventasAnuales = todasLasVentas
                .Where(v => v.FechaVenta >= desde && v.FechaVenta <= hasta)  // Filtrar por el rango de fechas
                .GroupBy(v => v.FechaVenta.Year)  // Agrupar por año
                .Select(g => new VentasPorAñoDTO
                {
                    Año = g.Key,
                    TotalVentas = g.Sum(v => v.TotalVentas)  // Sumar ventas por año
                })
                .OrderBy(v => v.Año)
                .ToList();

            return ventasAnuales;
        }


        public List<VentasPorMesDTO> ObtenerVentasMensuales(DateTime desde, DateTime hasta)
        {
            ventaDatos = new VentaDatos();
            var todasLasVentas = ventaDatos.ObtenerVentasTotales();

            var ventasMensuales = todasLasVentas
                .Where(v => v.FechaVenta >= desde && v.FechaVenta <= hasta)  // Filtrar por el rango de fechas
                .GroupBy(v => new { v.FechaVenta.Year, v.FechaVenta.Month })  // Agrupar por año y mes
                .Select(g => new VentasPorMesDTO
                {
                    Año = g.Key.Year,
                    Mes = g.Key.Month,
                    MesNombre = g.First().FechaVenta.ToString("MMMM"),  // Nombre del mes
                    TotalVentas = g.Sum(v => v.TotalVentas)  // Sumar ventas por mes
                })
                .OrderBy(v => v.Año)  // Ordenar por año
                .ThenBy(v => v.Mes)   // Luego ordenar por mes
                .ToList();

            return ventasMensuales;
        }

        public List<VentasPorDiaDTO> ObtenerVentasDiarias(DateTime desde, DateTime hasta)
        {
            ventaDatos = new VentaDatos();
            var todasLasVentas = ventaDatos.ObtenerVentasTotales();

            var ventasDiarias = todasLasVentas
                .Where(v => v.FechaVenta >= desde && v.FechaVenta <= hasta)  // Filtrar por el rango de fechas
                .GroupBy(v => v.FechaVenta.Date)  // Agrupar por día
                .Select(g => new VentasPorDiaDTO
                {
                    Fecha = g.Key,
                    TotalVentas = g.Sum(v => v.TotalVentas)  // Sumar ventas por día
                })
                .OrderBy(v => v.Fecha)  // Ordenar por fecha
                .ToList();

            return ventasDiarias;
        }


        public List<VentasPorAñoDTO> ObtenerCantidadVentasAnuales(DateTime desde, DateTime hasta)
        {
            ventaDatos = new VentaDatos();
            var todasLasVentas = ventaDatos.ObtenerVentasPorDia();  // Obtener los datos de cantidad por día

            // Filtrar las ventas dentro del rango de fechas
            var ventasAnuales = todasLasVentas
                .Where(v => v.FechaVenta >= desde && v.FechaVenta <= hasta)  // Filtrar por el rango de fechas
                .GroupBy(v => v.FechaVenta.Year)  // Agrupar por año
                .Select(g => new VentasPorAñoDTO
                {
                    Año = g.Key,
                    TotalCantidad = g.Sum(v => v.TotalCantidad)  // Sumar las cantidades por año
                })
                .OrderBy(v => v.Año)
                .ToList();

            return ventasAnuales;
        }

        public List<VentasPorMesDTO> ObtenerCantidadVentasMensuales(DateTime desde, DateTime hasta)
        {
            ventaDatos = new VentaDatos();
            var todasLasVentas = ventaDatos.ObtenerVentasPorDia();  // Obtener los datos de cantidad por día

            var ventasMensuales = todasLasVentas
                .Where(v => v.FechaVenta >= desde && v.FechaVenta <= hasta)  // Filtrar por el rango de fechas
                .GroupBy(v => new { v.FechaVenta.Year, v.FechaVenta.Month })  // Agrupar por año y mes
                .Select(g => new VentasPorMesDTO
                {
                    Año = g.Key.Year,
                    Mes = g.Key.Month,
                    MesNombre = g.First().FechaVenta.ToString("MMMM"),  // Nombre del mes
                    TotalCantidad = g.Sum(v => v.TotalCantidad)  // Sumar las cantidades por mes
                })
                .OrderBy(v => v.Año)  // Ordenar por año
                .ThenBy(v => v.Mes)   // Luego ordenar por mes
                .ToList();

            return ventasMensuales;
        }

        public List<VentasPorDiaDTO> ObtenerCantidadVentasDiarias(DateTime desde, DateTime hasta)
        {
            ventaDatos = new VentaDatos();
            var todasLasVentas = ventaDatos.ObtenerVentasPorDia();  // Obtener los datos de cantidad por día

            var ventasDiarias = todasLasVentas
                .Where(v => v.FechaVenta >= desde && v.FechaVenta <= hasta)  // Filtrar por el rango de fechas
                .GroupBy(v => v.FechaVenta.Date)  // Agrupar por fecha (día)
                .Select(g => new VentasPorDiaDTO
                {
                    Fecha = g.Key,
                    TotalCantidad = g.Sum(v => v.TotalCantidad)  // Sumar las cantidades por día
                })
                .OrderBy(v => v.Fecha)  // Ordenar por fecha
                .ToList();

            return ventasDiarias;
        }


        public List<MarcaInformeDTO> ObtenerMarcasMasVendidasPorMes(int mes, int año)
        {
            VentaDatos ventaDatos = new VentaDatos();
            return ventaDatos.ObtenerMarcasMasVendidasPorMes(mes, año);
        }

        public List<VentasMensualesPorMarcaDTO> ObtenerVentasMensualesPorMarca(int año)
        {
            VentaDatos ventaDatos = new VentaDatos();
            return ventaDatos.ObtenerVentasMensualesPorMarca(año);
        }


        public List<VentasMensualesPorMarcaDTO> ObtenerVentasMensualesPorMarca(string nombreMarca, int año)
        {
           
            List<VentasMensualesPorMarcaDTO> ventasMensualesPorMarca = ventaDatos.ObtenerVentasMensualesPorMarca(año);

           
            if (!string.IsNullOrEmpty(nombreMarca))
            {
                
                ventasMensualesPorMarca = ventasMensualesPorMarca
                    .Where(v => v.NombreMarca.Equals(nombreMarca, StringComparison.OrdinalIgnoreCase))
                    .ToList();
            }

            return ventasMensualesPorMarca;
        }


        public List<VentaMensualPorClienteDTO> ObtenerVentaMediaPorClientePorMes(DateTime fechaInicio, DateTime fechaFin)
        {
            ventaDatos = new VentaDatos();
            return ventaDatos.ObtenerVentaMediaPorClientePorMes(fechaInicio, fechaFin);
        }

        public List<VentasAdmDTO> ObtenerVentasPorRangoDeFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            ventaDatos = new VentaDatos();
            List<VentasAdmDTO> ventasDTO = new List<VentasAdmDTO>();

            
            foreach (Venta venta in ventaDatos.BuscarTodasLasVentas())
            {
                if (venta.fechaDeVenta >= fechaInicio && venta.fechaDeVenta <= fechaFin)
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
            }

            return ventasDTO;
        }
    }
}
