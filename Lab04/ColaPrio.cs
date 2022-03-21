using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab04
{
    public class ColaPrio<T> : IEnumerable<T>, IEnumerable
    {
        Node<T> Head;


        public IEnumerator<T> GetEnumerator()
        {
            Node<T> node = Head;
            while (node != null)
            {
                yield return node.value;
                node = node.Next;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
