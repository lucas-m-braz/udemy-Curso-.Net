using System;

namespace Exercício_13_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Você deseja calcular para quantos anos?");
            int anos = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o seu salário inicial?");
            float salario = float.Parse(Console.ReadLine());
            for (int i = 0; i < anos; i++)
            {
                if (i <= 3)
                {
                    salario = salario * (float)1.5;
                }
                else
                {
                    if (i % 10 == 0)
                    {
                        salario = salario * (float)2.1;
                    }
                    else
                    {
                        salario = salario * 2;
                    }
                    
                }
            }
            Console.WriteLine("O salário no último ano será de: " + salario);
            Console.ReadKey();

        }
    }
}
