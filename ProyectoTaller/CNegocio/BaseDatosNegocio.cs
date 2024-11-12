using ProyectoTaller.CDatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CNegocio
{
    public class BaseDatosNegocio
    {
        private ConexionBD conexionBD;


        public void generarBackUP(string rutaBackup)
        {
            conexionBD = new ConexionBD();
            conexionBD.RealizarBackup(rutaBackup);
        }

        public void generarRestore(string rutaBackup)
        {
            conexionBD = new ConexionBD();
            conexionBD.RealizarRestore(rutaBackup);
        }
    }
}
