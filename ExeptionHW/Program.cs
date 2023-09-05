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
                new Candidate(17, "Roy Rojers", 1),
                new Candidate(20, "Steeven Strange", 0)
            };
            MailSender mailSender = new MailSender();

            foreach (var member in hireGroup) 
            {
                
                try
                {
                    if (member.Age <= 18)
                    {  
                        throw (new Exception($" To young, AGE is {member.Age}"));
                    }

                    mailSender.SendMail(member);

                }
                catch (DivideByZeroException e)
                {
                    Console.WriteLine($"\nError by processing {member.Name}");
                    Console.WriteLine(e.Message);
                   
                }
                catch(Exception e) 
                {
                    Console.WriteLine($"\nError by processing {member.Name}");
                    Console.WriteLine(e.Message);
                }
                 
    
            }
        }
    }
}