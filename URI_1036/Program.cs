﻿using System;
using System.Globalization;

namespace URI_1036
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, r1, r2;

            String[] vet = Console.ReadLine().Split(' '); 

            a = double.Parse(vet[0], CultureInfo.InvariantCulture);
            b = double.Parse(vet[1], CultureInfo.InvariantCulture);
            c = double.Parse(vet[2], CultureInfo.InvariantCulture);

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