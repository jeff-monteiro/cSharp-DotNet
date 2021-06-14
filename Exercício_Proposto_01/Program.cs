using System;
using System.Globalization;

namespace Exercício_Proposto_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira seu nome completo: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Quantos quartos tem na sua casa?");
            int quartos = int.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o preço do produto.");
            double preco = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            Console.WriteLine("Entre com seu último nome, idade e altura");
            string[] dados = Console.ReadLine().Split(' ');
            string lastname = dados[0];
            int age = int.Parse(dados[1]);
            double height = double.Parse(dados[2]);

            Console.WriteLine(nome);
            Console.WriteLine(quartos);
            Console.WriteLine(preco.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine(lastname);
            Console.WriteLine(age);
            Console.WriteLine(height.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();


        }
    }
}
