using System;

namespace DIO02
{
    class Program
    {
        static void Main(string[] args)
        {
           int menu = 0;

            Console.WriteLine("Escolha sua opção: 1: Abrir Netflix ---- 2: Abrir Amazon Prime ---- 3: Abrir HBO MAX ---- 4: Sair da Aplicação");
            switch(menu)
            {
                case 1: 
                Console.WriteLine("Abrindo Netflix!");
                break;
                case 2: 
                Console.WriteLine("Abrindo Amazon Prime!");
                break;
                case 3:
                Console.WriteLine("Abrindo HBO MAX!");
                break;
                case 4:
                Console.WriteLine("Saindo da Aplicação...");
                break;
                default:
                Console.WriteLine("Valor desconhecido");
                break;
                
            }
            
        }
    }
}
