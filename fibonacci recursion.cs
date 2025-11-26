namespace codename_26112025
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a fibonacci number : ");
            int enteredFibNum = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= enteredFibNum; i++)
            {
                int fibonacciNum = GetFibonacci(i);

                if ( fibonacciNum > enteredFibNum)
                {
                    break;
                }
                Console.WriteLine(GetFibonacci(i));
            }
        }

        static int GetFibonacci(int enteredFibNum)
        {
            if (enteredFibNum == 0)
            {
                return 0;
            }
            if (enteredFibNum == 1)
            {
                return 1;
            }
            return GetFibonacci(enteredFibNum - 1) + GetFibonacci(enteredFibNum - 2);
        }
    }
}
