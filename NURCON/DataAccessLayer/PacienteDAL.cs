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

        // eliminacion
        public static bool eliminar_Pacientes(int ma)
        {
            var query =db.Pacientes.Where(p => p.Matricula == ma).Single();//el single trae la entidad completa con su informacion

            db.Pacientes.Remove(query);
            return db.SaveChanges() > 0;
        }
        // eliminacion

        public static bool matRepetida(int mat) {
            return db.Pacientes.Where(m => m.Matricula == mat).Count()>0;
        }

       // actualizacion /////////////////////

       
        public static bool actualizarDos(Paciente p) {
            var pacienteed = db.Pacientes.FirstOrDefault(x => x.Id == p.Id);
            pacienteed.Id = p.Id;
            pacienteed.Matricula = p.Matricula;
            pacienteed.Nombre_Paciente = p.Nombre_Paciente;
            pacienteed.Edad = p.Edad;
            pacienteed.Sexo = p.Sexo;
            return db.SaveChanges() > 0;
        }
        // actualizacion//////////////////////////
    }
}
