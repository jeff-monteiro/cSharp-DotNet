using System;

namespace Funções_Math
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = 3.0;
            double y = 4.0;
            double z = 25.0;
            double A, B, C;

            A = Math.Sqrt(x); //exemplo de expressões utilizando a função SQRT para obter a raiz quadrada de um valor.
            B = Math.Sqrt(y);
            C = Math.Sqrt(z);
            Console.WriteLine("A raiz quadrada de " + x + " é " + A);
            Console.WriteLine("A raiz quadrada de " + y + " é " + B);
            Console.WriteLine("A raiz quadrada de " + z + " é " + C);

            A = Math.Pow(x, y); //exemplo de expressões utilizando a função POW para obter o resultado da potenciação de um valor.
            B = Math.Pow(x, 2.0);
            C = Math.Pow(5.0, 2.0);
            Console.WriteLine(x + " elevado por "+ y + " é igual a: " + A);
            Console.WriteLine(x + " elevado por 2 é igual a: " + B);
            Console.WriteLine("5 elevado por 2 é igual a: " + C);

            A = Math.Abs(y); //exemplo de expressões utilizando a função ABS para obter o valor absoluto de um número. 
            B = Math.Abs(z);
            Console.WriteLine("O valor absoluto de " + y + " é = " + A);
            Console.WriteLine("O valor absoluto de " + z + " é = " + B);


            Console.ReadLine();
        }
    }
}
