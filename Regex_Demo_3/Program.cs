using System;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_Demo_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var html = ReadInput();

            var matches = Regex.Matches(html, "<.+?");

            if (matches.Count > 0)
            {
                foreach (var match in matches)
                {
                    Console.WriteLine(match);
                }
            }
            else
            {
                Console.WriteLine(matches);
            }
        }

        private static string ReadInput()
        {
            StringBuilder sb = new StringBuilder();

            string line = Console.ReadLine();

            while (line != "END")
            {
                sb.Append(line);
                line = Console.ReadLine();
            }
            return sb.ToString();
        }
    }
}
