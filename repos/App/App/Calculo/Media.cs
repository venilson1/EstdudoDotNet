using System;
using System.Collections.Generic;
using System.Text;

namespace Calculo
{
    class Media
    {
        public static void Aluno()
        {
            Console.WriteLine("Digite o nome do Aluno(a)");
            string nomeAluno = Console.ReadLine();
            int qtdNotas = 3;
            Console.WriteLine($"Digite as {qtdNotas} notas doª {nomeAluno} ");

            List<int> notas = new List<int>();
            int totalNotas = 0;
            for (int i = 1; i <= qtdNotas; i++)
            {
                Console.WriteLine($"Digite a {i}º nota doª {nomeAluno}");
                int nota = int.Parse(Console.ReadLine());
                totalNotas += nota;
                notas.Add(nota);
            }

            Console.Clear();

            int media = totalNotas / notas.Count;
            Console.WriteLine($"A média de {nomeAluno} é {media}");
            Console.WriteLine($"Notas: \n");
            foreach (int nota in notas)
            {
                Console.WriteLine($"Nota: {nota}\n");
            }
            Console.ReadLine();
            Console.Clear();

        }
    }
}
