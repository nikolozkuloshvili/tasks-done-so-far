namespace codename01112025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = Random.Shared.Next(2, 13);
            int[,] x = new int[size, size];
            int mid = size / 2;
            int borderSum = 0;


            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    x[i, j] = Random.Shared.Next(10, 11);

                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        borderSum += x[i, j];
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
            Console.WriteLine($"Border sum = {borderSum}");
        }
    }
}
