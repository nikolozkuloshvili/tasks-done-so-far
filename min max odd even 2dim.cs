namespace ConsoleApp28102025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[10, 8];
            int sum = 0;
            int even_sum = 0;
            int odd_sum = 0;
            int max = int.MinValue;
            int min = int.MaxValue;
            int even_max = int.MinValue;
            int even_min = int.MaxValue;
            int odd_max = int.MinValue;
            int odd_min = int.MaxValue;
            int even_amount = 0;
            int odd_amount = 0;

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    x[i, j] = Random.Shared.Next(10, 100);
                    Console.Write($"{x[i, j]} ");

                    sum += x[i, j];
                    if (x[i, j] > max) max = x[i, j];
                    if (x[i, j] < min) min = x[i, j];

                    if (x[i, j] % 2 == 0)
                    {
                        even_sum += x[i, j];
                        if (x[i, j] > even_max) even_max = x[i, j];
                        if (x[i, j] < even_min) even_min = x[i, j];
                        even_amount++;
                    }
                    else
                    {
                        odd_sum += x[i, j];
                        if (x[i, j] > odd_max) odd_max = x[i, j];
                        if (x[i, j] < odd_min) odd_min = x[i, j];
                        odd_amount++;
                    }
                }
                Console.WriteLine();
            }

            double average = (double)sum / x.Length;
            double even_average = (double)even_sum / even_amount;
            double odd_average = (double)odd_sum / odd_amount;

            Console.WriteLine();

            if (even_amount == x.Length)
            {
                Console.WriteLine("There are only Even numbers");
                Console.WriteLine($"Sum of Evens = {even_sum}");
                Console.WriteLine($"Max Even = {even_max}");
                Console.WriteLine($"Min Even = {even_min}");
                Console.WriteLine($"Average of Evens = {(even_average % 1 == 0 ? $"{even_average}" : $"{even_average:0.00}")}");
            }
            else if (odd_amount == x.Length)
            {
                Console.WriteLine("There are only Odd numbers");
                Console.WriteLine($"Sum of Odds = {odd_sum}");
                Console.WriteLine($"Max Odd = {odd_max}");
                Console.WriteLine($"Min Odd = {odd_min}");
                Console.WriteLine($"Average of Odds = {(odd_average % 1 == 0 ? $"{odd_average}" : $"{odd_average:0.00}")}");
            }
            else
            {
                Console.WriteLine("There are both Odd and Even numbers");
                Console.WriteLine($"Number of Evens = {even_amount}");
                Console.WriteLine($"Number of Odds = {odd_amount}");
                Console.WriteLine($"Total Sum = {sum}");
                Console.WriteLine($"Max from both = {max}");
                Console.WriteLine($"Min from both = {min}");
                Console.WriteLine($"Max Even = {even_max}");
                Console.WriteLine($"Min Even = {even_min}");
                Console.WriteLine($"Max Odd = {odd_max}");
                Console.WriteLine($"Min Odd = {odd_min}");
                Console.WriteLine($"Average from both = {(average % 1 == 0 ? $"{average}" : $"{average:0.00}")}");
                Console.WriteLine($"Average Evens = {(even_average % 1 == 0 ? $"{even_average}" : $"{even_average:0.00}")}");
                Console.WriteLine($"Average Odds = {(odd_average % 1 == 0 ? $"{odd_average}" : $"{odd_average:0.00}")}");
            }
        }
    }
}
