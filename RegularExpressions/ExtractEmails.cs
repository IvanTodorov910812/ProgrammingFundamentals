namespace _01.ExtractEmails
{
    using System;
    using System.Text.RegularExpressions;

    public class ExtractEmails
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            string pattern = @"([\w-.]+\@[a-zA-Z-]+)(\.[a-zA-Z-]+)+";

        
            Regex regex = new Regex(pattern);
            MatchCollection matches = regex.Matches(input);

            foreach (Match match in matches)
            {
                string machtString = match.ToString();

                if (!(machtString.StartsWith("-") ||
                    machtString.StartsWith("_") ||
                    machtString.StartsWith(".") ||
                    machtString.EndsWith("-") ||
                    machtString.EndsWith("_") ||
                    machtString.EndsWith(".")))
                {
                    Console.WriteLine(match);
                }
            }
        }
    } 
}
