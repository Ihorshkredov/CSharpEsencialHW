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

            if (correctA&&correctB)
            {
                Console.WriteLine("\nPlease enter action for two values:\n \'+\' - Add,\n \'-\' - Substrakt, \n \'*\' - Multiply, \n \'/\' - Divide");
                Console.Write("Make your choise:");
                string action = Console.ReadLine();

                switch (action)
                {
                    case "+":
                        calculateDelegate = new Calculate(Add);
                        break;
                    case "-":
                        calculateDelegate = new Calculate(Sub);
                        break;
                    case "*":
                        calculateDelegate = new Calculate(Mult);
                        break;
                        case "/":
                        calculateDelegate = new Calculate(Div);
                        break;

                    default:
                        Console.WriteLine("Unknown action");
                        calculateDelegate = null;
                        break;
                }
                
                Console.WriteLine("Result : " + calculateDelegate.Invoke(a,b).ToString());
            }
        }


        private static double Add(double a, double b) => a + b;
        private static double Sub(double a, double b) => a - b;
        private static double Mult(double a, double b) => a * b;
        private static double Div(double a, double b) => b == 0 ? 0 : a / b;

        
    }
}