using System;

namespace Exercício_10_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            float salario, imposto;
            do
            {
                Console.WriteLine("Deseja calcular o imposto de renda para qual salário? Digite 0 para fechar");
                salario = float.Parse(Console.ReadLine());
                if (salario > 4664.68)
                {
                    imposto = ((salario - (float)869.68) * (float)(0.275));
                }
                else if (salario > 3751.05)
                {
                    imposto = ((salario - (float)636.13) * (float)(0.225));
                }
                else if (salario > 2826.65)
                {
                    imposto = ((salario - (float)354.80) * (float)(0.15));
                }
                else if (salario > 1903.98)
                {
                    imposto = ((salario - (float)142.80) * (float)(0.075));
                }
                else
                {
                    imposto = 0;
                }

                Console.WriteLine("Para esse salário é necessário pagar um imposto de: R$" + imposto);
            } while (salario != 0);
        }
    }
}
