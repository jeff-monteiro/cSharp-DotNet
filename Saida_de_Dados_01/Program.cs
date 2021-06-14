using System;

namespace Workspace
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = 10.2456;
            int num = 26;
            String nome = "Jefferson Monteiro";
            char sexo = 'M';


            Console.WriteLine(n);
            Console.WriteLine(num);
            Console.WriteLine(sexo);
            Console.WriteLine(nome);
            Console.WriteLine("O paciente " + nome + " tem " + num + " de idade do sexo " + sexo + " recebe " + n + " por dia");


            Console.ReadLine();
        }
    }
}
