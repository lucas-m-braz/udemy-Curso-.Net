using System;
using System.Collections.Generic;

namespace Exercício_11_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Competidores> competidores = new List<Competidores>();
            string[] categorias = { "Infantil A", "Infantil B", "Juvenil A", "Juvenil B", "Adultos" };
            string nome;
            byte idade;
            do
            {
                Console.WriteLine("Escreva o nome do competidor e a idade separados por enter: Digite 0 para finalizar");
                nome = Console.ReadLine();
                idade = byte.Parse(Console.ReadLine());
                if (nome == "0" || idade == 0) { continue; }
                Competidores competidor = new Competidores(nome, idade);
                competidores.Add(competidor);
            } while (nome != "0" || idade != 0);
            foreach(string cat in categorias)
            {
                if (cat == "Infantil A")
                {
                    Console.WriteLine("     Categoria Infantil A     ");
                    foreach (Competidores comp in competidores)
                    {
                        if (comp.idade <= 7 && comp.idade >= 5)
                        {
                            Console.WriteLine("Competidor: " + comp.nome + " idade: " + comp.idade);
                        }
                    }
                }
                else if (cat == "Infantil B")
                {
                    Console.WriteLine("     Categoria Infantil B     ");
                    foreach (Competidores comp in competidores)
                    {
                        if (comp.idade <= 11 && comp.idade >= 8)
                        {
                            Console.WriteLine("Competidor: " + comp.nome + " idade: " + comp.idade);
                        }
                    }
                }
                else if (cat == "Juvenil A")
                {
                    Console.WriteLine("     Categoria Juvenil A     ");
                    foreach (Competidores comp in competidores)
                    {
                        if (comp.idade <= 13 && comp.idade >= 12)
                        {
                            Console.WriteLine("Competidor: " + comp.nome + " idade: " + comp.idade);
                        }
                    }
                }
                else if (cat == "Juvenil B")
                {
                    Console.WriteLine("     Categoria Juvenil B     ");
                    foreach (Competidores comp in competidores)
                    {
                        if (comp.idade <= 17 && comp.idade >= 14)
                        {
                            Console.WriteLine("Competidor: " + comp.nome + " idade: " + comp.idade);
                        }
                    }
                }
                else if (cat == "Adultos")
                {
                    Console.WriteLine("     Categoria Adultos     ");
                    foreach (Competidores comp in competidores)
                    {
                        if (comp.idade >= 18)
                        {
                            Console.WriteLine("Competidor: " + comp.nome + " idade: " + comp.idade);
                        }
                    }
                }

            }



                    Console.ReadKey();
        }
    }
}
