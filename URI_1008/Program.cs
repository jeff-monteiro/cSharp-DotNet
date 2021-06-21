using System;
using System.Globalization;

namespace URI_1008
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programa que mostra salário di funcionário.
            int matricula, horas;
            double valorHora, salario;

            matricula = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            salario = valorHora * horas;
            
            Console.WriteLine("NÚMERO = " + matricula);
            Console.WriteLine("SALÁRIO =  U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadLine();
        }
    }
}
