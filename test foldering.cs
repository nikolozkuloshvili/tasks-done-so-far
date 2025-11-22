namespace G10_20251121
{
    internal class Program
    {
        static void Main()
        {
            const string path = @"F:\1";
            PrintDirectoriesLevel1(path);
        }

        static void PrintDirectoriesLevel1(string path)
        {
            string[] level1 = Directory.GetDirectories(path);
            if (level1.Length == 0) return;

            for (int i = 0; i < level1.Length; i++)
            {
                Console.WriteLine(level1[i]);
                PrintDirectoriesLevel2(level1[i]);
            }
        }

        static void PrintDirectoriesLevel2(string folder)
        {
            string[] level2 = Directory.GetDirectories(folder);
            if (level2.Length == 0) return;

            for (int i = 0; i < level2.Length; i++)
            {
                Console.WriteLine(level2[i]);
                PrintDirectoriesLevel3(level2[i]);
            }
        }

        static void PrintDirectoriesLevel3(string folder)
        {
            string[] level3 = Directory.GetDirectories(folder);
            if (level3.Length == 0) return;

            for (int i = 0; i < level3.Length; i++)
            {
                Console.WriteLine(level3[i]);
                PrintDirectoriesLevel4(level3[i]);
            }
        }

        static void PrintDirectoriesLevel4(string folder)
        {
            string[] level4 = Directory.GetDirectories(folder);
            if (level4.Length == 0) return;

            for (int i = 0; i < level4.Length; i++)
            {
                Console.WriteLine(level4[i]);
                PrintDirectoriesLevel5(level4[i]);
            }
        }

        static void PrintDirectoriesLevel5(string folder)
        {
            string[] level5 = Directory.GetDirectories(folder);
            if (level5.Length == 0) return;

            for (int i = 0; i < level5.Length; i++)
            {
                Console.WriteLine(level5[i]);
            }
        }
    }
}
