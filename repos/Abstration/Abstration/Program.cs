using Dog;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Abstration
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            var c = new Cachorro();
            Console.WriteLine($"idade padrão: { c.Idade}");
            c.Idade = 5;
            Console.WriteLine($"nova idade passada: { c.Idade}");

            Console.WriteLine($"pele padrão: {c.GetPele()}");
            
            c.SetPele("Branco");
            Console.WriteLine($"pele atribuida: {c.GetPele()}");

            c.Correr();
            c.Latir();
            */
            

            Console.WriteLine("numero De Figurinhas:");
            int numeroDeFigurinhas = Int32.Parse(Console.ReadLine());
            
            Console.WriteLine("numero De Figurinhas Compradas");
            int numeroDeFigurinhasCompradas = Int32.Parse(Console.ReadLine());
            int totalDeFigurinhas = 0;

            int[] albumDeFigurinha = new int[numeroDeFigurinhasCompradas];

            // IMPLEMENTE AQUI A SOLUÇÃO
            var meuHashSet = new HashSet<int>(albumDeFigurinha);
            
            for (var i = 0; i < albumDeFigurinha.Length; i++)
            {
                albumDeFigurinha[i] = Int32.Parse(Console.ReadLine());
            }

            var quantidadeRepetidos = albumDeFigurinha.Length - albumDeFigurinha.Distinct().Count();

            
            Console.WriteLine($"numero de figurinhas :{numeroDeFigurinhas}");
            Console.WriteLine($"figurinhas iguais :{quantidadeRepetidos}");

            totalDeFigurinhas = numeroDeFigurinhas - (numeroDeFigurinhasCompradas - quantidadeRepetidos);

            Console.WriteLine($"Faltam :{totalDeFigurinhas}");
        }
    }
}
