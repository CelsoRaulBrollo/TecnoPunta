using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using ProyectoTaller.DTO;
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

        public string buscarDescripcionporID(int buscarID)
        {
            string respuesta = null;
            rolDatos = new RolDatos();
            foreach (Rol rol in rolDatos.ObtenerRoles()) {
                if (rol.Id_Rol == buscarID) {

                    respuesta = rol.Descripcion_Rol;
                    break;

                }
            }

            return respuesta;
        }

        public int buscarIDRolPorDescripcion(string descripcion)
        {
            rolDatos = new RolDatos();
            return rolDatos.buscarIDRolPorDescripcion(descripcion);
        }

        public List<RolDTO> generarInfomreUsuario(DateTime desde, DateTime hasta)
        {
            rolDatos = new RolDatos();
            return rolDatos.generarInfomreUsuario(desde, hasta);    
        }

    }
}
