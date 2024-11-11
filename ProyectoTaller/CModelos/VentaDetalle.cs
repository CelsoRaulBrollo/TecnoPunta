using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CModelos
{
    public class VentaDetalle
    {
        public decimal subtotal { get; set; }
        public int cantidad {  get; set; }
        public Producto producto { get; set; }
       
    }
}
