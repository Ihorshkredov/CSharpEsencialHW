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
        public static SortedDictionary<Candidate,  bool> HirePersonsList(int quote, List<Candidate> candidates)
        {
           Dictionary<Candidate , bool>  result = new Dictionary<Candidate , bool>();

            for (int i = 0; i < candidates.Count; i++)
            {
                result[candidates[i]] = (i <= quote) && (candidates[i].Expirience * 100 / candidates[i].Age > 10);
            }
          
           return  new SortedDictionary<Candidate , bool>(result, new PersonComparer());     
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
            return y.Expirience - x.Expirience;
        }
    }
}
