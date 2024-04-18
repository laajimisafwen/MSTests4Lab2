namespace AppToBeTested
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            // Test Case 1
            int result1 = calculator.Sum(5, 10);
            Console.WriteLine($"Test Case 1: Expected Result = 15, Actual Result = {result1}");
            Console.WriteLine($"Test Case 1 Passed? {result1 == 15}\n");
            // Test Case 2
            int result2 = calculator.Sum(-3, 7);
            Console.WriteLine($"Test Case 2: Expected Result = 4, Actual Result = {result2}");
            Console.WriteLine($"Test Case 2 Passed? {result2 == 4}\n");
        }
    }
}
