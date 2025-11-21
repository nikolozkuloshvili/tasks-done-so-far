namespace G10_20251121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many Names should i write? = ");

            int newSize = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Here are the {newSize} names as you requested: ");

            string[] array = { "nikoloz", "giorgi", "tamta", "david", "ana", "luka", "saba", "nino", "elene" };

            Resize(ref array, newSize);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(array[i]);
            }
        }
        static void Resize(ref string[] array, int newSize)
        {
            string[] newArray = new string[newSize];

            for (int i = 0; i < array.Length && i < newSize; i++)
            {
                newArray[i] = array[i];
            }

            array = newArray;
        }
    }
}
