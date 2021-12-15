using System;
using System.Globalization;

namespace curso {
    class Program {
        static void Main(string[] args){
           
           Console.WriteLine("Insira o dia em que deseja fazer o agendamento.");
           int x = int.Parse(Console.ReadLine());
           string dia;

           switch (x) { //Sintáxe do comando SWITCH para estruturas encadeadas.
               case 1:
                    dia = "Domingo";
                    break;
               case 2:
                    dia = "Segunda";
                    break;
               case 3:
                    dia = "Terça";
                    break;
               case 4:
                    dia = "Quarta";
                    break;
               case 5:
                    dia = "Quinta";
                    break;
               case 6:
                    dia = "Quinta";
                    break;
               case 7:
                    dia = "Quinta";
                    break;
               default:
                    dia = "Dia não válido!";
                    break;     

           }
           Console.WriteLine("The day of the week is: "+ dia);
           Console.ReadLine();


        }
        
    }
}
