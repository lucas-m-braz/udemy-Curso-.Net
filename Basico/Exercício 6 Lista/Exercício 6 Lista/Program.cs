using System;
using System.Collections.Generic;

namespace Exercício_6_Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nomes = new List<string>();
            List<float> medias = new List<float>();
            
            string nome;
            float nota1, nota2, nota3, nota0, media, mediaTurma;
            bool continua = true;
            mediaTurma = 0;
            while (continua == true)
            {

                Console.WriteLine("Escreva o nome do aluno(para terminar escreva: finalizar):");
                nome = Console.ReadLine();
                if (nome == "finalizar")
                {
                    break;
                }
                Console.WriteLine("Escreva cada nota desse aluno separada por enter:");
                nota0 = float.Parse(Console.ReadLine());
                nota1 = float.Parse(Console.ReadLine());
                nota2 = float.Parse(Console.ReadLine());
                nota3 = float.Parse(Console.ReadLine());

                media = (nota1 + nota2 + nota3 + nota0) / 4;
                nomes.Add(nome);
                medias.Add(media);
                mediaTurma += media;
            }
            mediaTurma = mediaTurma / medias.Count;

            foreach(string anome  in nomes)
            {
                Console.WriteLine("Nome do aluno: " + anome + " media: " + medias[nomes.IndexOf(anome)]);
            }
            Console.WriteLine("Media da turma: " + mediaTurma);
            Console.ReadKey();
        }
    }
}
