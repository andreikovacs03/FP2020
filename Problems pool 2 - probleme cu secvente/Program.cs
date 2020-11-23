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
        static int citireNVector()
        {
            Console.WriteLine($"Introduceti un numar intreg n si n elemente (fiecare la linie noua):");
            Console.Write("n = ");

            return int.Parse(Console.ReadLine());

        }
        #endregion

        static void _1()
        {
            int n = citireNVector(), x;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x % 2 == 0)
                    sum++;
            }

            Console.WriteLine($"Vectorul are {sum} numere pare.");
        }
        static void _2()
        {
            int n = citireNVector(), x;
            int negative = 0, zero = 0, pozitive = 0;

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x < 0)
                    negative++;
                else if (x == 0)
                    zero++;
                else
                    pozitive++;
            }
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
            int a = citireInt("a");
            int n = citireNVector(), x;
            int poz = -1;
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == a)
                    poz = i;
            }
            Console.WriteLine($"Numarul {a} se afla pe pozitia {poz} in secventa.");

        }
        static void _5()
        {
            int n = citireNVector(), x;
            int sum = 0;

            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                if (x == i)
                    sum++;
            }
            Console.WriteLine($"In secventa exista {sum} numere egale cu pozitia pe care apar in secventa.");
        }
        static void _6()
        {
            int n = citireNVector(), x, y;

            int i;
            x = int.Parse(Console.ReadLine());
            for (i = 1; i < n; i++)
            {
                y = int.Parse(Console.ReadLine());
                if (x > y)
                    break;
                x = y;
            }
            Console.WriteLine($"Secventa de numere {(i == n ? "" : "nu ")}este in ordine crescatoare.");
        }
        static void _7()
        {
            int n = citireNVector(), x;
            x = int.Parse(Console.ReadLine());
            int mini = x, maxi = x;

            for (int i = 1; i < n; i++)
            {
                if (x < mini)
                    mini = x;
                else if (x > maxi)
                    maxi = x;
                x = int.Parse(Console.ReadLine());
            }

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
            int n = citireNVector(), x, y;

            if (n > 1)
            {
                x = int.Parse(Console.ReadLine());
                y = int.Parse(Console.ReadLine());

                int i;
                bool crescator = true;

                for (i = 2; i < n && x == y; i++)
                {
                    x = y;
                    y = int.Parse(Console.ReadLine());
                }
                if (i == n)
                    Console.WriteLine("Toate elementele din secventa sunt egale.");
                else
                {
                    crescator = x < y ? true : false;
                    if (crescator == true)
                    {
                        for (; i < n && x <= y; i++)
                        {
                            x = y;
                            y = int.Parse(Console.ReadLine());
                        }
                        if (i == n)
                            Console.WriteLine("Secventa de numere este monoton crescatoare.");
                        else
                            Console.WriteLine("Secventa de numere nu este monotona.");
                    }
                    else
                    {
                        for (; i < n && x >= y; i++)
                        {
                            x = y;
                            y = int.Parse(Console.ReadLine());
                        }
                        if (i == n)
                            Console.WriteLine("Secventa de numere este monoton descrescatoare.");
                        else
                            Console.WriteLine("Secventa de numere nu este monotona.");
                    }

                }

            }
            else
                Console.WriteLine("Secventa trebuie sa contina mai mult de 1 element.");
        }
        static void _10()
        {
            int n = citireNVector(), x;

            x = int.Parse(Console.ReadLine());

            int nr = x, maxiCurent = 1, maxi = 1;
            for (int i = 1; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());

                if (x == nr)
                    maxiCurent++;
                else
                {
                    if (maxiCurent > maxi)
                        maxi = maxiCurent;
                    maxiCurent = 1;
                    nr = x;
                }
                if (maxiCurent > maxi)
                    maxi = maxiCurent;
            }
            Console.WriteLine($"Numarul maxim de numere consecutive egale din secventa este {maxi}.");
        }
        static void _11()
        {
            int n = citireNVector(), x;

            int og, aux, sum = 0;
            for (int i = 0; i < n; i++)
            {
                x = int.Parse(Console.ReadLine());
                aux = x;
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
            int n = citireNVector(), x, y;

            int nrSecv = 0;
            bool ok = false;
            int i, j;
            y = int.Parse(Console.ReadLine());
            x = y;

            for (i = 1; i < n; i++)
            {
                x = y;
                y = int.Parse(Console.ReadLine());

                if (x == 0 && y != 0)
                    ok = true;

                if (x != 0 && y == 0 && ok == true)
                    nrSecv++;

                if (x > y)
                    ok = false;
            }
            if (ok == true)
                nrSecv++;

            Console.WriteLine($"In secventa sunt {nrSecv} grupuri de numere consecutive diferite de zero.");
        }
        static void _13()
        {
            int n = citireNVector(), x, y;
            y = int.Parse(Console.ReadLine());

            int nrInit = y;

            bool crescatoare = true, cadere = false;
            for (int j = 0; j < n - 1 && crescatoare; j++)
            {
                x = y;
                y = int.Parse(Console.ReadLine());

                if (x > y)
                {
                    if (cadere)
                        crescatoare = false;
                    cadere = true;
                }
            }

            if (y > nrInit && cadere)
                crescatoare = false;

            Console.WriteLine($"Secventa {(crescatoare ? "" : "nu ")}este o secventa crescatoare rotita.");
        }
        static void _14()
        {
            int n = citireNVector(), x, y;
            y = int.Parse(Console.ReadLine());

            int nrInit = y;

            bool crescatoare = true, cadere = false, descrescatoare = true, urcare = false;

            for (int j = 0; j < n - 1 && (crescatoare || descrescatoare); j++)
            {
                x = y;
                y = int.Parse(Console.ReadLine());

                if (x > y)
                {
                    if (cadere)
                        crescatoare = false;
                    cadere = true;
                }

                if (x < y)
                {
                    if (urcare)
                        descrescatoare = false;
                    urcare = true;
                }
            }

            if (y > nrInit && cadere)
                crescatoare = false;

            if (y < nrInit && urcare)
                descrescatoare = false;

            Console.WriteLine($"Secventa {(crescatoare || descrescatoare ? "" : "nu ")}este o secventa monotona rotita.");
        }
        static void _15()
        {
            int n = citireNVector(), x, y;

            y = int.Parse(Console.ReadLine());
            int i;
            for (i = 0; i < n - 1; i++)
            {
                x = y;
                y = int.Parse(Console.ReadLine());

                if (x > y)
                    break;
            }
            i++;
            if (i != n)
            {
                for (; i < n - 1; i++)
                {
                    x = y;
                    y = int.Parse(Console.ReadLine());
                    if (x < y)
                        break;
                }
                i++;
            }

            Console.WriteLine($"Secventa de numere {(i == n ? "" : "nu ")}este o secventa bitonica.");
        }
        static void _16()
        {
            int n = citireNVector(), x, y;

            y = int.Parse(Console.ReadLine());

            int i = 0;

            for (i = 0; i < n - 1; i++)
            {
                x = y;
                y = int.Parse(Console.ReadLine());
                if (x > y)
                    break;
            }
            i++;
            if (i != n)
            {
                for (; i < n - 1; i++)
                {
                    x = y;
                    y = int.Parse(Console.ReadLine());
                    if (x < y)
                        break;
                }
                i++;
                if (i != n)
                {
                    for (; i < n - 1; i++)
                    {
                        x = y;
                        y = int.Parse(Console.ReadLine());
                        if (x > y)
                            break;
                    }
                    i++;
                }
            }
            Console.WriteLine($"Secventa de numere {(i == n ? "" : "nu ")}este o secventa bitonica rotita.");
        }
        static void _17()
        {
            int n = citireNVector(), x;

            int sum = 0, valMax = 0;
            for (int i = 0; i < n && sum >= 0; i++)
            {
                x = int.Parse(Console.ReadLine());
                sum += x == 0 ? 1 : -1;
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
