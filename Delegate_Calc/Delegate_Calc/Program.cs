namespace Delegate_Calc
    
    ///Delegate Calculator
    ///
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculateDelegate;

            Console.Write("Enter first value \'A\': ");
            bool correctA = double.TryParse(Console.ReadLine(), out double a);
            Console.Write("Enter second value \'B\':");
            bool correctB = double.TryParse(Console.ReadLine(), out double b);

            if (correctA && correctB)
            {
                Console.WriteLine("\n Please enter action for two values:\n \'+\' - Add," +
                    "\n \'-\' - Substrakt, \n \'*\' - Multiply, \n \'/\' - Divide");
                Console.Write("Make your choise:");
                string action = Console.ReadLine();

                bool correctAction = true;
                calculateDelegate = null;
                switch (action)
                {
                    case "+":
                        calculateDelegate = new Calculate(MathActions.Add);
                        break;
                    case "-":
                        calculateDelegate = new Calculate(MathActions.Sub);
                        break;
                    case "*":
                        calculateDelegate = new Calculate(MathActions.Mult);
                        break;
                    case "/":
                        calculateDelegate = new Calculate(MathActions.Div);
                        break;

                    default:
                        correctAction = false;
                        Console.WriteLine("Incorrect action");
                        break;
                }

                if (correctAction)
                {
                    double result =  calculateDelegate.Invoke(a, b);
                    Console.WriteLine($"Result  is ->  {result}");
                } 
            }
            else 
            Console.WriteLine("Incorrect input");   
        }    
    }
}