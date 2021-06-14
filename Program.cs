using System;
using System.Collections.Generic;
using System.Text;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1; double num2; int resul = 0;

            Console.WriteLine("Insira um número ");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Insira outro número ");
            num2 = double.Parse(Console.ReadLine());

            while (resul != 5)
            {
                Console.WriteLine("Somar digite 1");
                Console.WriteLine("Subtrair digite 2");
                Console.WriteLine("Dividir digite 3");
                Console.WriteLine("Multiplicar digite 4");
                Console.WriteLine("Para sair digite 5");
                resul = int.Parse(Console.ReadLine());

                if (resul == 1){
                    Console.WriteLine("Soma = {0}", num1 + num2);
                }
                if (resul == 2){
                    Console.WriteLine("Subtração = {0}", num1 - num2);
                }
                if (resul == 3){
                    Console.WriteLine("Divisão = {0}", num1 / num2);
                }
                if (resul == 4){
                    Console.WriteLine("Multiplicação = {0}", num1 * num2);
                }
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
