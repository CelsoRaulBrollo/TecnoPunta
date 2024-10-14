using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CNegocio
{
    public class MarcaNegocio
    {
        private MarcaDatos MarcaDatos;


        public List<Marca> ListarMarca()
        {
            MarcaDatos = new MarcaDatos();
            return MarcaDatos.ObtenerMarcas();
        }
    }
}
