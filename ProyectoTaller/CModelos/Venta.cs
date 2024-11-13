using QuestPDF.Fluent;
using QuestPDF.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ProyectoTaller.CModelos
{
    public class Venta
    {
        public int idVenta { get; set; }
        public Usuarios vendedor { get; set; }
        public Clientes cliente { get; set; }
        public decimal total { get; set; }
        public MetodoDePagoModel metodoDePago { get; set; }
        public DateTime fechaDeVenta { get; set; }

        public List<VentaDetalle> detalles { get; set; }    
        
    }

        
   }

