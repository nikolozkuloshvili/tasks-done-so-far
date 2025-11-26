namespace codename_27112025
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

            if (array.Length == newLength)
            {
                return;
            }

            if (newLength > array.Length)
            {
                int expandNum = newLength - array.Length;
                for (int i = 0; i < array.Length; i++)
                {
                    newArray[i + expandNum] = array[i];
                }
            }
            else if (newLength < array.Length)
            {
                int cutNum = array.Length - newLength;
                for (int i = 0; i < newLength; i++)
                {
                    newArray[i] = array[cutNum + i];
                }
            }
            array = newArray;
        }
    }
}
