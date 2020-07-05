using System;
using System.Text.RegularExpressions;

namespace ArithmeticOptionSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regex = new Regex(@"(^\-?\d+\.?\d*[\+\-\*\/\%]{1}\d+\.?\d*)|(^\-?\d+[\+\-]{2}$)|(^[\+\-]{2}\d+$)");
            Console.WriteLine("Введите выражение:");
            string str = Console.ReadLine();
            str = str.Replace(" ", "");
            if (regex.IsMatch(str))
            {
                Console.WriteLine("Выражение соответствует синтаксису языка");
            }
            else Console.WriteLine("Выражение не соответствует синтаксису языка");
            Console.ReadKey();
        }
    }
}
