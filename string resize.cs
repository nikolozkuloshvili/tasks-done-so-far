namespace G10_20251121
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many Names should i write? = ");

            int newLength = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Here are the {newLength} names as you requested: ");

            string[] array = { "nikoloz", "giorgi", "tamta", "david", "ana", "luka", "saba", "nino", "elene" };

            Resize(ref array, newLength);

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine();
                Console.WriteLine(array[i] ?? "No name found");
            }
        }
        static void Resize(ref string[] array, int newLength)
        {
            string[] newArray = new string[newLength];
            int length = array.Length < newLength ? array.Length : newLength;
            if (array.Length == newLength)
            {
                return;
            }
            for (int i = 0; i < length; i++)
            {
                newArray[i] = array[i];
            }
            array = newArray;
        }
    }
}
