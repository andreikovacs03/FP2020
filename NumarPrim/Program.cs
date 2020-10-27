using System;

namespace NumarPrim
{
    class Program
    {
        static bool verificarePrim(int n)
        {
            if (n < 2 || n > 2 && n % 2 == 0)
                return false;
            for (int d = 3; d * d <= n; d += 2)
                if (n % d == 0)
                    return false;
            return true;
        }
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    Console.Write("Introdu un numar natural pentru a verifica daca este prim: ");
                    int n = int.Parse(Console.ReadLine());
                    string s = verificarePrim(n) ? "este" : "nu este";
                    Console.WriteLine($"Numarul {n} {s} prim.");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                finally
                {
                    Console.WriteLine("---Incearca un alt numar---");
                }
            }
        }
    }
}
