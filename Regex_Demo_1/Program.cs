using System;
using System.Text.RegularExpressions;

namespace Regex_Demo_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            string pattern = "[AEIOUYaeeiouy]";

            Regex regex = new Regex(pattern);

            var matches = regex.Matches(text);

            int count = matches.Count;
            Console.WriteLine($"Гласни: {count}");

            
        }
    }
}
