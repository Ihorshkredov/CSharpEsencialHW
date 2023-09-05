using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionHW
{
    public class Candidate
    {
        public int Age { get; }
        public int Expirience { get; }
        public string Name { get; }


        public Candidate(int age, string name, int expirience)
        {
            Age = age;
            Name = name;
            Expirience = expirience;   
        }
    }
}
