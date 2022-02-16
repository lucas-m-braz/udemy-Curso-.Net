using System;
using System.Collections.Generic;
using System.Text;

namespace Exercício_2_POO_e_ER
{
    class Matematica
    {
        public static void exponenciacao(int num1, int num2)
        {
            int resultado, temp;
            temp = num2;
            resultado = 1;
            while(temp > 0)
            {
                resultado = resultado * num1;
                temp--;
            }
            Console.WriteLine("O numero " + num1 + " elevado a " + num2 + " é: " + resultado);
        }
    }
}
