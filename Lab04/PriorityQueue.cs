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
        public PriorityQueueNode<T> newNode(T valor, int prio)
        {
            PriorityQueueNode<T> temp = new PriorityQueueNode<T>
            {
                Object = valor,
                Priority = prio,
                der = null,
            };
            return temp;
        }
        public T peek(PriorityQueueNode<T> head)
        {
            return head.Object;
        }

        public void Push(T valor, int prio)
        {
            if(raiz == null)
            {
                raiz = newNode(valor, prio);
            }
            else
            {
                PriorityQueueNode<T> start = raiz;
                PriorityQueueNode<T> temp = newNode(valor, prio);

                if (raiz.Priority < prio)
                {
                    temp.der = raiz;
                    raiz = temp;
                }
                else
                {
                    while (start.der != null && start.der.Priority > prio)
                    {
                        start = start.der;
                    }
                    temp.der = start.der;
                    start.der = temp;
                }
            } 
        }
        public void Insertar(T valor, int prio)
        {
            PriorityQueueNode<T> nuevo = new PriorityQueueNode<T>
            {
                Object = valor,
                Priority = prio,
                Pos = cantidadNodos,
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
                        if (pivot.izq == null)
                        {
                            if (pivot.izq == null)
                            {
                                pivot = pivot.izq;
                            }
                            else if(pivot.der == null)
                            {
                                pivot = pivot.der;
                            }
                        }
                        else if (pivot.der == null)
                        {   
                                pivot = pivot.der;                           
                        }
                        else if(pivot.der == null)
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
                if (cantidadNodos % 2 == 0)
                    anterior.izq = nuevo;
                else
                    anterior.der = nuevo;
            }
        }
        private PriorityQueueNode<T> Swap(PriorityQueueNode<T> primero, PriorityQueueNode<T> segundo)
        {
            if(primero != null && segundo != null)
            {
                PriorityQueueNode<T> temp = new PriorityQueueNode<T>
                {
                    Object = primero.Object,
                    Priority = primero.Priority,
                    izq = primero.izq,
                    der = primero.der,
                };
                if (segundo.Priority > primero.Priority)
                {
                    primero = segundo;
                    segundo = temp;
                }
            }
            return primero;
        }
        //private void InOrder(PriorityQueueNode<T> root, ref ShowList<T> queueAVL)
        //{
        //    if (root != null)
        //    {
        //        InOrder(root.izq, ref queueAVL);
        //        queueAVL.Add(root.Object);
        //        InOrder(root.der, ref queueAVL);
        //    }
        //    return;
        //}
        public void CreacionRaiz(T valor, int prio)
        {
            if(raiz == null)
            {
                raiz = new PriorityQueueNode<T>
                {
                    Object = valor,
                    Priority = prio,
                    Pos = cantidadNodos,
                    izq = null,
                    der = null,
                };
            }
            else
            {
                cantidadNodos++;
                Insertar(raiz, valor, prio);
            }
        }
        public void Insertar(PriorityQueueNode<T> root, T valor, int prioridad)
        {
            if (root != null)
            {
                Insertar(root.izq, valor, prioridad);
                if ((cantidadNodos / 2) == root.Pos)
                {
                    PriorityQueueNode<T> nuevo = new PriorityQueueNode<T>
                    {
                        Object = valor,
                        Priority = prioridad,
                        Pos = cantidadNodos,
                        izq = null,
                        der = null,
                    };
                    root.izq = nuevo;
                    root.Pos = cantidadNodos;
                }
                else if(((cantidadNodos - 1) / 2) == root.Pos)
                {
                    PriorityQueueNode<T> nuevo = new PriorityQueueNode<T>
                    {
                        Object = valor,
                        Priority = prioridad,
                        Pos = cantidadNodos,
                        izq = null,
                        der = null,
                    };
                    root.der = nuevo;
                    root.Pos = cantidadNodos;
                }
                Insertar(root.der, valor, prioridad);
            }
            return;
        }

        private void InOrder(PriorityQueueNode<T> root, ref ShowList<T> queueAVL)
        {
            if (root != null)
            {
                InOrder(root.izq, ref queueAVL);
                queueAVL.Add(root.Object);
                InOrder(root.der, ref queueAVL);
            }
            return;
        }

        public IEnumerator<T> GetEnumerator()
        {
            var queueAVL = new ShowList<T>();
            InOrder(raiz, ref queueAVL);

            while (!queueAVL.Empty())
            {
                yield return queueAVL.Dequeue();
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
