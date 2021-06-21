using System;
using System.Globalization;

namespace URI_1009
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que exibe o salário e comissão de funcionário
            string vendedor;
            double salario, valorMes;
            double salarioFinal;

            Console.WriteLine("Insira o nome do Vendedor:");
            vendedor = Console.ReadLine();
            salario = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            valorMes = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);

            salarioFinal = valorMes * 0.15 + salario;

            Console.WriteLine("Total = R$ " + salarioFinal.ToString("F2", CultureInfo.InvariantCulture));



            Console.ReadLine();
        }
    }
}
