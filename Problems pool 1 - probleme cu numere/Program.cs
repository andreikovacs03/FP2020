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
18. Afisati descompunerea in factori primi ai unui numar n.  De ex. pentru n = 1776 afisati 2^4 x 3^1 x 37^1. 
19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta. De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt. 
20. Afisati fractia m/n in format zecimal, cu perioada intre paranteze (daca e cazul). Exemplu: 13/30 = 0.4(3). 
21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma "numarul este mai mare sau egal decat x?". 

*/
using System;
using System.Collections.Generic;

namespace Problems_pool_1___probleme_cu_numere
{
    class Program
    {
        #region Solved Problems as functions

        #region Helper Functions
        /// <summary>
        /// Citeste de la tastatatura un numar "s" si afiseaza un mesaj corespunzator utilizatorului.
        /// </summary>
        /// <param name="s">Numele variabilei citite.</param>
        /// <returns>Returneaza o valoare intreaga primita de catre utilizator.</returns>
        static int citireInt(string s)
        {
            Console.WriteLine($"Introduceti un numar intreg {s}:");
            Console.Write($"{s} = ");
            return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Citeste de la tastatatura un numar "s" si afiseaza un mesaj corespunzator utilizatorului.
        /// </summary>
        /// <param name="s">Numele variabilei.</param>
        /// <returns>Returneaza o valoare zecimala primita de catre utilizator.</returns>
        static float citireFloat(string s)
        {
            Console.WriteLine($"Introduceti un numar zecimal {s}:");
            Console.Write($"{s} = ");
            return float.Parse(Console.ReadLine());
        }
        #endregion

        static void _1()
        {
            float a = citireFloat("a"), b = citireFloat("b");

            Console.WriteLine($"Radacina x este {-b / a}.");
        }

        static void _2()
        {
            float a = citireFloat("a"), b = citireFloat("b"), c = citireFloat("a");

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
            float n = citireFloat("n"), k = citireFloat("k");

            Console.WriteLine($"n {(n % k == 0 ? "\b" : "nu")} se divide cu k. ");
        }

        static void _4()
        {
            int y = citireInt("y");

            Console.WriteLine($"Anul {y} {((y % 4 == 0 && y % 100 != 0 ) || y % 400 == 0 ? "\b" : "nu")} este un an bisect.");
        }
        static void _5()
        {
            int n = citireInt("n"), k = citireInt("k");

            if (k <= n.ToString().Length)
                Console.WriteLine($"A {k}-a cifra de la sfarsitul numarului {n} este {(n / (int)Math.Pow(10, k - 1)) % 10}");
            else
                Console.WriteLine("k trebuie sa fie mai mic decat numarul de cifre al lui n.");
        }
        static void _6()
        {
            float a = citireFloat("a"), b = citireFloat("b"), c = citireFloat("c");

            if (a > 0 && b > 0 && c > 0 && (a + b) > c && (a + c) > b && (c + b) > a)
                Console.WriteLine($"Numerele a={a}, b={b} si c={c} pot fi lungimile laturilor unui triunghi.");
            else
                Console.WriteLine($"Numerele a={a}, b={b} si c={c} nu pot fi lungimile laturilor unui triunghi.");

        }
        static void _7()
        {
            float a = citireFloat("a"), b = citireFloat("b");

            float aux = a;
            a = b;
            b = aux;

            Console.WriteLine($"Variabila \'a\' a devenit {a} iar variabila \'b\' a devenit {b}.");
        }
        static void _8()
        {
            float a = citireFloat("a"), b = citireFloat("b");

            a += b;
            b = a - b;
            a = a - b;

            Console.WriteLine($"Variabila \'a\' a devenit {a} iar variabila \'b\' a devenit {b}.");
        }
        static void _9()
        {
            int n = citireInt("n");

            Console.Write($"Divizorii numarului {n} sunt: ");

            for (int d = 1; d <= n / 2; d++)
                if (n % d == 0)
                    Console.Write($"{d}, ");
            Console.Write($"{n}\n");

        }
        static void _10()
        {
            int n = citireInt("n");

            Console.Write($"Numarul {n} ");

            if (n < 2 || n > 2 && n % 2 == 0)
                Console.Write("nu ");
            else
                for (int d = 3; d * d <= n; d += 2)
                    if (n % d == 0)
                        Console.Write("nu ");
            Console.Write("este numar prim.");
        }
        static void _11()
        {
            int n = citireInt("n");

            Console.Write($"Numarul {n} scris invers este ");
            while (n > 0)
            {
                Console.Write($"{n % 10}");
                n /= 10;
            }
            Console.Write(".\n");
        }
        static void _12()
        {
            int n = citireInt("n"), a = citireInt("a"), b = citireInt("b");

            bool ok = false;
            string s = "";
            int d;
            if (a <= b)
            {
                for (d = a; d <= b && ok == false; d++)
                    if (n % d == 0)
                        ok = true;


                if (ok == true)
                {
                    Console.Write($"Divizorii intregi ai numarului {n} intre [{a}, {b}] sunt: ");

                    for (d--; d <= b; d++)
                        if (n % d == 0)
                            s = $"{s}{d}, ";

                    Console.WriteLine(s.Remove(s.Length - 2, 2));
                }
                else
                    Console.WriteLine($"Numarul {n} nu are divizori intregi intre [{a}, {b}].");
            }
            else
                Console.WriteLine($"Numarul \'a\' trebuie sa fie mai mic sau egal ca \'b\'.");
        }
        static void _13()
        {
            int y1 = citireInt("y1"), y2 = citireInt("y2");

            if (y1 < y2)
                Console.WriteLine($"Intre {y1} si {y2} sunt {y2 / 4 - y1 / 4 - 1} ani bisecti.");
            else
                Console.WriteLine("Numarul y1 trebuie sa fie mai mic strict ca y2.");
        }
        static void _14()
        {
            int n = citireInt("n");

            int og = 0, aux = n;
            while (aux > 0)
            {
                og = og * 10 + aux % 10;
                aux /= 10;
            }
            Console.WriteLine($"Numarul {n}{(n == og ? "" : " nu")} este un palindrom.");
        }
        static void _15()
        {
            float a = citireFloat("a"), b = citireFloat("b"), c = citireFloat("c");

            if (a > b)
                (a, b) = (b, a);
            if (a > c)
                (a, c) = (c, a);
            if (b > c)
                (b, c) = (c, b);
            Console.WriteLine($"Numerele a, b, c ordonate crescator sunt: {a}, {b}, {c}");
        }
        static void _16()
        {
            float a = citireFloat("a"), b = citireFloat("b"), c = citireFloat("c"), d = citireFloat("d"), e = citireFloat("e");

            if (a > b)
                (a, b) = (b, a);
            if (a > c)
                (a, c) = (c, a);
            if (a > d)
                (a, d) = (d, a);
            if (a > e)
                (a, e) = (e, a);

            if (b > c)
                (b, c) = (c, b);
            if (b > d)
                (b, d) = (d, b);
            if (b > e)
                (b, e) = (e, b);

            if (c > d)
                (c, d) = (d, c);
            if (c > e)
                (c, e) = (e, c);

            if (d > e)
                (d, e) = (e, d);

            Console.WriteLine($"Numerele a, b, c, d, e ordonate crescator sunt: {a}, {b}, {c}, {d}, {e}");
        }
        static void _17()
        {
            int a = citireInt("a"), b = citireInt("b");

            int a2 = a, b2 = b;
            int r;
            while (b2 != 0)
            {
                r = a2 % b2;
                a2 = b2;
                b2 = r;
            }

            Console.WriteLine($"C.m.m.d.c. dintre a si b este {a2} iar c.m.m.c dintre a si b este {a * b / a2}.");
        }
        static void _18()
        {
            int n = citireInt("n");

            string s = "";
            int d = 2, divSum;

            while (n != 1)
            {
                divSum = 0;
                while (n % d == 0)
                {
                    divSum++;
                    n /= d;
                }
                if (divSum != 0)
                    s += $"{d}^{divSum} x ";
                d++;
            }

            Console.WriteLine($"Numarul {n} descompus in factori primi este egal cu: {s.Remove(s.Length - 2, 2)}");
        }
        static void _19()
        {
            int n = citireInt("n");

            bool ok = false;
            int n1 = n;
            int a = n1 % 10, b = 0;
            n1 /= 10;

            while (n1 != 0 && ok == false)
            {
                if (n1 % 10 != a)
                {
                    b = n1 % 10;
                    ok = true;
                }
                n1 /= 10;
            }

            while (n1 != 0 && ok == true)
            {
                if (n1 % 10 != a && n1 % 10 != b)
                    ok = false;
                n1 /= 10;
            }

            Console.WriteLine($"Numarul {n}{(ok == true ? "" : " nu")} este format doar din 2 cifre care se tot repeta.");
        }
        static void _20()   
        {
            int m = citireInt("m"), n = citireInt("n");
            int m1 = m, n1 = n;

            int[] resturi = new int[1000];
            int rest, i = 0, j = 0;
            string rez = "";
            bool ok = false;

            if (n == 0)
                Console.WriteLine("Nu se poate imparti la 0.");
            else
            {
                rest = m % n;
                while (rest != 0 && ok == false)
                {
                    resturi[i++] = rest;

                    m = rest * 10;
                    rest = m % n;
                    rez += (m / n).ToString();

                    for (j = 0; j < resturi.Length; j++)
                        if (rest == resturi[j])
                        {
                            ok = true;
                            rez = rez.Insert(j, "(");
                            rez += ")";
                            break;
                        }
                }
                Console.WriteLine($"Fractia {m1}/{n1} este egala cu {m1 / n1}{(rez != "" ? "." : "")}{rez} .");
            }
        }
        static void _21()
        {
            string s;
            int st = 1, dr = 1024, mij;
            while (st != dr)
            {
                mij = (st + dr) / 2;

                Console.WriteLine($"Numarul este mai mare sau egal decat {mij}?");
                s = Console.ReadLine();

                if (s == "da")
                    st = mij;
                if (s == "nu")
                    dr = mij - 1;
                else
                    Console.WriteLine("Raspundeti doar \"da\" sau \"nu\".");
            }

            Console.WriteLine($"Numarul la care va gandeati este {st}.");
        }
        #endregion

        #region Driver Code
        static void Main(string[] args)
        {
            Console.WriteLine("====================== Problems pool 1 - probleme cu numere ======================\n\n");

            string[] cerinte = new string[]
            {
                 "1. Rezolvati ecuatia de gradul 1 cu o necunoscuta: ax + b = 0, unde a si b sunt date de intrare.                                                                                          ",
                 "2. Rezolvati ecuatia de gradul 2 cu o necunoscuta: ax ^ 2 + bx + c = 0, unde a, b si c sunt date de intrare. Tratati toate cazurile posibile.                                             ",
                 "3. Determinati daca n se divide cu k, unde n si k sunt date de intrare.                                                                                                                   ",
                 "4. Detreminati daca un an y este an bisect.                                                                                                                                               ",
                 "5. Extrageti si afisati a k - a cifra de la sfarsitul unui numar. Cifrele se numara de la dreapta la stanga.                                                                              ",
                 "6. Detreminati daca trei numere pozitive a, b si c pot fi lungimile laturilor unui triunghi.                                                                                              ",
                 "7. (Swap)Se dau doua variabile numerice a si b ale carori valori sunt date de intrare. Se cere sa se inverseze valorile lor.                                                              ",
                 "8. (Swap restrictionat) Se dau doua variabile numerice a si b ale carori valori sunt date de intrare.Se cere sa se inverseze valorile lor fara a folosi alte variabile suplimentare.      ",
                 "9. Afisati toti divizorii numarului n.                                                                                                                                                    ",
                 "10. Test de primalitate: determinati daca un numar n este prim.                                                                                                                           ",
                 "11. Afisati in ordine inversa cifrele unui numar n.                                                                                                                                       ",
                 "12. Determinati cate numere integi divizibile cu n se afla in intervalul [a, b].                                                                                                          ",
                 "13. Determianti cati ani bisecti sunt intre anii y1 si y2.                                                                                                                                ",
                 "14. Determianti daca un numar n este palindrom. (un numar este palindrom daca citit invers obtinem un numar egal cu el, de ex. 121 sau 12321.                                             ",
                 "15. Se dau 3 numere.Sa se afiseze in ordine crescatoare.                                                                                                                                  ",
                 "16. Se dau 5 numere.Sa se afiseze in ordine crescatoare. (nu folositi tablouri)                                                                                                           ",
                 "17. Determianti cel mai mare divizor comun si cel mai mic multiplu comun a doua numere.Folositi algoritmul lui Euclid.                                                                    ",
                 "18. Afisati descompunerea in factori primi ai unui numar n.De ex.pentru n = 1776 afisati 2^4 x 3^1 x 37^1.                                                                                ",
                 "19. Determinati daca un numar e format doar cu 2 cifre care se pot repeta.De ex. 23222 sau 9009000 sunt astfel de numere, pe cand 593 si 4022 nu sunt.                                    ",
                 "20. Afisati fractia m / n in format zecimal, cu perioada intre paranteze(daca e cazul).Exemplu: 13 / 30 = 0.4(3).                                                                         ",
                 "21. Ghiciti un numar intre 1 si 1024 prin intrebari de forma \"numarul este mai mare sau egal decat x? Raspundeti cu \"da\" sau \"nu\".                                                   "
            };

            for (int i = 0; i < cerinte.Length; i++)
                Console.WriteLine($"{cerinte[i].Trim()}");

            while (true)
            {
                try
                {
                    Console.Write("\n\nIntroduceti numarul problemei pe care vreti sa o accesati.\n>> ");
                    int n = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    var metode = new List<Action>() { () => _1(), () => _2(), () => _3(), () => _4(), () => _5(),
                                                      () => _6(), () => _7(), () => _8(), () => _9(), () => _10(),
                                                      () => _11(), () => _12(), () => _13(), () => _14(), () => _15(),
                                                      () => _16(), () => _17(), () => _18(), () => _19(), () => _20(), () => _21() };

                    Console.Write($"{cerinte[n - 1].Trim()}\n");
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
            #endregion
    }
}
