using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CNegocio
{
    public class RolNegocio
    {
        private RolDatos rolDatos;

        public List<Rol> ListarRoles()
        {
            rolDatos = new RolDatos();
            return rolDatos.ObtenerRoles();
        }

        public int buscarIDRolPorDescripcion(string descripcion)
        {
            rolDatos = new RolDatos();
            return rolDatos.buscarIDRolPorDescripcion(descripcion);
        }

    }
}
