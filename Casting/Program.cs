using System;

namespace Exercício_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double resultado;

            a = 5;
            b = 2;

            resultado = (double)a / b; //Casting: Conversão de dados quando o compilador não sabe qual tipo de dado deve imprimir.

            Console.WriteLine(resultado);

            Console.ReadLine();
        }
    }
}
