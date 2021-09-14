using System;
using System.Globalization;

namespace DIO01
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            double nota1, nota2, nota3, nota4, mediaFinal;

            Console.WriteLine("Insira o nome do aluno: ");
            nome = Console.ReadLine();
            Console.WriteLine("Insira a nota1");
            nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira a nota2");
            nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira a nota3");
            nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira a nota4");
            nota4 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaFinal = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("A média final do aluno: " + nome + " foi: " + mediaFinal.ToString("F2", CultureInfo.InvariantCulture));

            if(mediaFinal >= 7){
                Console.WriteLine("Aluno: " + nome + "APROVADO!");
            }
        }
    }
}
