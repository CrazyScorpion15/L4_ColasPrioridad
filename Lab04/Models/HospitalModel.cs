using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Lab04.Helpers;

namespace Lab04.Models
{
    public class HospitalModel
    {
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

        public static bool Save(HospitalModel model, int prioridad)
        {
            Data.Instance.PriorityQueue.Insertar(model, prioridad);//<----------------Save de la cola de prioridad           
            return true;
        }
        public static bool CalculoPrio(HospitalModel model)
        {
            int prio = 0;
            //Sexo
            if(model.Sexo == "Hombre")
            {
                prio += 3;
            }
            else if(model.Sexo == "Mujer")
            {
                prio += 5;
            }
            //Edad
            if (model.Edad == "70+")
            {
                prio += 10;
            }
            else if (model.Edad == "50-69")
            {
                prio += 8;
            }
            else if (model.Edad == "18-49")
            {
                prio += 3;
            }
            else if (model.Edad == "0-5")
            {
                prio += 8;
            }
            else if (model.Edad == "6-17")
            {
                prio += 5;
            }
            //Especializacion
            if (model.Especializacion == "Traumatologia (interna)")
            {
                prio += 3;
            }
            else if (model.Especializacion == "Traumatologia (Expuesta)")
            {
                prio += 8;
            }
            else if (model.Especializacion == "Ginecologia")
            {
                prio += 5;
            }
            else if (model.Especializacion == "Cardiologia")
            {
                prio += 10;
            }
            else if (model.Especializacion == "Neumologia")
            {
                prio += 8;
            }
            //Ingreso
            if (model.Ingreso == "Ambulancia")
            {
                prio += 5;
            }
            else if (model.Ingreso == "Asistido")
            {
                prio += 3;
            }
            Save(model, prio);
            return true;
        }
    }
}
