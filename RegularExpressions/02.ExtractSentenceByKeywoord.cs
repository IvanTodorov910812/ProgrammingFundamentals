namespace _03.RegExercises
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading.Tasks;

    public class ExtractSentence
    {
        public static void Main()
        {
            string word = Console.ReadLine();
            string[] text = Console.ReadLine()
                .Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries));

            var pattern = "\\b" + "to" + "\\b"; // WORD BOUNDARY
            Regex regex = new Regex(pattern);

            foreach (var sentence in text)
            {
                if (regex.IsMatch(sentence))
                {
                    Console.WriteLine(sentence.Trim());
                }
            }
        }
    }
}