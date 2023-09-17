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
        public static Dictionary<Candidate,  bool> HirePersonsList(int quote, List<Candidate> candidates)
        {
            Dictionary<Candidate , bool> result = new Dictionary<Candidate , bool>();
            foreach (Candidate candidate in candidates) 
            {
                if ((candidate.Expirience * 100 / candidate.Age > 10)&(quote > 0))
                {
                    result[candidate] = true;
                    quote--;
                }
                else
                {
                    result[candidate] = false;
                } 
            }

            return result; 

             
          
        }


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


    public class PersonComparer : IComparer<Candidate>
    {

        public int Compare(Candidate? x, Candidate? y)
        {
            return x.Age - y.Age;
        }
    }
}
