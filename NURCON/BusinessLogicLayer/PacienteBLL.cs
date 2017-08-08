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

            //metodo de insertar por LinQ
        public static string insertar(Paciente m)
        {
            string mensaje = "";
          

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

        //metodo de insertar por Command
        public static string insertarPorCommand(Paciente p) {
            return DataAccessLayer.PacienteDAL.insertarPorCommand(p);
        }

        //metodo para consultar lista de todos los pacientes por LinQ
        public static List<Paciente> visualizar()
        {
            return DataAccessLayer.PacienteDAL.consulta();
        }

        //metodo para consultar a los pacientes por medio de la matricula
        public static List<Paciente> consultaPormatricula(int mat)
        {
            return DataAccessLayer.PacienteDAL.consultaPormatricula(mat);


        }

        //metodo para consultar a los pacientes por medio del ID
        public static List<Paciente> consultaPorID(int ma)
        {
            return DataAccessLayer.PacienteDAL.consultaPorID(ma);
        }

        //metodo para eliminar un paciente por medio de la matricua
        public static bool eliminacion_paciente(int matricula)
        {
            return DataAccessLayer.PacienteDAL.eliminarPorCommand(matricula);
            //return DataAccessLayer.PacienteDAL.eliminar_Pacientes(matricula);
        }

        //metodo para ver si la matricula se repite en la base de datos
        public static bool matRepetida(int mat)
        {
            return DataAccessLayer.PacienteDAL.matRepetida(mat);
        }


        //metodo de actualizacion
        public static bool actualizar(Paciente p)
        {
            return DataAccessLayer.PacienteDAL.actualizar(p);
        }

        public static string actualizarMat(int mat,int id) {
            
            string mensaje="";
            int var = DataAccessLayer.PacienteDAL.consultaPormatricula(mat).ToList()[0].Id;
            if (var!=id)
            {
                mensaje = "Matricula ya en Base de datos";
            }
            else {
                mensaje = "";
            }
            return mensaje;
        }

       // actualizacion

    }
}
