using Lab04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Lab04
{
    public delegate int Comparar<T>(T a, T b);

    public class Comparar
    {

        public static int Comp(HospitalModel a, HospitalModel b)
        {
            if (a.Prioridad != b.Prioridad)
            {
                if (a.Prioridad.CompareTo(b.Prioridad) < 0)
                {
                    return -1;
                }
                else
                {
                    return 1;
                }
            }
            else
            {
                return 0;
            }
        }
    }
 }
