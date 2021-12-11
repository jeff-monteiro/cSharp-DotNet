using System;
using System.Globalization;

namespace switchCommand {
    class Program{
        static void Main(string[] args){
           
           int x = int.Parse(Console.ReadLine());
           String dia;

           if(x == 1){
               dia = "Sunday";
           }else if(x == 2) {
               dia = "Monday";
           }else if(x == 3) {
               dia = "Tuesday";
           }else if(x == 4) {
               dia = "Wednesday";
           }else if(x == 5) {
               dia = "Thursday";
           }else if(x == 6) {
               dia = "Friday";
           }else if(x == 7) {
               dia = "Saturday";
           }else {
               Console.WriteLine("This day is not valid");
           }
           Console.WriteLine("The day of the week is: " + dia);
           Console.ReadLine();


        }
        
    }
}
