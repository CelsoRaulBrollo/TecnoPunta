using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ProyectoTaller.DTO
{
    public class VentasDTO
    {
        public int CodigoVenta { get; set; }
        public string Cliente { get; set; }
        public DateTime FechaDeFacturacion { get; set; }
        public string MetodoDePago { get; set; }
        public decimal Total { get; set; }
    }
}
