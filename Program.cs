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
        }
    }
}