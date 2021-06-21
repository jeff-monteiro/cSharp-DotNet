using System;
using System.Globalization;

namespace URI_1011
{
    class Program
    {
        static void Main(string[] args)
        {
            //programa que clacula e mostra o volume de uma esfera.
            double raio, volume;
            
            raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            volume = 4.0 / 3 * 3.14159 * raio * raio * raio;

            Console.WriteLine("Volume = " + volume.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
