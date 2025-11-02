namespace codename01112025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            do
            {
                size = Random.Shared.Next(5, 15);
            } while (size % 2 == 0); 

            int[,] x = new int[size, size];
            int sum1 = 0, sum2 = 0;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    x[i, j] = Random.Shared.Next(10, 100);

                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        sum1 += x[i, j];
                    }
                    else if (i + j == size - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        sum2 += x[i, j];
                    }
                    else
                    {
                        Console.ResetColor();
                    }
                    Console.Write($"{x[i, j]} ");
                }
                Console.WriteLine();
            }

            int sum = sum1 + sum2;

            Console.ResetColor();
            Console.WriteLine($"Sum of first diagonal = {sum1}");
            if (size % 2 == 0)
            {
                Console.WriteLine($"Sum of second diagonal = {sum2}");
            }
            else
            {
                Console.WriteLine($"Sum of second diagonal without central number = {sum2}");
            }
            Console.WriteLine($"Sum = {sum}");
        }
    }
}