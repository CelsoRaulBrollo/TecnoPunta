using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.DTO
{
    public class CarritoDetalleDTO
    {
        public string Modelo { get; set; }
        public string Descripcion { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
    }
}