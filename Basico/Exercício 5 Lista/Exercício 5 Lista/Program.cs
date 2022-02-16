using System;

namespace Exercício_5_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva 4 números separados por enter:");
            int somaPar, somaImpar, num;
            somaPar = 0;
            somaImpar = 0;

            for (int i = 0; i < 4; i++)
            {
                num = int.Parse(Console.ReadLine());
                if (num % 2 == 1)
                {
                    somaImpar += num;
                }
                else
                {
                    somaPar += num;
                }
            }
            Console.WriteLine("A soma dos pares é: " + somaPar);
            Console.WriteLine("A soma dos impares é: " + somaImpar);

            Console.ReadLine();
        }
    }
}
