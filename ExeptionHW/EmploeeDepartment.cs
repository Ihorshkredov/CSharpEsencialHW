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
            SortedDictionary<Candidate , bool> result = new SortedDictionary<Candidate , bool>();
            foreach (Candidate candidate in candidates) 
            {
                bool hired = (candidate.Expirience * 100 / candidate.Age) > 10 && quote > 0;
                result[candidate] = hired;
                quote--;
            }

           return (Dictionary<Candidate,bool>) result.OrderBy(x => x.Key.Expirience);
            
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
}
