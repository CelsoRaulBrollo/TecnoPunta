//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProyectoTaller
{
    using System;
    using System.Collections.Generic;
    
    public partial class Productos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Productos()
        {
            this.Detalle_Factura = new HashSet<Detalle_Factura>();
        }
    
        public string Modelo_Producto { get; set; }
        public string Marca_Producto { get; set; }
        public string Nombre_Producto { get; set; }
        public string SistemaOperativo_Producto { get; set; }
        public string Almacenamiento_Producto { get; set; }
        public string Ram_Producto { get; set; }
        public int Stock_Producto { get; set; }
        public decimal Precio_Producto { get; set; }
        public string Estado_Producto { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Detalle_Factura> Detalle_Factura { get; set; }
    }
}