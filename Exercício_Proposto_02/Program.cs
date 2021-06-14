using System;
using System.Globalization;

namespace Exercício_Proposto_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a largura do terreno");
            double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira o comprimento do terreno");
            double comprimento = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double area = largura * comprimento;
            Console.WriteLine("O tamanho do terreno é: " + area.ToString("F2", CultureInfo.InvariantCulture));

            Console.WriteLine("Insira o valor do m/2 do terreno");
            double valor = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double preco = area * valor;
            Console.WriteLine("O preço terreno em metros/2 é: " + preco.ToString("F2", CultureInfo.InvariantCulture));



            Console.ReadLine();
        }
    }
}
