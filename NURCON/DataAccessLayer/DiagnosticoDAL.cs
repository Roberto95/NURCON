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
        public static NURCONDbContext BBB = new NURCONDbContext();

        // Buscar este metodo viene de la clase dbcontext con prural y singular
        // este metodode insertar


        // Buscar este metodo viene de la clase dbcontext con prural y singular
        // este metodode insertar
        public static bool insertar(Diagnostico l)

        {
            BBB.Diagnoticos.Add(l);
            return BBB.SaveChanges() > 0;
        }
        ///////// como solo ocupamos insertar hasta el momento


    }
}
