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
        int cantidadNodos = 0 ;
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
                raiz = nuevo;
            else
            {
                PriorityQueueNode<T> anterior = null, pivot, raizCambio = null, siguiente = null;
                pivot = raiz;
                while (pivot != null)
                {
                    anterior = pivot;
                    PriorityQueueNode<T> temp = new PriorityQueueNode<T>
                    {
                        Object = pivot.Object,
                        Priority = pivot.Priority,
                        izq = pivot.izq,
                        der = pivot.der,
                    };
                    if (nuevo.Priority > pivot.Priority)
                    {
                        pivot = nuevo;
                        nuevo = temp;

                        raizCambio = pivot;

                        pivot = pivot.izq;
                        cantidadNodos++;
                    }
                    else
                    {
                        pivot = pivot.der;
                        cantidadNodos++;
                    }
                }
                if (nuevo.Priority > anterior.Priority)
                { 
                    if(cantidadNodos == 2)
                    {
                        raiz = raizCambio;
                        
                    }
                    else
                    {
                        anterior.izq = nuevo;
                    } 
                }
                else
                {
                    if (cantidadNodos == 2)
                    {
                        raiz = raizCambio;

                    }
                    else
                    {
                        anterior.der = nuevo;
                    }
                }
            }
        }
        private void Swap(ref PriorityQueueNode<T> pivot, ref PriorityQueueNode<T> nuevo)
        {
            PriorityQueueNode<T> temp = new PriorityQueueNode<T>
            {
                Object = pivot.Object,
                Priority = pivot.Priority,
            };
            pivot = nuevo;
            nuevo = temp;
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
