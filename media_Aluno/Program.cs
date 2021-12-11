using System;
using System.Globalization;

namespace media_Aluno{

    class Program{
        static void Main(string[] args){
        
            String nome;
            double av1, av2, av3, mediaFinal;

            Console.WriteLine("Insira seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine("Nota av1: ");
            av1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota av2: ");
            av2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota av3: ");
            av3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            mediaFinal = (av1 + av2 + av3) / 3;

            Console.WriteLine("A média final do aluno: " + nome + " foi " + mediaFinal.ToString("F2", CultureInfo.InvariantCulture));

            if(mediaFinal >= 6){
                Console.WriteLine("Aluno: Aprovado");
            }else{
                Console.WriteLine("Aluno: Reprovado");
            }
        }
    }   
}



        

