using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04
{
    public class Node<T>
    {
        public T value;
        public Node<T> Next;
        public Node<T> Previous;
    }
}
