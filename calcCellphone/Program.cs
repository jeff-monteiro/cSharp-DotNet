using System;
using System.Globalization;

namespace calcCellphone{
    class Program{
        static void Main(string[] args){

            int minutos;
            double conta;

            minutos = int.Parse(Console.ReadLine());

            conta = 50.0;
            if(minutos > 100){
                conta = conta + (minutos - 100) * 2.0;
            }
            Console.WriteLine("O valor a pagar em R$ " + conta.ToString("F2"));

        }
    }
}