using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CModelos
{
    public class CarritoM
    {
        public int DNIVendedor { get; set; }
        public decimal Total { get; set; }
        public List<DetalleCarrito> Detalles {  get; set; }
    }
}
