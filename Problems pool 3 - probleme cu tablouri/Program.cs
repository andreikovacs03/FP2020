/*

Problems pool 3 - probleme cu tablouri



1. Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.
2. Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1. 
3. Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz). 
4. Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea. 
5. Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero. 
6. Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga. 
7. Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.
8. Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc. 
9. Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga. 
10. Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1. 
11. Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene). 
12. Sortare selectie. Implementati algoritmul de sortare <Selection Sort>. 
13. Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>. 
14. Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului). 
15. Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector. 
16. Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.
17. Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.   
18. Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x. 
 
*/

using System;
using System.Collections.Generic;

namespace Problems_pool_3___probleme_cu_tablouri
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
            int sum = 0;
            int[] n = citireVector();
            foreach (int item in n)
                sum += item;
            Console.WriteLine($"Suma elementelor din vector este {sum}.");
        }
        static void _2()
        {
            int k = citireInt("k");
            int[] n = citireVector();
            int poz = -1;

            for (int i = 0; i < n.Length; i++)
                if (k == n[i])
                {
                    poz = i + 1;
                    break;
                }
            Console.WriteLine($"Prima pozitie din vector pe care apare k = {k} este {poz}.");
        }
        static void _3()
        {
            int[] n = citireVector();
            List<int> winners = new List<int>(); // vector de pozitii
            List<int> losers = new List<int>();

            for (int i = 1; i < n.Length; i += 2)
                if (n[i - 1] < n[i])
                {
                    winners.Add(i);
                    losers.Add(i - 1);
                }
                else
                {
                    winners.Add(i - 1);
                    losers.Add(i);
                }

            int maxi = n[winners[0]], imaxi = 0;
            for (int i = 1; i < winners.Count; i++)
                if (n[winners[i]] > maxi)
                {
                    maxi = n[winners[i]];
                    imaxi = winners[i];
                }

            int mini = n[losers[0]], imini = 0;
            for (int i = 1; i < losers.Count; i++)
                if (n[losers[i]] < mini)
                {
                    mini = n[losers[i]];
                    imini = losers[i];
                }
            if (n.Length % 2 == 1)
            {
                imaxi = n[n.Length - 1] > maxi ? n.Length - 1 : imaxi;
                imini = n[n.Length - 1] < mini ? n.Length - 1 : imini;
            }
            Console.WriteLine($"Cel mai mare element din vector este pe pozitia {imaxi + 1} iar cel mai mic element este pe pozitia {imini + 1}.");
        }
        static void _4()
        {
            int[] n = citireVector();
            int mini = n[0], maxi = n[0], apMini = 1, apMaxi = 1;
            for (int i = 1; i < n.Length; i++)
            {
                if (n[i] <= mini)
                {
                    if (mini == n[i])
                        apMini++;
                    else
                    {
                        mini = n[i];
                        apMini = 1;
                    }
                }
                if (n[i] >= maxi)
                {
                    if (maxi == n[i])
                        apMaxi++;
                    else
                    {
                        maxi = n[i];
                        apMaxi = 1;
                    }
                }
            }
            Console.WriteLine($"Cea mai mare valoare din sir este {maxi} si apare de {apMaxi} ori iar cea mai mica valoare din sir este {mini} si apare de {apMini} ori.");
        }
        static void _5()
        {
            int e = citireInt("e"), k = citireInt("k");
            string[] line = Console.ReadLine().Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);

            int[] n = new int[line.Length + 1];
            for (int i = 0; i < line.Length; i++)
                n[i] = int.Parse(line[i]);

            for (int i = n.Length - 1; i > k; i--)
                n[i] = n[i - 1];
            n[k] = e;

            Console.WriteLine("Vectorul nou este:");
            foreach (var i in n)
                Console.Write(i + " ");
            Console.WriteLine();
        }
        static void _6()
        {
            int k = citireInt("k");
            int[] n = citireVector();

            for (int i = k; i < n.Length - 1; i++)
                n[i] = n[i + 1];

            Console.WriteLine("Vectorul nou este:");
            for (int i = 0; i < n.Length - 1; i++)
                Console.Write(n[i] + " ");
            Console.WriteLine();
        }
        static void _7()
        {
            int[] n = citireVector();

            int aux;
            for (int i = 0; i < n.Length / 2; i++)
            {
                aux = n[i];
                n[i] = n[n.Length - 1 - i];
                n[n.Length - 1 - i] = aux;
            }

            Console.WriteLine("Vectorul nou este:");
            foreach (var i in n)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
        static void _8()
        {
            int[] n = citireVector();
            int aux = n[0];

            for (int i = 0; i < n.Length - 1; i++)
                n[i] = n[i + 1];
            n[n.Length - 1] = aux;

            Console.WriteLine("Vectorul nou este:");
            foreach (var i in n)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
        static void _9()
        {
            int k = citireInt("k");
            int[] n = citireVector();

            while (k-- > 0)
            {
                int aux = n[0];

                for (int i = 0; i < n.Length - 1; i++)
                    n[i] = n[i + 1];
                n[n.Length - 1] = aux;
            }

            Console.WriteLine("Vectorul nou este:");
            foreach (var i in n)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
        static void _10()
        {
            int k = citireInt("k");
            int[] n = citireVector();

            int st = 0, dr = n.Length - 1, mij;
            while (st < dr)
            {
                mij = (st + dr) / 2;
                if (k <= n[mij])
                    dr = mij;
                else
                    st = mij + 1;
            }

            Console.WriteLine($"Pozitia elementului k = {k} este {(st == dr ? st : -1)}.");
        }
        static void _11()
        {
            int n = citireInt("n");
            int[] x = new int[n + 1];
            Console.WriteLine("https://upload.wikimedia.org/wikipedia/commons/b/b9/Sieve_of_Eratosthenes_animation.gif");
            Console.WriteLine($"Toate numerele prime mai mici decat {n} sunt:");
            for (int i = 2; i <= n; i++)
            {
                if (x[i] == 0)
                {
                    Console.Write($"{i} ");
                    for (int j = i + i; j <= n; j += i)
                        x[j] = 1;
                }
            }
            Console.WriteLine();
        }
        static void _12()
        {
            int[] n = citireVector();


            for (int i = 0; i < n.Length - 1; i++)
                for (int j = i; j < n.Length; j++)
                    if (n[j] < n[i])
                    {
                        int aux = n[j];
                        n[j] = n[i];
                        n[i] = aux;
                    }
            Console.WriteLine("Vectorul sortat prin selection sort este:");
            foreach (var i in n)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
        static void _13()
        {
            int[] n = citireVector();

            for (int i = 1; i < n.Length - 1; i++)
                for (int j = i; j > 0 && n[j - 1] > n[j]; j--)
                {
                    int aux = n[j - 1];
                    n[j - 1] = n[j];
                    n[j] = aux;
                }
            Console.WriteLine("Vectorul sortat prin insertion sort este:");
            foreach (var i in n)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
        static void _14()
        {
            int[] n = citireVector();

            int iZero = 0;
            for (int i = 0; i < n.Length - iZero; i++)
                if (n[i] == 0)
                {
                    n[i] = n[n.Length - 1 - iZero];
                    n[n.Length - 1 - iZero] = 0;
                    iZero++;
                }

            Console.WriteLine("Vectorul nou cu 0-uri la final este:");
            foreach (var i in n)
                Console.Write($"{i} ");
            Console.WriteLine();
        }
        static void _15()
        {
            int[] n = citireVector();
            int lungime = n.Length;

            for (int i = 0; i < lungime - 1; i++)
                for (int j = i + 1; j < lungime; j++)
                    if (n[i] == n[j])
                    {
                        for (int k = j + 1; k < lungime; k++)
                            n[k - 1] = n[k];
                        lungime--;
                        j--;
                    }

            Console.WriteLine("Vectorul nou format fara elemente care se repeta este:");
            for (int i = 0; i < lungime; i++)
                Console.Write($"{n[i]} ");
            Console.WriteLine();
        }
        static void _16()
        {
            int[] n = citireVector();

            int cmmdc = n[0];
            for (int i = 1; i < n.Length && cmmdc != 0; i++)
                while (n[i] != 0)
                {
                    int r = cmmdc % n[i];
                    cmmdc = n[i];
                    n[i] = r;
                }

            Console.WriteLine($"Cel mai mare divizor comun al elementelor vectorului este {cmmdc}.");
        }
        static void _17()
        {
            int n = citireInt("n");
            int b = citireInt("b");

            int nCopy = n;
            string nr = "";
            if (b >= 2 && b <= 16)
            {
                while (n != 0)
                {
                    nr = (char)(n % b + (n % b < 10 ? '0' : -10 + 'A')) + nr;
                    n /= b;
                }
                Console.WriteLine($"Numarul {nCopy} convertit in baza {b} este egal cu {nr}.");
            }
            else
                Console.WriteLine("Baza tinta trebuie sa fie intre 2 si 16.");


        }
        static void _18()
        {
            int n = citireInt("n");
            int[] v = citireVector();
            int x = citireInt("x");

            int sum = 0;
            for (int i = 0; i <= n; i++)
                sum += v[i] * (int)Math.Pow(x, i);

            Console.WriteLine($"Valoarea polinomului in punctul x = {x} este egal cu {sum}.");
        }

        #endregion

        #region Driver Code
        static void Main(string[] args)
        {
            Console.WriteLine("====================== Problems pool 3 - probleme cu tablouri ======================\n\n");

            string[] cerinte = new string[]
            {

                 "1. Calculati suma elementelor unui vector de n numere citite de la tastatura. Rezultatul se va afisa pe ecran.                                                                                                                                                        ",
                 "2. Se da un vector cu n elemente si o valoare k. Se cere sa se determine prima pozitie din vector pe care apare k. Daca k nu apare in vector rezultatul va fi -1.                                                                                                     ",
                 "3. Sa se determine pozitiile dintr-un vector pe care apar cel mai mic si cel mai mare element al vectorului. Pentru extra-credit realizati programul efectuand 3n/2 comparatii (in cel mai rau caz).                                                                  ",
                 "4. Deteminati printr-o singura parcurgere, cea mai mica si cea mai mare valoare dintr-un vector si de cate ori apar acestea.                                                                                                                                          ",
                 "5. Se da un vector cu n elemente, o valoare e si o pozitie din vector k. Se cere sa se insereze valoarea e in vector pe pozitia k. Primul element al vectorului se considera pe pozitia zero.                                                                         ",
                 "6. Se da un vector cu n elemente si o pozitie din vector k. Se cere sa se stearga din vector elementul de pe pozitia k. Prin stergerea unui element, toate elementele din dreapta lui se muta cu o pozitie spre stanga.                                               ",
                 "7. Reverse. Se da un vector nu n elemente. Se cere sa se inverseze ordinea elementelor din vector. Prin inversare se intelege ca primul element devine ultimul, al doilea devine penultimul etc.                                                                      ",
                 "8. Rotire. Se da un vector cu n elemente. Rotiti elementele vectorului cu o pozitie spre stanga. Prin rotire spre stanga primul element devine ultimul, al doilea devine primul etc.                                                                                  ",
                 "9. Rotire k. Se da un vector cu n elemente. Rotiti elementele vectorului cu k pozitii spre stanga.                                                                                                                                                                    ",
                 "10. Cautare binara. Se da un vector cu n elemente sortat in ordine crescatoare. Se cere sa se determine pozitia unui element dat k. Daca elementul nu se gaseste in vector rezultatul va fi -1.                                                                       ",
                 "11. Se da un numar natural n. Se cere sa se afiseze toate numerele prime mai mici sau egale cu n (ciurul lui Eratostene).                                                                                                                                             ",
                 "12. Sortare selectie. Implementati algoritmul de sortare <Selection Sort>.                                                                                                                                                                                            ",
                 "13. Sortare prin insertie. Implementati algoritmul de sortare <Insertion Sort>.                                                                                                                                                                                       ",
                 "14. Interschimbati elementele unui vector in asa fel incat la final toate valorile egale cu zero sa ajunga la sfarsit. (nu se vor folosi vectori suplimentari - operatia se va realiza inplace cu un algoritm eficient - se va face o singura parcugere a vectorului).",
                 "15. Modificati un vector prin eliminarea elementelor care se repeta, fara a folosi un alt vector.                                                                                                                                                                     ",
                 "16. Se da un vector de n numere naturale. Determinati cel mai mare divizor comun al elementelor vectorului.                                                                                                                                                           ",
                 "17. Se da un numar n in baza 10 si un numar b. 1 < b < 17. Sa se converteasca si sa se afiseze numarul n in baza b.                                                                                                                                                   ",
                 "18. Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x.                                                                  "

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
                                                      () => _16(), () => _17(), () => _18() };

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
