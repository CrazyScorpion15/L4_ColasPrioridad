using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04
{
    public class PriorityQueueNode<T>
    {
        public int Priority { get; set; }
        public int Pos { get; set; }
        public PriorityQueueNode<T> izq { get; set; }
        public PriorityQueueNode<T> der { get; set; }
        public T Object { get; set; }
    }
}
