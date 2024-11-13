using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CModelos
{
    public class Usuarios
    {
        public int DNI_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Apellido_Usuario { get; set; }
        public string Telefono_Usuario { get; set; }
        public string Correo_Usuario { get; set; }
        public decimal Sueldo_Usuario {  get; set; }
        public string Contraseña { get; set; }
        public string Usuario { get; set; }
        public string Estado {  get; set; }
        public int Sexo_Usuario { get; set; }
        public int Rol_Usuario { get; set; }

    }
}
