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

        public static bool insertar(Diagnostico l)
        {
            bool val;
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

                val = false;
            }
            else
            {

                
               
                {
                    bool isInserted = DataAccessLayer.DiagnosticoDAL.insertar(l);
                    if (isInserted)
                    {
                        val = true;

                    }
                    else
                    {
                        val = false;
                    }

                }

            }
            return val;
        }

        public static List<Diagnostico> consultaIdPac(int id) {
            return DataAccessLayer.DiagnosticoDAL.consultaporIdpac(id);
        }
        public static List<Diagnostico> visualizar() {
            return DataAccessLayer.DiagnosticoDAL.visualizar();
        }

    }
}
