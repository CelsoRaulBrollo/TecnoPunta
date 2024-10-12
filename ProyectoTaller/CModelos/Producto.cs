using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoTaller.CModelos
{
    public class Producto
    {
        public string Modelo_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public string SistemaOperativo_Producto { get; set; }
        public string Almacenamiento_Producto { get; set; }
        public string Ram_Producto { get; set; }
        public int Stock_Producto { get; set; }
        public Marca Marca {  get; set; }
        public Condicion Condicion { get; set; }

    }
}
