namespace G10_20251121
{
    internal class Program
    {
        static void Main()
        {
            const string path = @"F:\1";
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
