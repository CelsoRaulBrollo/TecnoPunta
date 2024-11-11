using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.DTO
{
    public class CarritoDTO
    {
        public decimal total { get; set; }
        public List<CarritoDetalleDTO> detalles { get; set; }

        public CarritoDTO()
        {
            detalles = new List<CarritoDetalleDTO>();
        }


    }
}