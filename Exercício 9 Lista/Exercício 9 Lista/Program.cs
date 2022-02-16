using System;

namespace Exercício_9_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            string volta;
            do
            {
                Console.WriteLine("1 – Adição");
                Console.WriteLine("2 – Subtração");
                Console.WriteLine("3 – Multiplicação");
                Console.WriteLine("4 – Divisão");
                Console.WriteLine("Informe a opção:");
                int opcao = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite dois números utilizando enter para separa-los");
                float num1, num2;
                num1 = float.Parse(Console.ReadLine());
                num2 = float.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("A soma dos números é: " + (num1 + num2));
                }
                else if (opcao == 2)
                {
                    Console.WriteLine("A subtração dos números é: " + (num1 - num2));
                }
                else if (opcao == 3)
                {
                    Console.WriteLine("A multiplicação dos números é: " + (num1 * num2));
                }
                else if (opcao == 4)
                {
                    Console.WriteLine("A divizão dos números é: " + (num1 / num2));
                }
                Console.WriteLine("Deseja voltar ao menu? Responda s ou S se positivo");
                volta = Console.ReadLine();
            } while (volta == "S" || volta == "s");
        }
    }
}
