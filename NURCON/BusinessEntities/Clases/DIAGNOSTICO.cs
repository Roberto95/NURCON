using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Clases
{
    public class Diagnostico
    {
        public int Id { get; set; }
        public string Tipo_de_sangre { get; set; }
        public string Motivo_de_visita { get; set; }
        public string Medicamentos { get; set; }
        public string Notas { get; set; }
        public string Sintomas { get; set; }
        public int PacienteId { get; set; }


        // aqui le ponemos la fk de la tabla


    }
}
