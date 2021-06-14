using System;
using System.Globalization;

namespace Média_Idade
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome1, nome2;
            int idade1, idade2;
            string[] v;

            v = Console.ReadLine().Split(' ');
            nome1 = v[0];
            idade1 = int.Parse(v[1]);

            v = Console.ReadLine().Split(' ');
            nome2 = v[0];
            idade2 = int.Parse(v[1]);

            double mediaIdade = (double)(idade1 + idade2)/ 2;//Casting.
            

            Console.WriteLine("A idade média entre " + nome1 + " e " + nome2 + " é de: " + mediaIdade.ToString("F1", CultureInfo.InvariantCulture) + " anos.");

        }
    }
}
