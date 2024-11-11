using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CNegocio
{
    public class MetodoDePagoNegocio
    {
        private MetodoDePagoDatos metodoDePago;

        public MetodoDePagoModel buscarMetodoDePago(int id)
        {
            metodoDePago = new MetodoDePagoDatos();
            return metodoDePago.BuscarMetodoDePagoPorId(id);
        }
    }
}
