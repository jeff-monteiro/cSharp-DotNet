using System;
using System.Globalization;

namespace URI_1010
{
    class Program
    {
        static void Main(string[] args)
        {
            //Calculadora de cesta de produtos simples.
            int cod1, cod2, qtd1, qtd2;
            double preco1, preco2, total;

            string[] valores = Console.ReadLine().Split(' ');
            cod1 = int.Parse(valores[0]);
            qtd1 = int.Parse(valores[1]);
            preco1 = double.Parse(valores[2], CultureInfo.InvariantCulture);

            valores = Console.ReadLine().Split(' ');
            cod2 = int.Parse(valores[0]);
            qtd2 = int.Parse(valores[1]);
            preco2 = double.Parse(valores[2]);

            total = preco1 * qtd1 + preco2 * qtd2;

            Console.WriteLine("Valor a pagar = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
