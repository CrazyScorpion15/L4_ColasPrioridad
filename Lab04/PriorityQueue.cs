using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04
{
    public class PriorityQueue<T> : IEnumerable<T>, IEnumerable
    {
        public PriorityQueueNode<T> raiz;
        int cantidadNodos = 1;
        public PriorityQueue()
        {
            raiz = null;
        }

        public void Insertar(T valor, int prio)
        {
            PriorityQueueNode<T> nuevo = new PriorityQueueNode<T>
            {
                Object = valor,
                Priority = prio,
                izq = null,
                der = null
            };
            if (raiz == null)
            {
                raiz = nuevo;
            }
            else
            {
                PriorityQueueNode<T> anterior = null, pivot;
                pivot = raiz;
                cantidadNodos++;
                while (pivot != null)
                {
                    anterior = pivot;


                    if (cantidadNodos % 2 == 0)
                    {
                        if (pivot.izq == null || pivot.der == null)
                        {
                            if (pivot.izq == null)
                            {
                                pivot = pivot.izq;
                            }
                            else
                            {
                                pivot = pivot.der;
                            }
                        }
                            else if(pivot.izq != null)
                        {   
                                pivot = pivot.izq;                           
                        }
                            else if(pivot.der != null)
                        {
                            pivot = pivot.der;
                        }

                    }
                    else
                    {
                        if (pivot.der == null)
                        {
                            pivot = pivot.der;
                        }
                        else
                        {
                            pivot = pivot.izq;
                        }
                    }
                }
                if (cantidadNodos % 2 ==0)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }
        private void Swap(PriorityQueueNode<T> primero, PriorityQueueNode<T> segundo)
        {
            //PriorityQueueNode<T> temp = new PriorityQueueNode<T>
            //{
            //    Object = pivot.Object,
            //    Priority = pivot.Priority,
            //};
            //pivot = nuevo;
            //nuevo = temp;
            if(primero.Priority > segundo.Priority)
            {

            }
        }
        private void InOrder(PriorityQueueNode<T> root, ref ShowList<T> queue)
        {
            if (root != null)
            {
                InOrder(root.izq, ref queue);
                queue.Add(root.Object);
                InOrder(root.der, ref queue);
            }
            return;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var queue = new ShowList<T>();
            InOrder(raiz, ref queue);

            while (!queue.Empty())
            {
                yield return queue.Dequeue();
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
