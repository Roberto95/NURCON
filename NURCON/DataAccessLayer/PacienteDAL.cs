using BusinessEntities.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataAccessLayer
{
    class PacienteDAL
    {
        // se agregaron los Paquetes Nutgets
        // aqui se conecta la base de datos nurcon con la tabla pacientes
        public static NURCONDbContext db = new NURCONDbContext();
    
        // Buscar este metodo viene de la clase dbcontext con prural y singular
        public static bool insertar(Paciente m)
        {
            db.Pacientes.Add(m);
            return db.SaveChanges() > 0;
        }

    }
}
