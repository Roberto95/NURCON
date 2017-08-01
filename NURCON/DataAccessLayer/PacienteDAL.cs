using BusinessEntities.Clases;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        // Buscar este metodo viene de la clase dbcontext con plural y singular
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
        // consultar por matricula 

        public static List<Paciente> consultaPormatricula(int mat)
        {
            return db.Pacientes.Where(m => m.Matricula == mat).ToList();
        }

        public static List<Paciente> consultaPorID(int ma)
        {
            return db.Pacientes.Where(m => m.Id == ma).ToList();
        }
        public static bool eliminar(int mat)
        {
            var query = db.Pacientes.Where(p => p.Matricula == mat).Single();//el single trae la entidad completa con su informacion
            db.Pacientes.Remove(query);
            return db.SaveChanges() > 0;
        }
       
        public static bool matRepetida(int mat) {
            return db.Pacientes.Where(m => m.Matricula == mat).Count()>0;
        }

       // actualizacion /////////////////////

        public static bool actualizar (Paciente p)
        {
            db.Pacientes.Attach(p);
            db.Entry(p).State = EntityState.Modified; 
            return db.SaveChanges() > 0;
        }
        // actualizacion//////////////////////////
    }
}
