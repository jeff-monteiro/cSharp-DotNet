using System;

namespace Exercício_02
{
    class Teste01
    {
        static void Main(string[] args)
        {
            float b, B, h, area; //A variável tbm pode ser inicializada como double, porém utilizando por exemplo:(.0).

            b = 6f;
            B = 8f;
            h = 5f;

            area = (b + B) / 2f * h;

            Console.WriteLine(area);

            Console.ReadLine();
        }
    }
}
