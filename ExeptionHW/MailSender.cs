using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeptionHW
{
    public  class MailSender
    {
        EmploeeDepartment department = new EmploeeDepartment();

        public void SendMail(Candidate person)
        {
            Exception ToYoungException = new Exception("Candidate is to young");
            ToYoungException.Data.Add("Age", person.Age);

            try
            {
                if (person.Age <= 18)
                {
                    throw ToYoungException;
                }
                else
                {
                    bool personHired = department.HirePerson(person);
                    if (personHired)
                    {
                        SendMailToSuccessCandidate(person);
                        Double salary = department.CountSalary(person);
                        int bonus = department.CountBonus(person);
                        SendSalaryMessage(salary);

                    }
                    else
                    {
                        SendMailToFailedCandidate(person);
                    }
                }

            }
            catch (DivideByZeroException e)
            {
                
                Console.WriteLine("Error Message: Devide by zero was done");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                foreach (DictionaryEntry item in ex.Data)
                {
                    Console.WriteLine($"{item.Key} - {item.Value}");
                }
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
