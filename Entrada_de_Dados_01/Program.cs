using System;

namespace Exercício_04
{
    class Program
    {
        static void Main(string[] args)
        {
            String frase = Console.ReadLine();
            String x = Console.ReadLine();
            String y = Console.ReadLine();
            String z = Console.ReadLine();

            String[] vet = Console.ReadLine().Split(' ');
            String p1 = vet[0];
            String p2 = vet[1];
            String p3 = vet[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);
            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);


            Console.ReadLine();

        }
    }
}
