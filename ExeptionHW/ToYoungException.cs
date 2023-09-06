using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionHW
{
    internal class ToYoungException : Exception
    {
        public int Age { get; set; }

        public ToYoungException(int age, string message ) : base( message )
        {
            Age = age;
        }
    }
}
