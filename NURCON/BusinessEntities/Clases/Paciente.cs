using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Clases
{
   public  class Paciente
    {
        [Key]
        public string Nombre_Paciente {get; set;}
        public int Matricula { get;  set; }
        public bool Sexo { get; set; }
        public int Edad { get; set; }
        public string Tipo_de_sangre { get; set; }

        public string Motivo_de_visita { get; set; }
    
        public string Medicamentos { get; set;}

        public string Notas { get; set;}
        public string Sintomas { get; set; }



    


    }
}
