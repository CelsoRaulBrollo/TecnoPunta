using ProyectoTaller.CDatos;
using ProyectoTaller.CModelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CNegocio
{
   
    public class UsuarioNegocio
    {
        private UsuarioDatos usuarioDatos;

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

        public int ObtenerDNIDelUsuario(string nombreUsuario, string contraseña)
        {
            int dni = -1;

            string connectionString = @"Server=CELSOBRO\SQLEXPRESS;Database=TecnoPuntaBD;Trusted_Connection=True;";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT DNI_Usuario FROM Usuarios WHERE Usuario = @nombreUsuario AND Contraseña = @contraseña";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    // Ejecuta la consulta y obtiene el DNI
                    object result = command.ExecuteScalar();
                    if (result != null)
                    {
                        dni = Convert.ToInt32(result);
                    }
                }
            }
            return dni; // Retorna el DNI del usuario o -1 si no se encuentra
        }
    }
}
