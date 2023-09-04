using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollection
{
     class YeldCollection
    {
        public static IEnumerable Power()
        {
            for (int i = 0; i < 10; i++)
            {
                yield return new Element(i,"element");

            }
           
        }
    }
}
