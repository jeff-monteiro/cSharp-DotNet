using System;

namespace Exercício_EstruturaCondicional_II
{
    class Program
    {
        static void Main(string[] args)
        {
           int num1, num2, num3;

           num1 = int.Parse(Console.ReadLine());
           num2 = int.Parse(Console.ReadLine());
           num3 = int.Parse(Console.ReadLine());

           if(num1 < num2 && num1 < num3){
               Console.WriteLine("O número: "+ num1 + " é o menor número!");
           }


        //    Console.WriteLine(num1);
        //    Console.WriteLine(num2);
        //    Console.WriteLine(num3);
           

           Console.ReadLine();
        }
    }
}
