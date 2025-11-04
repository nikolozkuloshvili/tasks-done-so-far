namespace codename07112025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x = new int[5, 5];

            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    int random = 0;
                    bool isRepeated = true;

                    while (isRepeated)
                    {
                        random = Random.Shared.Next(25);
                        isRepeated = false;

                        for (int a = 0; a < x.GetLength(0); a++)
                        {
                            for (int b = 0; b < x.GetLength(1); b++)
                            {
                                if (i == a && j == b)
                                {
                                    break;
                                }
                                if (x[a, b] == random)
                                {
                                    isRepeated = true;
                                    break;
                                }
                            }
                        }
                    }
                    x[i, j] = random;
                    Console.Write($"x[{i},{j}] = {x[i, j]}");
                    Console.WriteLine();
                }
                Console.WriteLine();
            }
        }
    }
}
