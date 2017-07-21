using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessEntities.Clases
{
   public class Paciente
    {
        [Key]/// si no  funciona la quitamos
        public int Id { get; set; }
        public string Nombre_Paciente {get; set;}
        public int Matricula { get;  set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
       


    


    }
}
