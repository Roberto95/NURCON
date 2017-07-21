using BusinessEntities.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    class PacienteBLL
    {
        // se agregaron los Paquetes Nutgets
        // se creo una lista que viene de bussines entities y BLL es de consultar
        public static List<Paciente> visualizar()
        {
            return DataAccessLayer.PacienteDAL.consulta();
        }

        public static List<Paciente> busquedaNombre(string nom)
        {
            return DataAccessLayer.PacienteDAL.consultaPorNombre(nom);


        }

    }
}
