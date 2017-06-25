namespace LineNumbers
{
    using System.IO;
    using System;
    using System.Text;

    public class LineNumbers
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            string[] text = File.ReadAllLines(@"..\..\Input.txt");

            if (File.Exists(@"..\..\Output.txt"))
            {
                File.Delete("Output.txt");
            }

            for (int i = 0; i < text.Length; i++)
            {
                File.AppendAllText(@"..\..\Output.txt", string.Format("{0}. {1}\r\n", i + 1, text[i]));
            }
        }
    }
}
