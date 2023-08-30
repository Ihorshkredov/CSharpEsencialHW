using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_Calc
{
    public static class MathActions
    {
        public static Action DevideByZeroEvent = null;


        public static double? Add(double a, double b) => a + b;
        public static double? Sub(double a, double b) => a - b;
        public static double? Mult(double a, double b) => a * b;
        public static double? Div(double a, double b)
        {
            if (b == 0)
            {
                DevideByZeroEvent.Invoke();
                return null;

            }
            else
            {
                return a / b;

            } 
        } 

    }
}
