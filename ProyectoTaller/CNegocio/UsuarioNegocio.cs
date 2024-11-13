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

        public void actualizarEstado(int dni_Usuario)
        {
            usuarioDatos = new UsuarioDatos();
            usuarioDatos.actualizarEstado(dni_Usuario);
        }

        public Usuarios autenticacion(string nombreUsuario, string contraseña)
        {
            usuarioDatos = new UsuarioDatos();
            return usuarioDatos.autenticacion(nombreUsuario, contraseña);
        }

        public DataTable ListarUsuarios()
        {
            usuarioDatos = new UsuarioDatos();

            return usuarioDatos.ListarUsuario();
        }

        public bool EditarUsuario(Usuarios usuario)
        {
            usuarioDatos = new UsuarioDatos();
            return usuarioDatos.ActualizarUsuario(usuario);
        }

        public void GuardarUsuario(Usuarios usuario)
        {
            usuarioDatos = new UsuarioDatos();

            usuarioDatos.GuardarUsuario(usuario);
        }

        public Usuarios buscarUsuarioByDNI(int dNI)
        {
            usuarioDatos = new UsuarioDatos();
            return usuarioDatos.buscarUsuario(dNI);
        }

        public bool ExisteCorreo(string correo)
        {
            usuarioDatos = new UsuarioDatos();
            return usuarioDatos.EsCorreoExistente(correo);
        }

        public bool ExisteUsuario(string nombreUsuario)
        {
            usuarioDatos = new UsuarioDatos();
            return usuarioDatos.EsUsuarioExistente(nombreUsuario);
        }

    }
}