// See https://aka.ms/new-console-template for more information
namespace Exercício_de_Entrada {

    class Program{
        static void Main(string[] args){

            String frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            String z = Console.ReadLine();


            String[] teste = Console.ReadLine().Split(' ');
            String p = teste[0];
            String b = teste[1];
            String j = teste[2];

            Console.WriteLine("Você digitou: " + frase);
            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

            Console.WriteLine(teste[0]);
            Console.WriteLine(teste[1]);
            Console.WriteLine(teste[2]);

        
            Console.WriteLine("Hello world!");
            Console.ReadLine();
        }
    }  
}
