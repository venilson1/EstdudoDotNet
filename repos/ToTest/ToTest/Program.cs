using System;

namespace ToTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int R = Int32.Parse(Console.ReadLine());
            int V = 0;

            while (V <= R)
            {
                V = Int32.Parse(Console.ReadLine());
            }
            var contador = 1;
            int i = R;
            while (i <= V)
            {
                contador++;
                R = R + 1;
                i = i + R;
            }
            Console.WriteLine(contador);
        }
    }
}
