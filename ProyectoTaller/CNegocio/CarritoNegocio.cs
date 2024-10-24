using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using ProyectoTaller.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CNegocio
{
    public class CarritoNegocio
    {
        private CarritoDatos carritoDatos;

        public CarritoDTO cargarCarito(int dniVendedor)
        {
            CarritoDTO carritoRespuesta = new CarritoDTO();
            carritoDatos = new CarritoDatos();



            return carritoRespuesta;
        }

    }
}
