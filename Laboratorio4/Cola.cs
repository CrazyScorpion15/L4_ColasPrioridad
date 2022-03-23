using Lab04;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio4
{
    public class Cola<T> : IEnumerable<T>, IEnumerable
    {

        Node<T> head;

        //public Node<T> nuevo (T info)
        //{
        //    Node<T> nuevo = new Node<T>();
        //    nuevo.value = info;
        //    nuevo.Previous = null;
        //    return nuevo;
        //}

        public Node<T> top(Node<T> head)
        {
            return head;
        }

        //public Node<T> pop(Node<T> head)
        //{
        //    Node<T> info = head;
        //    head = head.Previous;
        //    return head;
        //}

        //public void push (T dato, Comparar<T> comparador)
        //{
        //    Node<T> nuevo = new Node<T>
        //    {
        //        value = dato,
        //        Next = null,
        //    };

        //    T inicio = dato;
        //    Node<T> sele = comparador(dato, prio);
        //    if (head.Next > prio)
        //    {
        //        sele.Previous = head;
        //        head = sele;
        //    }
        //    else
        //    {
        //        while (inicio.Previous != null && inicio.Previous.Next < prio)
        //        {
        //            inicio = inicio.Previous;
        //        }
        //        sele.Previous = inicio.Previous;
        //        inicio.Previous = sele;
        //    }
        //}

        //public Node<T> Vacio (Node<T> head)
        //{
        //    return (head == null) ? 1 : 0;
        //}

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }

}
