using System;

namespace Laboratorio4
{
    public class Cola
    {
        public class Nodo
        {
            public int dato;
            public int prioridad;
            public Nodo siguiente;
        }

        public Nodo nuevo (int info, int prio)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = info;
            nuevo.prioridad = prio;
            nuevo.siguiente = null;
            return nuevo;
        }

        public int top(Nodo head)
        {
            return head.dato;
        }

        public Nodo pop(Nodo head)
        {
            Nodo info = head;
            head = head.siguiente;
            return head;
        }

        public Nodo push (Nodo head, int dat, int prio)
        {
            Nodo inicio = head;
            Nodo sele = nuevo(dat, prio);
            if (head.prioridad > prio)
            {
                sele.siguiente = head;
                head = sele;
            }
            else
            {
                while (inicio.siguiente != null && inicio.siguiente.prioridad < prio)
                {
                    inicio = inicio.siguiente;
                }
                sele.siguiente = inicio.siguiente;
                inicio.siguiente = sele;
            }
            return head;
        }

        public int Vacio (Nodo head)
        {
            return (head == null) ? 1 : 0;
        }
    }
}
