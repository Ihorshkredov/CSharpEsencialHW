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
            MailSender mailSender = new MailSender();

            foreach (var member in hireGroup) 
            {

                try
                {
                    mailSender.SendMail(member);
                }
                catch (DivideByZeroException e)
                {
                    Console.ForegroundColor= ConsoleColor.Red;
                    Console.WriteLine($"\n Catched devide on zero exception for {member.Name}");
                    Console.WriteLine(e.Message);
                    Console.ResetColor();

                }
                catch (ToYoungException e)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\n Catched  exception of small age for {member.Name}");
                    Console.WriteLine(e.Message);
                    Console.ResetColor();

                }

                catch (Exception e)
                {
                    Console.WriteLine($"\nError by processing {member.Name}");
                    Console.WriteLine(e.Message);
                }
                 
    
            }
        }
    }
}