using System;

namespace Exercício_4_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você quer saber a tabuada de qual número?");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i <=10; i++)
            {
                Console.WriteLine(num + " * " + i + " = " + (num * i));
            }
            Console.ReadKey();
        }
    }
}
