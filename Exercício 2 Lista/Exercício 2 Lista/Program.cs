using System;

namespace Exercício_2_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantos numeros deseja informar?");
            int qtd = int.Parse(Console.ReadLine());
            int soma, num;
            float media;
            soma = 0;
            for(int i = 0; i < qtd; i++)
            {
                Console.WriteLine("Qual numero deseja informar?");
                num = int.Parse(Console.ReadLine());
                soma += num;
            }
            media = soma / (float)qtd;

            Console.WriteLine("A soma de todos os números informados é: " + soma);
            Console.WriteLine("A média aritimética de todos os números informados é: " + media);
            Console.ReadKey();
        }
    }
}
