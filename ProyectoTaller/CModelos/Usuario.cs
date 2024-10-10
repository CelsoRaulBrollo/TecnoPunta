using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CModelos
{
    internal class Usuario
    {
        public int DNI_Usuario { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Apellido_Usuario { get; set; }
        public string Telefono_Usuario { get; set; }
        public string Correo_Usuario { get; set; }
        public string Direccion_Usuario { get; set; }

        public Sexo Sexo_Usuario { get; set; }
        public Rol Rol_Usuario { get; set; }

    }
}
