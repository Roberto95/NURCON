using BusinessEntities.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class DiagnosticoDAL
    {
        // se agregaron los Paquetes Nutgets
        // aqui se conecta la base de datos nurcon con la tabla Diagnostico
        public static NURCONDbContext db = new NURCONDbContext();

        // Buscar este metodo viene de la clase dbcontext con prural y singular
        // este metodode insertar


        // Buscar este metodo viene de la clase dbcontext con prural y singular
        // este metodode insertar
        public static bool insertar(Diagnostico l)

        {
            db.Diagnoticos.Add(l);
            return db.SaveChanges() > 0;
        }
        
        public static List<Diagnostico> consultaporIdpac(int id)
        {
            return db.Diagnoticos.Where(d => d.PacienteId == id).ToList();
        }

        public static List<Diagnostico> visualizar() {
            return db.Diagnoticos.ToList();
        }
        public static bool eliminar_Diagnostico(int pacId)
        {
            //el single trae la entidad completa con su informacion
            for (int i=0;i< db.Diagnoticos.Where(d => d.PacienteId == pacId).Count();i++) {
                var query = db.Diagnoticos.Where(d=>d.PacienteId==pacId).ToList()[i];
                db.Diagnoticos.Remove(query);
            }
            
            return db.SaveChanges() > 0;
        }


    }
}
