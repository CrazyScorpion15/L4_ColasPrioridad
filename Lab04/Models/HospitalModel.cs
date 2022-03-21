using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab04.Models
{
    public class HospitalModel
    {
        public int Prioridad { get; set; }
        [Required]
        public string Nombre { get; set; }
        [Required]
        public string Apellido { get; set; }
        [Required]
        public string FechaNacimiento{ get; set; }
        [Required]
        public string Sexo { get; set; }
        [Required]
        public string Edad { get; set; }
        [Required]
        public string Especializacion { get; set; }
        [Required]
        public string Ingreso { get; set; }

        public static bool Save(HospitalModel model)
        {
            //<----------------Save de la cola de prioridad           
            return true;
        }
    }
}
