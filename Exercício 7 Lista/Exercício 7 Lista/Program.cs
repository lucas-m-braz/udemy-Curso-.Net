using System;

namespace Exercício_7_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deseja informar quantos números?");
            int num = int.Parse(Console.ReadLine());
            int maior, menor, temp;

            Console.WriteLine("Digite os números desejados utilizando enter para separa-los");
            maior = int.Parse(Console.ReadLine());
            menor = maior;
            for (int i = 1; i < num; i++)
            {
                temp = int.Parse(Console.ReadLine());
                if (temp > maior) { maior = temp; }
                else if(temp < menor) { menor = temp; }
            }

            Console.WriteLine("O maior número é: " + maior);
            Console.WriteLine("O menor número é: " + menor);
            Console.ReadKey();

        }
    }
}
