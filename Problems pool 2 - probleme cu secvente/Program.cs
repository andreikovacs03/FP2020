﻿/*

 Problems pool 2 - probleme cu secvente
Precizari:

Toate aceste probleme se vor rezolva fara a folosi vectori/tablouri.
Problemele se vor rezolva in C#. 



1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare. 
2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive. 
3. Calculati suma si produsul numerelor de la 1 la n. 
4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1. 
5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0. 
6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare. 
7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa. 
8. Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n-1) + f(n-2). Exemplu: 0, 1, 1, 2, 3, 5, 8 ...
9. Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare. 
10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa. 
11. Se da o secventa de n numere. Se cere sa se calculeze suma inverselor acestor numere. 
12. Cate grupuri de numere consecutive diferite de zero sunt intr-o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte. De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.
13. O <secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr-o secventa in ordine crescatoare prin rotiri succesive (rotire = primul element devine ultimul). Determinati daca o secventa de n numere este o secventa crescatoare rotita. 
14. O <secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive. Determinati daca o secventa de n numere este o secventa monotona rotita. 
15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator. De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere. Sa se determine daca este bitonica. 
16. O <secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive (rotire = primul element devine ultimul). Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita. 
17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa. Determinati daca secventa reprezinta o secventa de paranteze corecta si,  daca este, determinati nivelul maxim de incuibare a parantezelor. De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. 

 */



using System;
using System.Collections.Generic;

namespace Problems_pool_2___probleme_cu_secvente
{
    class Program
    {
        #region Solved Problems

        #region Helper Functions
        /// <summary>
        /// Citeste de la tastatatura un numar "s" si afiseaza un mesaj corespunzator utilizatorului.
        /// </summary>
        /// <param name="s">Numele variabilei.</param>
        /// <returns>Returneaza o valoare intreaga primita de catre utilizator.</returns>
        static int citireInt(string s)
        {
            Console.WriteLine($"Introduceti un numar intreg {s}:");
            Console.Write($"{s} = ");
            return int.Parse(Console.ReadLine());
        }
        /// <summary>
        /// Citeste de la tastatura un sir de numere si il converteste in int dupa care returneaza acest vector.
        /// </summary>
        /// <returns>Returneaza vectorul primit de catre utilizator</returns>
        static int[] citireVector()
        {
            Console.WriteLine("Introduceti n numere intregi pe aceeasi linie delimitate de un spatiu:");
            int[] x = Array.ConvertAll(Console.ReadLine().Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries), int.Parse);
            Console.WriteLine();
            return x;
        }
        #endregion

        static void _1()
        {
            int[] x = citireVector();
            int sum = 0;
            foreach (var i in x)
                if (i % 2 == 0)
                    sum++;

            Console.WriteLine($"Vectorul are {sum} numere pare.");
        }
        static void _2()
        {
            int[] x = citireVector();
            int negative = 0, zero = 0, pozitive = 0;
            foreach (var i in x)
                if (i < 0)
                    negative++;
                else if (i == 0)
                    zero++;
                else
                    pozitive++;

            Console.WriteLine($"Vectorul are {negative} numere negative, {zero} numere egale cu 0 si {pozitive} numere pozitive.");
        }
        static void _3()
        {
            int n = citireInt("n");
            int sum = 0, prod = 1;

            for (int i = 1; i <= n; i++)
            {
                sum += i;
                prod *= i;
            }
            Console.WriteLine($"Suma tuturor elementelor din vector este {sum} iar produsul tuturor elementelor este {prod}.");
        }
        static void _4()
        {
            int[] n = citireVector();
            int a = citireInt("a");
            int poz = -1;
            for (int i = 0; i < n.Length; i++)
                if (n[i] == a)
                    poz = i;
            Console.WriteLine($"Numarul {a} se afla pe pozitia {poz} in secventa.");

        }
        static void _5()
        {
            int[] n = citireVector();
            int sum = 0;

            for (int i = 0; i < n.Length; i++)
                if (n[i] == i)
                    sum++;
            Console.WriteLine($"In secventa exista {sum} numere egale cu pozitia pe care apar in secventa.");
        }
        static void _6()
        {
            int[] n = citireVector();

            int i;
            for (i = 1; i < n.Length; i++)
                if (n[i - 1] > n[i])
                    break;
            Console.WriteLine($"Secventa de numere {(i == n.Length ? "" : "nu ")}este in ordine crescatoare.");
        }
        static void _7()
        {
            int[] n = citireVector();
            int mini = n[0], maxi = n[0];

            for (int i = 1; i < n.Length; i++)
                if (n[i] < mini)
                    mini = n[i];
                else if (n[i] > maxi)
                    maxi = n[i];

            Console.WriteLine($"Cel mai mare numar din secventa este {maxi} iar cel mai mic numar din secventa este {mini}.");
        }
        static void _8()
        {
            int n = citireInt("n");

            if (n > 0)
            {
                int a = 0, b = 1;
                int c = n == 1 ? 0 : 1;

                for (int i = 3; i <= n; i++)
                {
                    c = a + b;
                    a = b;
                    b = c;
                }
                Console.WriteLine($"Al {n}-lea numar din sirul Fibonacci este {c}.");
            }
            else
                Console.WriteLine("Numarul n trebuie sa fie mai mare ca 0.");
        }
        static void _9()
        {
            int[] n = citireVector();

            if (n.Length > 1)
            {
                bool crescator = true, descrescator = true;
                for (int i = 1; i < n.Length; i++)
                    if (n[i - 1] > n[i])
                        crescator = false;
                if (crescator == false)
                {
                    for (int i = 1; i < n.Length; i++)
                        if (n[i - 1] < n[i])
                            descrescator = false;
                    if (descrescator == true)
                        Console.WriteLine("Secventa este monoton descrescatoare.");
                    else
                        Console.WriteLine("Secventa nu este monoton crescatoare, nici monoton descrescatoare.");
                }
                else
                    Console.WriteLine("Secventa este monoton crescatoare.");
            }
            else
                Console.WriteLine("Secventa trebuie sa contina mai mult de 1 element.");
        }
        static void _10()
        {
            int[] n = citireVector();

            int nr = n[0], maxiCurent = 1, maxi = 1;
            for (int i = 1; i < n.Length; i++)
            {
                if (n[i] == nr)
                    maxiCurent++;
                else
                {
                    if (maxiCurent > maxi)
                        maxi = maxiCurent;
                    maxiCurent = 1;
                    nr = n[i];
                }
                if (maxiCurent > maxi)
                    maxi = maxiCurent;
            }
            Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este {maxi}.");
        }
        static void _11()
        {
            int[] n = citireVector();

            int og, aux, sum = 0;
            for (int i = 0; i < n.Length; i++)
            {
                aux = n[i];
                og = 0;
                while (aux != 0)
                {
                    og = og * 10 + aux % 10;
                    aux /= 10;
                }
                sum += og;
            }
            Console.WriteLine($"Suma inverselor numerelor din secventa este {sum}.");
        }
        static void _12()
        {
            int[] n = citireVector();

            int nrSecv = 0;
            bool ok;
            int i, j;

            for (i = 0; i < n.Length - 1; i++)
            {
                ok = true;
                if (n[i] != 0 && n[i + 1] != 0)
                {
                    for (j = i; n[j] != 0 && n[j + 1] != 0 && j < n.Length - 1 && ok == true; j++)
                    {
                        if (n[j] >= n[j + 1])
                            ok = false;
                    }
                    if (ok == true)
                        nrSecv++;
                    i = j;
                }
                else if (n[i] != 0)
                    nrSecv++;
            }
            if (n[n.Length - 2] == 0 && n[n.Length - 1] != 0)
                nrSecv++;

            Console.WriteLine($"In secventa sunt {nrSecv} grupuri de numere consecutive diferite de zero.");
        }
        static void _13()
        {
            int[] n = citireVector();

            bool crescatoare = true;
            for (int i = 1; i <= n.Length; i++)
            {
                crescatoare = true;
                for (int j = 0; j < n.Length - 1 && crescatoare == true; j++)
                    if (n[j] > n[j + 1])
                        crescatoare = false;
                if (crescatoare == true)
                    break;
                else
                {
                    int aux = n[0];
                    for (int j = 0; j < n.Length - 1; j++)
                        n[j] = n[j + 1];
                    n[n.Length - 1] = aux;
                }
            }
            Console.WriteLine($"Secventa {(crescatoare == true ? "" : "nu ")}este o secventa crescatoare rotita.");
        }
        static void _14()
        {
            int[] n = citireVector();

            bool monotona = true;
            for (int i = 1; i <= n.Length; i++)
            {
                monotona = true;
                for (int j = 0; j < n.Length - 1 && monotona == true; j++)
                    if (n[j] > n[j + 1])
                        monotona = false;

                if (monotona == true)
                    break;

                monotona = true;
                for (int j = 0; j < n.Length - 1 && monotona == true; j++)
                    if (n[j] < n[j + 1])
                        monotona = false;

                if (monotona == true)
                    break;

                else
                {
                    int aux = n[0];
                    for (int j = 0; j < n.Length - 1; j++)
                        n[j] = n[j + 1];
                    n[n.Length - 1] = aux;
                }
            }
            Console.WriteLine($"Secventa {(monotona == true ? "" : "nu ")}este o secventa monotona rotita.");
        }
        static void _15()
        {
            int[] n = citireVector();

            int i;
            for (i = 0; i < n.Length - 1; i++)
                if (n[i] > n[i + 1])
                    break;
            i++;
            if (i != n.Length)
            {
                for (; i < n.Length - 1; i++)
                    if (n[i] < n[i + 1])
                        break;
                i++;
            }

            Console.WriteLine($"Secventa de numere {(i == n.Length ? "" : "nu ")}este o secventa bitonica.");
        }
        static void _16()
        {
            int[] n = citireVector();

            int i = 0;
            for (int k = 1; k <= n.Length; k++)
            {
                for (i = 0; i < n.Length - 1; i++)
                    if (n[i] > n[i + 1])
                        break;
                i++;
                if (i != n.Length)
                {
                    for (; i < n.Length - 1; i++)
                        if (n[i] < n[i + 1])
                            break;
                    i++;
                }

                if (i == n.Length)
                    break;
                else
                {
                    int aux = n[0];
                    for (int j = 0; j < n.Length - 1; j++)
                        n[j] = n[j + 1];
                    n[n.Length - 1] = aux;
                }

            }
            Console.WriteLine($"Secventa de numere {(i == n.Length ? "" : "nu ")}este o secventa bitonica rotita.");
        }
        static void _17()
        {
            int[] n = citireVector();

            int sum = 0, valMax = 0;
            for (int i = 0; i < n.Length && sum >= 0; i++)
            {
                sum += n[i] == 0 ? 1 : -1;
                valMax = sum > valMax ? sum : valMax;
            }
            Console.WriteLine($"Secventa este o secventa de paranteze {(sum == 0 ? "corecta iar nivelul maxim de incuibare este " + valMax : "incorecta")}.");
        }
        #endregion

        #region Driver Code
        static void Main(string[] args)
        {
            Console.WriteLine("====================== Problems pool 2 - probleme cu secvente ======================\n\n");

            string[] cerinte = new string[]
            {
                 "1. Se da o secventa de n numere. Sa se determine cate din ele sunt pare.                                                                                                                                                                                                                                                                                     ",
                 "2. Se da o secventa de n numere. Sa se determina cate sunt negative, cate sunt zero si cate sunt pozitive.                                                                                                                                                                                                                                                   ",
                 "3. Calculati suma si produsul numerelor de la 1 la n.                                                                                                                                                                                                                                                                                                        ",
                 "4. Se da o secventa de n numere. Determinati pe ce pozitie se afla in secventa un numara a. Se considera ca primul element din secventa este pe pozitia zero. Daca numarul nu se afla in secventa raspunsul va fi -1.                                                                                                                                        ",
                 "5. Cate elemente dintr-o secventa de n numere sunt egale cu pozitia pe care apar in secventa. Se considera ca primul element din secventa este pe pozitia 0.                                                                                                                                                                                                 ",
                 "6. Se da o secventa de n numere. Sa se determine daca numerele din secventa sunt in ordine crescatoare.                                                                                                                                                                                                                                                      ",
                 "7. Se da o secventa de n numere. Sa se determine cea mai mare si cea mai mica valoare din secventa.                                                                                                                                                                                                                                                          ",
                 "8. Determianti al n-lea numar din sirul lui Fibonacci. Sirul lui Fibonacci se construieste astfel: f1 = 0, f2 = 1, f_n = f_(n - 1) + f(n - 2).Exemplu: 0, 1, 1, 2, 3, 5, 8...                                                                                                                                                                                ",
                 "9. Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.                                                                                                                                                                                                                   ",
                 "10. Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.                                                                                                                                                                                                                                                          ",
                 "11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.                                                                                                                                                                                                                                                                     ",
                 "12. Cate grupuri de numere consecutive diferite de zero sunt intr - o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.                                                                                             ",
                 "13. O < secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr - o secventa in ordine crescatoare prin rotiri succesive(rotire = primul element devine ultimul).Determinati daca o secventa de n numere este o secventa crescatoare rotita.                                                   ",
                 "14. O < secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive.Determinati daca o secventa de n numere este o secventa monotona rotita.                                                                                                                                        ",
                 "15. O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator.De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere.Sa se determine daca este bitonica.                                                                                                                            ",
                 "16. O < secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive(rotire = primul element devine ultimul).Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.                                                                               ",
                 "17. Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.Determinati daca secventa reprezinta o secventa de paranteze corecta si, daca este, determinati nivelul maxim de incuibare a parantezelor.De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta. ",
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

                    var metode = new List<Action>() { () => _1(), () => _2(), () => _3(),
                                                      () => _4(), () => _5(), () => _6(),
                                                      () => _7(), () => _8(), () => _9(),
                                                      () => _10(), () => _11(), () => _12(),
                                                      () => _13(), () => _14(), () => _15(),
                                                      () => _16(), () => _17() };

                    Console.WriteLine($"{cerinte[n - 1].Trim()}\n");
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
