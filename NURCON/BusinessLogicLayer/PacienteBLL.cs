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
        // se agregaron los Paquetes Nutgets
        // se creo una lista que viene de bussines entities y BLL es de consultar
        public static string insertar(Paciente m)
        {
            string mensaje = "";
            //validar que no hay campos vacios
            if (
                string.IsNullOrEmpty(m.Nombre_Paciente)
                || string.IsNullOrEmpty(Convert.ToString(m.Matricula))
                || string.IsNullOrEmpty(m.Sexo)
                || string.IsNullOrEmpty((Convert.ToString(m.Edad))


              )
              )
            { 

                mensaje = "Favor de completar el formulario o usar el formato correcto";
            }
            else
            {

                //validar que el medico no se repita
                bool isExist = DataAccessLayer.PacienteDAL.consultaPorMatricula(m.Matricula);
                if (isExist)
                {
                    mensaje = "Medico ya registrado";
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
                        mensaje = "Error de insercion";
                    }

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

        public static List<Paciente>consultaPorID(int ma)
        { 
            return DataAccessLayer.PacienteDAL.consultaPorID(ma);            
        }

        public static bool eliminar(int matricula )
        {
            return DataAccessLayer.PacienteDAL.eliminar(matricula);
        }
       
    }
}
