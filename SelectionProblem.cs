using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class SelectionProblem
    {
        public static void absoluteValue(int N)
        {
            if (N < 0)
            {
                N = (-1) * N;
            }
            Console.WriteLine(N);
        }

        public static void ifAscendingOrder(int[] arr)
        {
            if (arr[0] < arr[1] && arr[1] < arr[2])
            {
                Console.WriteLine("Yes we are in ascending order");
            }
            else
            {
                Console.WriteLine("No We are not in ascending order");
            }
        }

        public static void divisibleBy2Or3(int a, int b)
        {
            if (a % 2 == 0 && b % 2 == 0 || a % 3 == 0 && b % 3 == 0)
            {
                Console.WriteLine(a * b);
            }
            else
            {
                Console.WriteLine(a + b);
            }
        }
        public static bool ifNumberIsEven(int num)
        {
            return num % 2 == 0;
        }
        public static bool ifGreaterThanThirdOne(int[] arr)
        {
            return arr[0] + arr[1] > arr[2] || arr[0] * arr[1] > arr[2];
        }
    }

}
