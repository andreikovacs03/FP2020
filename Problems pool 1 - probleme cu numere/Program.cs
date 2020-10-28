/*
 Problems pool 1 - probleme cu numere
Precizari:

1. Toate problemele se vor rezolva in C#. 
2. Toate valorile se vor citi de la tastatura. 
3. Rezultatele se vor afisa pe ecran (in consola). 
4. Solutiile se vor pune intr-un repo pe GitHub


1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax+b = 0, unde a si b sunt date de intrare. 
2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax^2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. 
3. Determinati daca n se divide cu k, unde n si k sunt date de intrare. 
4. Detreminati daca un an y este an bisect. 
5. Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. 
6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi. 
7. (Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor. 
8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.   
9. Afisati toti divizorii numarului n. 
10. Test de primalitate: determinati daca un numar n este prim.
11. Afisati in ordine inversa cifrele unui numar n. 
12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b]. 
13. Determianti cati ani bisecti sunt intre anii y1 si y2.
14. Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321. 
15. Se dau 3 numere. Sa se afiseze in ordine crescatoare. 
16. Se dau 5 numere. Sa se afiseze in ordine crescatoare. (nu folositi tablouri)
17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. 
18. Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^3 x 3^1 x 7^2. 
19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). 
21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 

*/
using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace Problems_pool_1___probleme_cu_numere
{
    class Program
    {
        static void _1()
        {
            Console.WriteLine("1.Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare. ");
            Console.WriteLine("Introduceti a, b:");
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine($"Radacina x este {-b / a}");
        }

        static void _2()
        {
            Console.WriteLine("2.Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. ");
            Console.WriteLine("Introduceti a, b, c:");
            Console.Write("a = ");
            float a = float.Parse(Console.ReadLine());
            Console.Write("b = ");
            float b = float.Parse(Console.ReadLine());
            Console.Write("c = ");
            float c = float.Parse(Console.ReadLine());

            float delta = b * b - 4 * a * c;

            if (delta > 0)
                Console.WriteLine($"Radacina x1 este {(-b + Math.Sqrt(delta)) / 2 * a} si x2 este {(-b - Math.Sqrt(delta)) / 2 * a}.");
            else if (delta == 0)
                Console.WriteLine($"Radacina unica x este {(-b + Math.Sqrt(delta)) / 2 * a}.");
            else
                Console.WriteLine("Radacina este imaginara.");
        }

        static void _3()
        {
            Console.WriteLine("3.Determinati daca n se divide cu k, unde n si k sunt date de intrare.");
            Console.WriteLine("Introduceti n, k:");
            Console.Write("n = ");
            float n = float.Parse(Console.ReadLine());
            Console.Write("k = ");
            float k = float.Parse(Console.ReadLine());
            Console.WriteLine($"n {(n % k == 0 ? "\b" : "nu")} se divide cu k. ");
        }

        static void _4()
        {
            Console.WriteLine("4.Determinati daca un an y este an bisect.");
            Console.WriteLine("Introduceti y:");
            Console.Write("y = ");
            float y = int.Parse(Console.ReadLine());
            Console.WriteLine($"Anul {y} {(y % 4 == 0 ? "\b" : "nu")} este un an bisect.");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("1.Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare. ");
            Console.WriteLine("2.Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile. ");
            Console.WriteLine("3.Determinati daca n se divide cu k, unde n si k sunt date de intrare.");
            Console.WriteLine("4.Determinati daca un an y este an bisect.");
            Console.WriteLine("5.Extrageti si afisati a k-a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga. ");
            Console.WriteLine("6.Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.");
            Console.WriteLine("7.(Swap) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.Se cere sa se inverseze valorile lor.");
            Console.WriteLine("8.(Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.");
            Console.WriteLine("9.Afisati toti divizorii numarului n. ");
            Console.WriteLine("10.Test de primalitate: determinati daca un numar n este prim.");
            Console.WriteLine("11.Afisati in ordine inversa cifrele unui numar n. ");
            Console.WriteLine("12.Determinati cate numere integi divizibile cu n se afla in intervalul[a, b].");
            Console.WriteLine("13.Determianti cati ani bisecti sunt intre anii y1 si y2.");
            Console.WriteLine("14.Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.");
            Console.WriteLine("15.Se dau 3 numere.Sa se afiseze in ordine crescatoare. ");
            Console.WriteLine("16.Se dau 5 numere.Sa se afiseze in ordine crescatoare. (nu folositi tablouri)");
            Console.WriteLine("17.Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere. Folositi algoritmul lui Euclid. ");
            Console.WriteLine("18.Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2 ^ 3 x 3 ^ 1 x 7 ^ 2.");
            Console.WriteLine("19.Determinati daca un numar e format doar cu 2 cifre care se pot repeta.De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. ");
            Console.WriteLine("20.Afisati fractia m/ n in format zecimal, cu perioada intre paranteze(daca e cazul).Exemplu: 13 / 30 = 0.4(3). ");
            Console.WriteLine("21.Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x ? \" ");

            while (true)
            {
                try
                {
                    Console.WriteLine("\n\nIntroduceti numarul problemei pe care vreti sa o accesati.");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    var metode = new List<Action>() { () => _1(), () => _2(), () => _3(), () => _4() };
                    metode[n - 1]();
                }
                catch (Exception e)
                {
                    Console.Write("\n" + e.Message);
                }
                finally
                {
                    Console.Write("\n---Incercati din nou---");
                }
            }
        }
    }
}
