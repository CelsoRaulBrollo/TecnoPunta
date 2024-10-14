using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.DTO
{
    public class ProductoDTO
    {
        public string Modelo { get; set; }
        public string Nombre { get; set; }

        public string SistemaOperativo { get; set; }
        public string Almacenamiento { get; set; }
        public string Ram { get; set; }
        public int Stock { get; set; }
        public decimal Precio { get; set; }
        public string Marca { get; set; }
        public string Condicion {  get; set; }

    }
}
