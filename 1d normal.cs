namespace codename11112025
{
    internal class Program
    {
        static void Main()
        {
            Random random = new Random();

            int xSize = random.Next(3, 10);
            int ySize = random.Next(3, 10);

            Console.WriteLine($"x array Size = {xSize}");
            Console.WriteLine($"y array Size = {ySize}");
            Console.WriteLine();

            int[] x = new int[xSize];
            int[] y = new int[ySize];

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = random.Next(1, 100);
                Console.WriteLine($"x[{i}] = {x[i]}");
            }

            Console.WriteLine();

            for (int i = 0; i < y.Length; i++)
            {
                y[i] = random.Next(1, 100);
                Console.WriteLine($"y[{i}] = {y[i]}");
            }

            int xSum = GetSum(x);
            int ySum = GetSum(y);

            Console.WriteLine();
            Console.WriteLine($"Sum of x array: {xSum}");
            Console.WriteLine($"Sum of y array: {ySum}");
            Console.WriteLine($"Total sum: {xSum + ySum}");
            Console.WriteLine($"Average of x: {GetAverage(x)}");
            Console.WriteLine($"Average of y: {GetAverage(y)}");
            Console.WriteLine($"Max of x: {GetMax(x)}");
            Console.WriteLine($"Max of y: {GetMax(y)}");
            Console.WriteLine($"Min of x: {GetMin(x)}");
            Console.WriteLine($"Min of y: {GetMin(y)}");

            GetEven(x);
            GetEven(y);
            GetOdd(x);
            GetOdd(y);
        }

        static int GetSum(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                  sum += array[i];
            }
            return sum;
        }

        static double GetAverage(int[] array)
        {
            return (double)GetSum(array) / (array.Length);
        }

        static int GetMax(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }

        static int GetMin(int[] array)
        {
            int min = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            return min;
        }

        static void GetEven(int[] array)
        {
            int even_sum = 0;
            int even_max = int.MinValue;
            int even_min = int.MaxValue;
            int even_count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    even_sum += array[i];
                    if (array[i] > even_max)
                    {
                        even_max = array[i];
                    }
                    if (array[i] < even_min)
                    {
                        even_min = array[i];
                    }
                    even_count++;
                }
            }

            Console.WriteLine($"Even count: {even_count}, Even sum: {even_sum}, Max: {even_max}, Min: {even_min}");
        }

        static void GetOdd(int[] array)
        {
            int odd_sum = 0;
            int odd_max = int.MinValue;
            int odd_min = int.MaxValue;
            int odd_count = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    odd_sum += array[i];
                    if (array[i] > odd_max)
                    {
                        odd_max = array[i];
                    }
                    if (array[i] < odd_min)
                    {
                        odd_min = array[i];
                    }
                    odd_count++;
                }
            }

            Console.WriteLine($"Odd count: {odd_count}, Odd sum: {odd_sum}, Max: {odd_max}, Min: {odd_min}");
        }
    }
}
