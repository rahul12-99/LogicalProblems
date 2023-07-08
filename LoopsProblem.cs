using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProblems
{
    internal class LoopsProblem
    {
        public static void drawParallelogram()
        {
            for (var j = 0; j < 5; j++)
            {
                for (var k = 0; k < 5 - j; k++)
                {
                    Console.Write(" ");
                }
                for (var m = 0; m < 15; m++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        public static void fractionSum(int num)
        {
            double sum = 0.0;
            for (int i = 1; i <= num; i++)
            {
                sum += (1 / (double)(i * i));
            }
            Console.WriteLine(sum);

        }

        public static string fullSequenceOfLetters(string word)
        {
            string fullSequence = string.Empty;
            for (int i = word[0], j = 0; i <= word[1]; i++, j++)
            {
                fullSequence += (char)(word[0] + j);
            }

            return fullSequence;
        }

        public static void PrintMultiplicationTable()
        {
            // Print the header row
            Console.Write("     ");
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i,4}");
            }
            Console.WriteLine();
            Console.WriteLine("----" + new string('-', 40));

            // Print the table
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i,2} | ");
                for (int j = 1; j <= 10; j++)
                {
                    int product = i * j;
                    Console.Write($"{product,4}");
                }
                Console.WriteLine();
            }
        }

        public static void PrintPrimes(int n)
        {
            for (int number = 2; number <= n; number++)
            {
                bool isPrime = true;

                for (int divisor = 2; divisor <= Math.Sqrt(number); divisor++)
                {
                    if (number % divisor == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.Write(number + " ");
                }
            }
        }
    }
}
