namespace Delegate_Calc
    
    ///Delegate Calculator
    ///
{
    public class MyEvent
    {
        public event ErrorDelegate Error = null;

        public void InvokeEvent()
        {
            Error.Invoke();
        }
    }

    internal class Program
    {
        private static void Handler()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Divide by zero");
            Console.ForegroundColor = ConsoleColor.White;
        }


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

                        if (b==0)
                        {
                            MyEvent instance = new MyEvent();
                            instance.Error += Handler;
                            instance.InvokeEvent();
                        }
                        else
                        {
                            calculateDelegate = new Calculate(MathActions.Div);
                        }
                        
                        break;

                    default:
                        correctAction = false;
                        Console.WriteLine("Incorrect action");
                        break;
                }

                if (correctAction && (b!=0))
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