using System;
using System.Globalization;

namespace SecondChallengeDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            double X, Y;

            X = double.Parse(Console.ReadLine());
            Y = double.Parse(Console.ReadLine());

            double soma = X + Y;

            Console.WriteLine("O valor da soma dos valores é: "+ soma.ToString("F2"));

        }
    }
}
