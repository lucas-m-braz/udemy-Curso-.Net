using System;

namespace Exercício_12_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            do
            {
                Console.WriteLine("Digite dois números separados por enter:");
                num1 = int.Parse(Console.ReadLine());
                num2 = int.Parse(Console.ReadLine());

                if (num1 > num2)
                {
                    Console.WriteLine("O maior número é: " + num1);
                }
                else if (num2 > num1)
                {
                    Console.WriteLine("O maior número é: " + num2);
                }
                else
                {
                    Console.WriteLine("Os números são iguais");
                }

            } while (num1 != 0 || num2 != 0);
        }
    }
}
