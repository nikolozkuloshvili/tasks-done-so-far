namespace FoldersFolders_onceagain_Folders
{
    internal class Program
    {
        static void Main()
        {
            const string path = @"f:\1";
            PrintDirectories(path);

        }

        static void PrintDirectories(string path)
        {
            string[] StartPoint = new string[] { path };

            while (StartPoint.Length > 0)
            {
                int insideFolderAmount = 0;
                foreach (string folder in StartPoint)
                {
                    string[] insideFolders = Directory.GetDirectories(folder);
                    insideFolderAmount += insideFolders.Length;
                }

                string[] nextPoint = new string[insideFolderAmount];
                int j = 0;

                foreach (string folder in StartPoint)
                {
                    Console.WriteLine(folder);

                    if (insideFolderAmount == 0)
                    {
                        return;
                    }

                    string[] insideFolders = Directory.GetDirectories(folder);

                    for (int i = 0; i < insideFolders.Length; i++, j++)
                    {
                        nextPoint[j] = insideFolders[i];
                    }
                }

                StartPoint = nextPoint;
            }
        }
    }
}
