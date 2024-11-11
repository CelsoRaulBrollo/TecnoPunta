using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.DTO
{
    public class VentasPorAñoDTO
    {
        public int Año { get; set; }
        public decimal TotalVentas { get; set; }
        public int TotalCantidad { get; internal set; }
    }
}
