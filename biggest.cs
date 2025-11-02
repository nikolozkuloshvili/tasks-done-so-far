namespace G10_141025
{
    internal class Program
    {
        static void Main()
        {
            int[] x = new int[3];
            x[0] = Random.Shared.Next(1, 10);
            x[1] = Random.Shared.Next(1, 10);
            x[2] = Random.Shared.Next(1, 10);
            int biggest = x[0];
            string Biggest = "The Biggest number of X equals to: "

            if (x[1]>= biggest)
            {
                biggest = x[1];
            }
            if (x[2] >= biggest)
            {
                biggest = x[2]; 
            }
            Console.WriteLine($"x[0]: {x[0]}, x[1]: {x[1]}, x[2]: {x[2]}\n Biggest Number:{biggest}");
            // momidzebnet ricxvebidan yvelaze didi da damiweret ekranze
        }
    }
}