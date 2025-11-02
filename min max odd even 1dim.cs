namespace date21102025
{
    internal class Program
    {
        static void Main()
        {
            int[] x = new int[10];
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
            int zero_amount = 0;

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Random.Shared.Next(100);

                if (x[i] == 0)
                {
                    zero_amount++;
                }
                else
                {
                    Console.Write($"x[{i}]: {x[i]} -");

                    sum += x[i];

                    if (x[i] > max)
                    {
                        max = x[i];
                    }

                    if (x[i] < min)
                    {
                        min = x[i];
                    }

                    if (x[i] % 2 == 0)
                    {
                        Console.WriteLine(" Even");
                        even_sum += x[i];
                        if (x[i] > even_max)
                        {
                            even_max = x[i];
                        }
                        if (x[i] < even_min)
                        {
                            even_min = x[i];
                        }
                        even_amount++;
                    }
                    else
                    {
                        Console.WriteLine(" Odd");
                        odd_sum += x[i];

                        if (x[i] > odd_max)
                        {
                            odd_max = x[i];
                        }
                        if (x[i] < odd_min)
                        {
                            odd_min = x[i];
                        }
                        odd_amount++;
                    }
                }
                if (zero_amount == x.Length)
                {
                    Console.WriteLine("All numbers are 0");
                    break;
                }
            }
            double average = (double)sum / x.Length;
            double even_average = (double)even_sum / even_amount;
            double odd_average = (double)odd_sum / odd_amount;

            if (zero_amount != x.Length)
            {
                if (even_amount == x.Length)
                {
                    Console.WriteLine("There are only Even numbers");
                    Console.WriteLine($"Sum of only Evens is {even_sum}");
                    Console.WriteLine($"Maximum from Evens is {even_max}");
                    Console.WriteLine($"Minimum from Evens is {even_min}");
                    if (even_average % 1 == 0)
                        Console.WriteLine($"Average of Evens is whole number = {even_average}");
                    else
                        Console.WriteLine($"Average of Evens is decimal = {even_average:0.00}");
                }
                else if (odd_amount == x.Length)
                {
                    Console.WriteLine("There are only Odd numbers");
                    Console.WriteLine($"Sum of only Odd's is {odd_sum}");
                    Console.WriteLine($"Maximum from Odds is {odd_max}");
                    Console.WriteLine($"Minimum from Odds is {odd_min}");
                    if (odd_average % 1 == 0)
                        Console.WriteLine($"Average of Odds is whole number = {odd_average}");
                    else
                        Console.WriteLine($"Average of Odds is decimal = {odd_average:0.00}");
                }
                else
                {
                    Console.WriteLine("There are both Odd and Even numbers");
                    Console.WriteLine($"Number of Even = {even_amount}");
                    Console.WriteLine($"Number of Odd = {odd_amount}");
                    Console.WriteLine($"Sum of Odds and Evens is {sum}");
                    Console.WriteLine($"Maximum from Odds and Evens is {max}");
                    Console.WriteLine($"Minimum from Odds and Evens is {min}");
                    Console.WriteLine($"Maximum from Evens is  {even_max}");
                    Console.WriteLine($"Minimum from Evens is {even_min}");
                    Console.WriteLine($"Maximum from Odds is {odd_max}");
                    Console.WriteLine($"Minimum from Odds is {odd_min}");
                    if (average % 1 == 0)
                        Console.WriteLine($"Average of Odds and Evens is whole number = {average}");
                    else
                        Console.WriteLine($"Average of Odds and Evens is decimal = {average:0.00}");
                    if (even_average % 1 == 0)
                        Console.WriteLine($"Average of Evens is whole number = {even_average}");
                    else
                        Console.WriteLine($"Average of Evens is decimal = {even_average:0.00}");
                    if (odd_average % 1 == 0)
                        Console.WriteLine($"Average of Odds is whole number = {odd_average}");
                    else
                        Console.WriteLine($"Average of Odds is decimal = {odd_average:0.00}");

                }
            }
        }
    }
}
