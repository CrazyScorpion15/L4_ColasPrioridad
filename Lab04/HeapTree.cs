using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lab04;

namespace Lab04
{
    public class HeapTree<K, V> : IHeap<K, V>
    {
        private GetPrioridad<K, V> getprioridad;
        private CompararPrioridad<K> compararprioridad;
        private int count;
        private Arbol<K, V> root;

        public HeapTree(GetPrioridad<K, V> _getPrioridad, CompararPrioridad<K> _compararPrioridad)
        {
            getprioridad = _getPrioridad;
            compararprioridad = _compararPrioridad;
        }

        public int Count()
        {
            return count;
        }

        public void Insertar(V value)
        {
            if (IsEmpty())
            {
                Arbol<K, V> newNode = new Arbol<K, V>(getprioridad(value), value);
                root = newNode;
                count++;
            }
            else
            {

            }

        }

        private void InsertarOrden(Arbol<K, V>  Padre, Arbol<K, V> newnode, int Nivel)
        {
            int Maxnivel = 1;
            for (int i = 1; i <= Nivel; i++)
            {
                Maxnivel += Convert.ToInt32(Math.Pow(2, i));
            }

            if (Count() < Maxnivel)
            {
                //Hace que se pueda insertar en este nivel en la forma INVARIANTE
                if (Padre.left == null)
                {
                    Padre.left = newnode;
                }
                else
                {
                    Padre.right = newnode;
                }
                count++;

                //Delgado para comparar si es necesario hacer un cambio de prioridad
            }

            else
            {
                
            }
        }

        public bool IsEmpty()
        {
            return 0 == count;
        }
    }
}
