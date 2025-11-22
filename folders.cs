namespace G10_20251121
{
    internal class Program
    {
        static void Main()
        {
            string path;
            while (true)
            {
                //es nawili cota davgugle, cota foe foe mindoda yofiliyo ☻ .

                Console.WriteLine("Choose a folder path:");
                Console.WriteLine("1 - F:\\1");
                Console.WriteLine("2 - C:\\Program Files");
                Console.Write("Enter 1 or 2: ");

                string choice = Console.ReadLine();

                if (choice == "1")
                    path = @"F:\1";
                else if (choice == "2")
                    path = @"C:\Program Files";
                else
                {
                    Console.WriteLine("Invalid choice. Try again.");
                    continue;
                }

                if (Directory.Exists(path))
                    break;
                else
                    Console.WriteLine("The selected path does not exist. Try again.");
            }

            PrintDirectories(path);
        }

        static void PrintDirectories(string path)
        {
            string[] currentLevel = new string[] { path };

            while (currentLevel.Length > 0)
            {
                int totalSubFolders = 0;
                foreach (string folder in currentLevel)
                {
                    string[] subDirs = Directory.GetDirectories(folder);
                    totalSubFolders += subDirs.Length;
                }

                string[] nextLevel = new string[totalSubFolders];
                int index = 0;

                foreach (string folder in currentLevel)
                {
                    Console.WriteLine(folder);

                    string[] subDirs = Directory.GetDirectories(folder);
                    for (int i = 0; i < subDirs.Length; i++)
                    {
                        nextLevel[index++] = subDirs[i];
                    }
                }

                currentLevel = nextLevel;
            }
        }
    }
}
