using System.Data.Entity;

namespace ProyectoTaller.CNegocio

{
    public class TecnoPuntaBDEntities : DbContext
    {
        public TecnoPuntaBDEntities() : base("name=TecnoPuntaBD")
        {
        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Productos> Productos { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Clientes>()
                .HasKey(c => c.DNI_cliente); // Ajusta según tu entidad.

            // Configuraciones adicionales...
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}