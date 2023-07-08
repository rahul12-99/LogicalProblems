using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class BasicProblem
    {
        public static void addTwoNumber(int a, int b, int d)
        {
            int c = (a + b) * d;
            Console.WriteLine(c);
        }

        public static string CtoF(double celsius)
        {
            double fahrenheit;

            if (celsius < -273.15)
            {
                return "Temperature below  zero!";
            }

            fahrenheit = celsius * 1.8 + 32;

            return $"T = {fahrenheit}F";
        }
        public static void EleOperations(int a, int b)
        {
            int add = a + b;
            int sub = a - b;
            int mul = a * b;
            double div = a / (double)b;
            Console.WriteLine(add + " " + sub + " " + mul + " " + div);
        }

        public static bool isTheResultSame(double a, double b)
        {
            return a == b;
        }

        public static void SwapTwoNumbers(int a, int b)
        {
            Console.WriteLine("Your number before swap : " + a + ", " + b);
            int temp = b;
            b = a;
            a = temp;
            Console.WriteLine("Your number after swap " + a + ", " + b);
        }

    }
}
