using System;

namespace Exercício_8_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 1000; i++)
            {
                Console.Write(i + " ");
                if (i % 3 == 0)
                {
                    Console.Write(" – Número múltiplo de 3 - ");
                }
            }
            Console.ReadKey();
        }
    }
}
