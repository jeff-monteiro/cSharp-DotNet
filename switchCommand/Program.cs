using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args){
           
           int x = int.Parse(Console.ReadLine());
           string dia;

           switch (x) {
               case 1:
                    dia = "Domingo";
                    break;
               case 2:
                    dia = "Segunda";
                    break;
               case 3:
                    dia = "Terça";
                    break;     

           }
           Console.WriteLine("The day of the week is: " + dia);
           Console.ReadLine();


        }
        
    }
}
