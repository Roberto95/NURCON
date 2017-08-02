using BusinessEntities.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
    public class PacienteBLL
    {
        // se agregaron los Paquetes Nugets
        // se creo una lista que viene de business entities y BLL es de consultar
        public static string insertar(Paciente m)
        {
            string mensaje = "";
            //validar que no hay campos vacios

            //validar que el paciente no se repita
            bool isExist = DataAccessLayer.PacienteDAL.matRepetida(m.Matricula);
            if (isExist)
            {
                mensaje = "Paciente ya registrado";
            }
            else
            {
                bool isInserted = DataAccessLayer.PacienteDAL.insertar(m);
                if (isInserted)
                {
                    mensaje = "";

                }
                else
                {
                    mensaje = "Error de insercion de paciente";
                }

            }


            return mensaje;
        }

        public static List<Paciente> visualizar()
        {
            return DataAccessLayer.PacienteDAL.consulta();
        }

        public static List<Paciente> busquedaNombre(string nom)
        {
            return DataAccessLayer.PacienteDAL.consultaPorNombre(nom);


        }
        public static List<Paciente> consultaPormatricula(int mat)
        {
            return DataAccessLayer.PacienteDAL.consultaPormatricula(mat);


        }

        public static List<Paciente> consultaPorID(int ma)
        {
            return DataAccessLayer.PacienteDAL.consultaPorID(ma);
        }

        public static bool eliminar(int matricula)
        {
            return DataAccessLayer.PacienteDAL.eliminar(matricula);
        }

        public static bool matRepetida(int mat) {
            return DataAccessLayer.PacienteDAL.matRepetida(mat);
        } 


        // actualizacion
        public static bool actualizar(Paciente p)
        {
            return DataAccessLayer.PacienteDAL.actualizar(p);
        }
       // actualizacion

    }
}
