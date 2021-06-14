using System;
using System.Globalization;

namespace Curso.Net
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 10.2355;

            Console.WriteLine(number);
            Console.WriteLine(number.ToString("F4"));
            Console.WriteLine(number.ToString("F2"));


            Console.WriteLine(number.ToString("F2", CultureInfo.InvariantCulture));
            
            Console.ReadLine();
        }
    }
}
