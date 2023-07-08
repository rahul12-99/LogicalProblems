namespace LogicalProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Logical Problems Using c#");
            // This all program is basic program.
            BasicProblem.addTwoNumber(20, 25, 30);
            Console.WriteLine(BasicProblem.CtoF(-300));
            BasicProblem.EleOperations(20, 30);
            Console.WriteLine(BasicProblem.isTheResultSame(2 * 2, 2 + 2));
            BasicProblem.SwapTwoNumbers(10, 15);
            // This all program is for selection problem.
            SelectionProblem.absoluteValue(-345);
            SelectionProblem.ifAscendingOrder(new int[] { 4, 6, 8, 10 });
            SelectionProblem.divisibleBy2Or3(12, 18);
            Console.WriteLine(SelectionProblem.ifNumberIsEven(30));
            Console.WriteLine(SelectionProblem.ifGreaterThanThirdOne(new int[] { 4, 6, 8, 9 }));
            // This all program is for loops problem

            // This program is for print multiplication table
            LoopsProblem.PrintMultiplicationTable();
            // This program is for return the sum of 1 + (½)² + (⅓)² + ... + (1⁄n)².
            LoopsProblem.fractionSum(6);
            // This program is for return the prime number in a range
            Console.WriteLine("Enter a range greater than 2: ");
            int range = int.Parse(Console.ReadLine());
            LoopsProblem.PrintPrimes(range);
            Console.WriteLine();
            // This program is for draw parallelogram
            LoopsProblem.drawParallelogram();
            // This program is for return full sequence of letters
            Console.WriteLine(LoopsProblem.fullSequenceOfLetters("Ps"));
        }
    }
}