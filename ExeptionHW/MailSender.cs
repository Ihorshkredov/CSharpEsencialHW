using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionHW
{
    public  class MailSender
    {
       

        public void SendMail(Candidate candidate)
        {

 
             if (EmploeeDepartment.HirePerson(candidate))
             {
                if (candidate.Age <= 18)
                {
                    throw new ToYoungException(candidate.Age, "To young exception. Age less than 18");
                }
                SendMailToSuccessCandidate(candidate);
               Double salary = EmploeeDepartment.CountSalary(candidate);
               int bonus = EmploeeDepartment.CountBonus(candidate);
               SendSalaryMessage(salary);
             }
             else
             {
                SendMailToFailedCandidate(candidate);
             }
        }


        public static void SendMailToFailedCandidate(Candidate person)
        {
            Console.WriteLine($"{new string('-',30)} Dear {person.Name}");
            Console.WriteLine($"We appreciate for your wish to become part of our company.");
            Console.WriteLine($"Unfortunately for now we can't propose you any position in our team.\n" +
                $"Hope you will return to us soon and try again to join to us...\n" +
                $"{new string('-',30)}");
        }
        public static void SendMailToSuccessCandidate(Candidate person) 
        {
            Console.WriteLine($"{new string('-',30)}Dear {person.Name}");
            Console.WriteLine($"We glad to inform you become part of our team.");
            Console.WriteLine($"Please connect with our HR department till next week");

        }

         void SendSalaryMessage(double salary)
        {
            Console.WriteLine($"Your salary will be :{salary} USD");
        }

        
    }
}
