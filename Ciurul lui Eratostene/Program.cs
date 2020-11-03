using System;

namespace Ciurul_lui_Eratostene
{
    class Program
    {
        static void ciur(int[] x, int n)
        {
            for (int i = 2; i <= n; i++)
                if (x[i] == 0)
                {
                    Console.Write($"{i} ");
                    for (int j = i + i; j <= n; j += i)
                        x[j] = 1;
                }
        }
        static void Main(string[] args)
        {
            Console.Write(" Problema: Să se genereze toate numerele prime mai mici decât numărul natural n dat.\n\n");
            Console.Write(" Introduceti un numar n\n ");

            int n = int.Parse(Console.ReadLine());
            int[] x = new int[n + 1];

            Console.Write($"\n Toate numerele prime mai mici decat {n} sunt:\n ");
            ciur(x, n);

            Console.WriteLine();
            Console.WriteLine();
            Console.Write(" Animatie reprezentativa: https://upload.wikimedia.org/wikipedia/commons/b/b9/Sieve_of_Eratosthenes_animation.gif \n ");
        }
    }
}
