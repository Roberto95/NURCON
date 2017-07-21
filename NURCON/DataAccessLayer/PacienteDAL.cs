using BusinessEntities.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace DataAccessLayer
{
   public class PacienteDAL
    {
        // se agregaron los Paquetes Nutgets
        // aqui se conecta la base de datos nurcon con la tabla pacientes
        public static NURCONDbContext db = new NURCONDbContext();
    
        // Buscar este metodo viene de la clase dbcontext con prural y singular
        // este metodode insertar
        public static bool insertar(Paciente m)

        {
            db.Pacientes.Add(m);
            return db.SaveChanges() > 0;
        }
       
        //  este metodo sirve para consultar
        public static List<Paciente> consulta()
        {
            return db.Pacientes.ToList();
        }

        // este metodo sirve para consultar por nombre
        public static List<Paciente> consultaPorNombre(string nom)
        {
            return db.Pacientes.Where(m => m.Nombre_Paciente == nom).ToList();
        }

        public static bool consultaPorMatricula(int n)
        {
            return db.Pacientes.Where(m => m.Matricula== n).Count()>0;
            // la m se declara aqui es tipo bool y buscamos por matricula
        }
    }
}
