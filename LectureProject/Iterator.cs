using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class MyIterator : IEnumerable
    {
        public string[] values = { "A", "B", "C"};
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < values.Length; i++)
            {
                yield return values[i];
            }
        }
    }

    internal class MyGenericIterator<A> 
    {
        public A[] values;

        public MyGenericIterator(A[] items)
        {
            values = items;
        }
        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < values.Length; i++)
            {
                yield return values[i];
            }
        }
    }
}
