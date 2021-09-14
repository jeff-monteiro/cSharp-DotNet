using System;

namespace DIO03
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador, limite, resultado, tabuada;

            contador = 1;
            limite = 10;

            Console.WriteLine("Qual a tabuada você deseja utilizar?");
            tabuada = int.Parse(Console.ReadLine());

            do
            {
                resultado = tabuada * contador;
                Console.WriteLine(tabuada + " x " + contador + " = " + resultado);
                contador++;
            }while (contador <= limite);
        }
    }
}
