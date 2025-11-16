namespace codename18112025
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter upper bound number: ");
            int upperBound = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Numbers up to {upperBound} are:");

            int[] numbers = GetFibonacciNumbers(upperBound);
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }

        static int[] GetFibonacciNumbers(int upperBound)
        {
            int firstNum = 0, secondNum = 1, count = 0;
            int[] numbers = new int[0];
            while (firstNum <= upperBound)
            {
                Array.Resize(ref numbers, count + 1);
                numbers[count] = firstNum;
                int nextNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = nextNum;
                count++;
            }
            return numbers;
        }  //fibonacci da jandaba magas...
    }
}
