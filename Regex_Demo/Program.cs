using System;
using System.Text.RegularExpressions;

namespace Regex_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Телефона на Гошо е 0888123456, Телефона на Пешо е 0892014083 и Телефона на Лили е 0892332211";
            string replaceText = Regex.Replace(text, "(08)[0-9]{8}","08********");

            Console.WriteLine(replaceText);
        }
    }
}
