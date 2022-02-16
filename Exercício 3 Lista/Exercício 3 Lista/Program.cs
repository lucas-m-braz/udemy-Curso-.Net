using System;

namespace Exercício_3_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <=200; i++)
            {
                if(i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
