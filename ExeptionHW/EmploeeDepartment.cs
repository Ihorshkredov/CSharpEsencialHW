﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionHW
{
    public  class EmploeeDepartment
    {
       public  bool HirePerson(Candidate person) => (person.Expirience * 100) / person.Age < 20 ? false : true;

        public  double CountSalary(Candidate person)
        {           
            double basePayment = 300 + person.Expirience * 100;
            return basePayment;
        }
        public int CountBonus(Candidate person)
        {
            return 20/person.Expirience - 10;
        }
    }
}
