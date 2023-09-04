using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection
{
    internal class SomeCollection : IEnumerable, IEnumerator
    {
        private int i;
        private readonly Element[] myElementCollection; 

        public object Current => myElementCollection [i];

        public SomeCollection()
        {
            myElementCollection = new Element[20];
            i = -1;

        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public bool MoveNext()
        {
            if (i < myElementCollection.Length - 1)
            {
                i++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            i = -1;
        }
    }
}
