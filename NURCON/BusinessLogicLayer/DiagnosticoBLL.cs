using BusinessEntities.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer
{
   public class DiagnosticoBLL
    {

        public static string insertar(Diagnostico l)
        {
            string mensaje = "";
            //validar que no hay campos vacios
            if (
                string.IsNullOrEmpty(l.Tipo_de_sangre)
                || string.IsNullOrEmpty(l.Motivo_de_visita)
                || string.IsNullOrEmpty(l.Medicamentos)
                || string.IsNullOrEmpty(l.Notas)
                || string.IsNullOrEmpty(l.Sintomas)
                || string.IsNullOrEmpty((Convert.ToString(l.PacienteId))


              )
              )
            {

                mensaje = "Favor de completar el formulario o usar el formato correcto";
            }
            else
            {

                //validar que el medico no se repita
               
                {
                    bool isInserted = DataAccessLayer.DiagnosticoDAL.insertar(l);
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




    }
}
