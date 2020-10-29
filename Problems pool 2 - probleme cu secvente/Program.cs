/*
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
11. Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere. 
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
        /// <summary>
        /// Citeste de la tastatatura un numar "s" si afiseaza un mesaj corespunzator utilizatorului.
        /// </summary>
        /// <param name="s">Numele variabilei.</param>
        /// <returns>Returneaza valoarea primita de catre utilizator.</returns>
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
            Console.WriteLine("Introduceti n numere intregi pe aceeasi linie delimitate de un singur spatiu:");
            int[] x = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
            return x;
        }
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

        }
        static void _6()
        {

        }
        static void _7()
        {

        }
        static void _8()
        {

        }
        static void _9()
        {

        }
        static void _10()
        {

        }
        static void _11()
        {

        }
        static void _12()
        {

        }
        static void _13()
        {

        }
        static void _14()
        {

        }
        static void _15()
        {

        }
        static void _16()
        {

        }
        static void _17()
        {

        }
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
                 "9.Sa se determine daca o secventa de n numere este monotona. Secventa monotona = secventa monoton crescatoare sau monoton descrescatoare.                                                                                                                                                                                                                    ",
                 "10.Se da o secventa de n numere. Care este numarul maxim de numere consecutive egale din secventa.                                                                                                                                                                                                                                                           ",
                 "11.Se da o secventa de n numere. Se cere sa se caculeze suma inverselor acestor numere.                                                                                                                                                                                                                                                                      ",
                 "12.Cate grupuri de numere consecutive diferite de zero sunt intr - o secventa de n numere. Considerati fiecare astfel de grup ca fiind un cuvant, zero fiind delimitator de cuvinte.De ex. pentru secventa 1, 2, 0, 3, 4, 5, 0, 0, 6, 7, 0, 0 raspunsul este 3.                                                                                              ",
                 "13.O < secventa crescatoare rotita> este o secventa de numere care este in ordine crescatoare sau poate fi transformata intr - o secventa in ordine crescatoare prin rotiri succesive(rotire = primul element devine ultimul).Determinati daca o secventa de n numere este o secventa crescatoare rotita.                                                    ",
                 "14.O < secventa monotona rotita> este o secventa de numere monotona sau poate fi transformata intr-o secventa montona prin rotiri succesive.Determinati daca o secventa de n numere este o secventa monotona rotita.                                                                                                                                         ",
                 "15.O secventa bitonica este o secventa de numere care incepe monoton crescator si continua monoton descrecator.De ex. 1,2,2,3,5,4,4,3 este o secventa bitonica. Se da o secventa de n numere.Sa se determine daca este bitonica.                                                                                                                             ",
                 "16.O < secventa bitonica rotita> este o secventa bitonica sau una ca poate fi transformata intr-o secventa bitonica prin rotiri succesive(rotire = primul element devine ultimul).Se da o secventa de n numere. Se cere sa se determine daca este o secventa bitonica rotita.                                                                                ",
                 "17.Se da o secventa de 0 si 1, unde 0 inseamna paranteza deschisa si 1 inseamna paranteza inchisa.Determinati daca secventa reprezinta o secventa de paranteze corecta si, daca este, determinati nivelul maxim de incuibare a parantezelor.De exemplu 0 1 0 0 1 0 1 1 este corecta si are nivelul maxim de incuibare 2 pe cand 0 0 1 1 1 0 este incorecta.  ",
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
                                                      () => _16(), () => _17() };

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
    }
}
