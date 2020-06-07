using System;
using System.Text.RegularExpressions;

namespace Regex_Demo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = "[^0-9]";
            Regex regex = new Regex(pattern);

            var matches = regex.Matches(text);

            int count = matches.Count;
            Console.WriteLine($"Различните от цифри са: {count}");
        }
    }
}
