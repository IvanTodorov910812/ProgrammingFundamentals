namespace FolderSize
{
    using System;
    using System.IO;

    public class FolderSize
    {
        public static void Main()
        {
            string[] directoryFiles = Directory.GetFiles(@"..\..\TestFolder");
            double size = 0;

            foreach (string file in directoryFiles)
            {
                FileInfo info = new FileInfo(file);
                size += info.Length;
            }
            size = size / 1024 / 1024;

            Console.WriteLine(size);

            if (File.Exists(@"..\..\output.txt"))
            {
                File.Delete(@"..\..\output.txt");
            }
            File.AppendAllText(@"..\..\output.txt", string.Format("{0}", size));
        }
    }
}
