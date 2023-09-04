namespace CustomCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {


            foreach (Element item in YeldCollection.Power())
            {
                Console.WriteLine($"{item.ID} - {item.Name}");
            }


            Console.WriteLine(new string('-', 30));

            

            
        }
    }
}