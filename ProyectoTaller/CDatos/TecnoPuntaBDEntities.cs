using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ProyectoTaller.CDatos.ClienteDatos;

namespace ProyectoTaller.CDatos
{
    public class TecnoPuntaBDEntities : DbContext
    {
        public TecnoPuntaBDEntities() : base("name=NombreDeTuCadenaDeConexion")
        {
        }

        public DbSet<Clientes> Clientes { get; set; }
    }
}
