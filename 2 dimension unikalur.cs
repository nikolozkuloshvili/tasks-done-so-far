namespace codename02112025
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
                    int y;
                    bool IsRepeated;

                    do
                    {
                        y = Random.Shared.Next(100);
                        IsRepeated = false;

                        for (int a = 0; a < x.GetLength(0); a++)
                        {
                            for (int b = 0; b < x.GetLength(1); b++)
                            {
                                if (x[a, b] == y)
                                {
                                    IsRepeated = true;
                                    break;
                                }
                            }
                            if (IsRepeated) 
                            break;
                        }

                    } while (IsRepeated);

                    x[i, j] = y;
                    Console.WriteLine($"x[{i},{j}] = {x[i, j]}");
                }
            }
        }
    }
}
