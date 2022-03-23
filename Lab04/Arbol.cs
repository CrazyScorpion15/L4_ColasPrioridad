using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04
{
    class Arbol<K, V>
    {

        public K key { get; set; }
        public V value { get; set; }

        public Arbol<K, V> left { get; set; }
        public Arbol<K, V> right { get; set; }
        public Arbol<K, V> raiz { get; set; }

        public Arbol(K Key, V Value)
        {

            key = Key;
            value = Value;
            left = null;
            right = null;
            raiz = null;


        }
    }
}
