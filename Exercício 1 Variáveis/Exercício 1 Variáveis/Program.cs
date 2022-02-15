using System;

namespace Exercício_1_Variáveis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual seu nome?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual sua idade?");
            string idade = Console.ReadLine();

            Console.WriteLine("Nome: " + nome + "\nano de nascimento: " + (DateTime.Now.Year - int.Parse(idade)));
            Console.ReadLine();

        }
    }
}
