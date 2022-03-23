using System;
using System.Collections.Generic;
using System.Text;


namespace Lab04
{
    public class IHeap<K, V>
    {
        public delegate K GetPrioridad<K, V>(V value);
        public delegate int CompararPrioridad<K>(K Prioridad1, K Prioridad2);

        void Insertar(V value)
        {

        }

        int count()
        {
            return 0;
        }

        bool IsEmpty()
        {
            return true;
        }

    }
}
