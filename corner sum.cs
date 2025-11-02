namespace codename01112025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = Random.Shared.Next(2, 13);
            int[,] x = new int[size, size];
            int mid = size / 2;
            int sum1 = 0, sum2 = 0;
            int corner = size - 1;

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    x[i, j] = Random.Shared.Next(10, 11);

                    if ((i == 0 || i == corner) && (j == 0 || j == corner))
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        sum1 += x[i, j];
                    }
                    else if (size % 2 != 0 && i == mid && j == mid)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        sum1 += x[i, j];
                    }
                    else
                    {
                        Console.ResetColor();
                    }

                    Console.Write($"{x[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.ResetColor();

            if (size % 2 != 0)
            {
                Console.WriteLine($"Sum of corners and middle number (size = odd) = {sum1}");
            }
            else
            {
                for (int i = 0; i < size; i += corner)
                {
                    for (int j = 0; j < size; j += corner)
                    {
                        sum2 += x[i, j];
                    }
                }
                Console.WriteLine($"Sum of just corners (size = even) = {sum2}");
            }
        }
    }
}
