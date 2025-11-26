namespace ConsoleApp28102025
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] x = new int[10];

            for (int i = 0; i < x.Length; i++)
            {
                x[i] = Random.Shared.Next(15);

                for (int j = 0; j < i; j++)
                {
                    if (x[i] == x[j])
                    {
                        i--;
                        break;
                    }
                }
            }

            for (int i = 0; i < x.Length; i++)
            {
                Console.WriteLine($"x[{i}] = {x[i]}");
            }
        }
    }
}
