using System;
using System.Globalization;

namespace Exercício_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine()); //Conversão de tipo de dados.
            char ch = char.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            String[] vet = Console.ReadLine().Split(' ');
            String nome = vet[0];
            char sexo = char.Parse(vet[1]);
            int idade = int.Parse(vet[2]);
            double altura = double.Parse(vet[3]);




            Console.WriteLine("Você digitou: " + num1);
            Console.WriteLine("E seu sexo é: " + ch);
            Console.WriteLine("O número digitado foi: "+ n2);
            Console.WriteLine(nome);
            Console.WriteLine(sexo);
            Console.WriteLine(idade);
            Console.WriteLine(altura.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
