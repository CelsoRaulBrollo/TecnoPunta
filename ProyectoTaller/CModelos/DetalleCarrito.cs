using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CModelos
{
    public class DetalleCarrito
    {
        public int cantitad {  get; set; }
        public decimal Subtotal { get; set; }
        public Producto producto { get; set; }
    }
}
