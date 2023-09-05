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
                new Candidate(20, "Steeven Strange", 5)
            };
            MailSender mailSender = new MailSender();

            foreach (var member in hireGroup) 
            {
                mailSender.SendMail(member); 
    
            }
        }
    }
}