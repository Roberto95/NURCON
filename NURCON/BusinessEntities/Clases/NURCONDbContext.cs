using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Clases
{
   public class NURCONDbContext : DbContext
    {

        public NURCONDbContext()
            : base("NURCONDbContext")//buscar cadena de conexion de la base de datos
          // aqui enlazamos a la BD
        { }

        public DbSet<Paciente>Pacientes{ get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {   //quita el plural del nombre de las tablas
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }




    }
    
}
