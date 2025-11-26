namespace codename12112025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int upperBound;
            Console.Write("Enter upper bound number for fibonacci numbers: ");
            upperBound = int.Parse(Console.ReadLine()!);
            WriteFibonacciNumbers(upperBound);
        }
        static void WriteFibonacciNumbers(int upperBound)
        {
            int firstNum = 0;
            int secondNum = 1;
            
            Console.WriteLine(firstNum);
            if (upperBound > 1)
                Console.WriteLine(secondNum);

            int nextNum = firstNum + secondNum;

            while (nextNum < upperBound)
            {
                Console.WriteLine(nextNum);
                firstNum = secondNum;
                secondNum = nextNum;
                nextNum = firstNum + secondNum;
            }
        }
    }
}
