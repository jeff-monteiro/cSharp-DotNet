using System;

namespace Exercício_Resolvido_03
{
    class Program
    {
        static void Main(string[] args)
        {
           int num1, num2, num3;

           String[] vet = Console.ReadLine().Split(',');

           num1 = int.Parse(vet[0]);
           num2 = int.Parse(vet[1]);
           num3 = int.Parse(vet[2]);

           

           if(num1 < num2 && num1 < num3){
               Console.WriteLine("O número: "+ num1 + " é o menor número!");
           }else if(num2 < num3){
               Console.WriteLine("Menor: " + num2);
           }else{
               Console.WriteLine("Menor: " + num3);
           }
               
           


        //    Console.WriteLine(num1);
        //    Console.WriteLine(num2);
        //    Console.WriteLine(num3);
           

           Console.ReadLine();
        }
    }
}
