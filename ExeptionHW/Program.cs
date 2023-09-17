using System.Collections;


namespace ExeptionHW
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Candidate[] hireGroup =
            {
                new Candidate(20,"John Smith", 3),
                new Candidate(31, "Bob Marley", 10),
                new Candidate(27, "John Week", 5),
                new Candidate(16, "Roy Rojers", 1),
                new Candidate(20, "Steeven Strange", 0)
            };

            List<Candidate> candidatelist = new List<Candidate>()
            {
                new Candidate(35, "Arni Shwartsneger",2),
                new Candidate(40, "Mahamad Ali", 15),
                new Candidate(35, "Tony Stark", 20),
                new Candidate(35, "Roy Rojers", 8)
            };

            


            MailSender mailSender = new MailSender();

                try
                {
                    mailSender.SendMail(EmploeeDepartment.HirePersonsList(2,candidatelist));
                }
                catch (DivideByZeroException e)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine($"\n Catched devide on zero exception ");
                    Console.WriteLine(e.Message);
                    Console.ResetColor();

                }
                catch (ToYoungException e)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n Catched  exception of small age ");
                    Console.WriteLine(e.Message);
                    Console.ResetColor();

                }

                catch (Exception e)
                {
                    Console.WriteLine($"\nError by processing ");
                    Console.WriteLine(e.Message);
                }
                 
  
        }
    }

   
}