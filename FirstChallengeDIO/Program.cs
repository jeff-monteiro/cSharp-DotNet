using System;

namespace FirstChallengeDIO
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] test = Console.ReadLine().Split(" ");
            double X = double.Parse(test[0]);
            double Y = double.Parse(test[1]);

            if(Y == 0){
                Console.WriteLine("divisão impossível");
            }else{
                double divisao = X / Y;
                Console.WriteLine(divisao.ToString("F2"));
            }
        }
    }
}
