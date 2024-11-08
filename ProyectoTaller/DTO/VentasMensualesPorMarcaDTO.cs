using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.DTO
{
    public class VentasMensualesPorMarcaDTO
    {
        public int Mes { get; set; }
        public int IdMarca { get; set; }
        public string NombreMarca { get; set; }
        public int CantidadVendida { get; set; }
    }
}
