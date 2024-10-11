using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CNegocio
{
    public class SexoNegocio
    {

        private SexoDato datos;

        public List<Sexo> ListarSexo()
        {
            datos = new SexoDato();
            return datos.ObtenerSexo();
        }

        public int buscarIDSexoPorDescripcion(string descripcion)
        {
            datos = new SexoDato();
            return datos.buscarIDSexoPorDescripcion(descripcion);
        }
    }
}
