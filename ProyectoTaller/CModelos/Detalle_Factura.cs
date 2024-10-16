using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CModelos
{
    public class Detalle_Factura
    {
        public int ID_Detalle { get; set; }
        public int Cantidad { get; set; }

        public decimal Subtotal { get; set; }
        public Producto Modelo { get; set; }
       
       
    }
}
