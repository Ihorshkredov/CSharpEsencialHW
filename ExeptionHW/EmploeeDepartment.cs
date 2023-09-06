using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionHW
{
    public static class EmploeeDepartment
    {
        public static bool HirePerson(Candidate candidate) => (candidate.Age % 2 == 0);


        public static  double CountSalary(Candidate candidate)
        {           
            double basePayment = 300 + candidate.Expirience * 100;
            return basePayment;
        }
        public static int CountBonus(Candidate candidate)
        {
            return (20 - 20/candidate.Expirience);
        }
    }
}
