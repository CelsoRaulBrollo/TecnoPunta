using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CNegocio
{
    public class CondicionNegocio
    {
        private CondicionDatos CondicionDatos;


        public List<Condicion> ListarCondiciones()
        {
            CondicionDatos = new CondicionDatos();
            return CondicionDatos.ObtenerCondiciones();
        }

    }
}
