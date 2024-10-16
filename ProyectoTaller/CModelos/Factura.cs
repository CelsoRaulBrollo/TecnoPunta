using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CModelos
{
    public class Factura
    {
        public int ID_Factura { get; set; }
        public Clientes Cliente { get; set; }
        public Usuario Vendedor { get; set; }
        public DateTime FechaFacturacion { get; set; }
        public MetodoDePago MetodoDePago { get; set; }
        public int Total { get; set; }
    }
}
