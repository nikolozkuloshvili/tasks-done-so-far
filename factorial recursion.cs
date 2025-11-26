namespace G10_20251121
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number to calculate its factorial: ");

            int factorialNum = Convert.ToInt32(Console.ReadLine());
            if (factorialNum < 0)
            {
                Console.WriteLine("Factorial is not defined for negative numbers.");
                return;
            }
            int result = writeFactorialNumbers(factorialNum);
            Console.WriteLine($"The factorial of {factorialNum} is: {result} ");;

        }
        static int writeFactorialNumbers(int factorialNum)
        {
            if (factorialNum == 1)
                return 1;

            return factorialNum * writeFactorialNumbers(factorialNum - 1);
        }
    }
}
