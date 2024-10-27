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
   
    public class UsuarioNegocio
    {
        private UsuarioDatos usuarioDatos;

        public Usuario autenticacion(string nombreUsuario, string contraseña)
        {
            usuarioDatos = new UsuarioDatos();
            return usuarioDatos.autenticacion(nombreUsuario, contraseña);
        }

        public DataTable ListarUsuarios()
        {
            usuarioDatos = new UsuarioDatos();
           
            return usuarioDatos.ListarUsuario();
        }

        public bool EditarUsuario(Usuario usuario)
        {
            usuarioDatos = new UsuarioDatos();
            return usuarioDatos.ActualizarUsuario(usuario);
        }

        public void GuardarUsuario(Usuario usuario) {
            usuarioDatos = new UsuarioDatos();

            usuarioDatos.GuardarUsuario(usuario);
        }

        public Usuario buscarUsuarioByDNI(int dNI)
        {
            usuarioDatos = new UsuarioDatos();
            return usuarioDatos.buscarUsuario(dNI);
        }

    }
}
