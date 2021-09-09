﻿using System;
using System.Globalization;

namespace URI_1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, r1, r2;

            a = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            b = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            if(a == 0 || delta < 0.0){
                Console.WriteLine("Impossível Calcular!");
            }
            else{
                r1 = (-b + Math.Sqrt(delta))/(2.0 * a);
                r2 = (-b - Math.Sqrt(delta))/(2.0 * a);
                Console.WriteLine("Resultado de R1 = "+ r1.ToString("F5", CultureInfo.InvariantCulture));
                Console.WriteLine("Resultado de R2 = "+ r2.ToString("F5", CultureInfo.InvariantCulture));
            }

            Console.ReadLine();
        }
    }
}
