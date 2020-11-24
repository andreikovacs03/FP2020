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
19. Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar). 
20. Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem. 
21. Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar). 
22. Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat. 
23. Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare. 
24. Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).
25. (Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate. 
26. Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere. 
27. Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat. 
28. Quicksort. Sortati un vector folosind metoda QuickSort. 
29. MergeSort. Sortati un vector folosind metoda MergeSort.
30. Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima. 
31. (Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara). 
*/

using System;
using System.Collections.Generic;
using System.Linq;

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
        static void _19()
        {
            Console.WriteLine("Vectorul s: ");
            int[] s = citireVector();

            Console.WriteLine("Vectorul p: ");
            int[] p = citireVector();

            int j, aparitii = 0;
            for (int i = 0; i < s.Length - p.Length; i++)
            {
                for (j = 0; j < p.Length && s[i + j] != p[j]; j++) ;

                if (j == p.Length)
                    aparitii++;
            }

            Console.WriteLine($"Vectorul p apare in vectorul s de {aparitii} ori.");
        }
        static void _20()
        {
            // cerinta foarte foarte vaga

            int[] a = citireVector();
            int[] b = citireVector();

            int i = 0, suprapuneri = 0;
            while (i < a.Length && i < b.Length)
                suprapuneri += a[i] == b[i++] ? 1 : 0;

            Console.WriteLine($"Numarul de suprapuneri de margele este {suprapuneri}.");
        }
        static void _21()
        {
            Console.WriteLine("Introduceti n cuvinte pe aceeasi linie delimitate de un spatiu:");
            string[] v1 = Console.ReadLine().Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine("Introduceti n cuvinte pe aceeasi linie delimitate de un spatiu:");
            string[] v2 = Console.ReadLine().Split(new string[] { " ", "," }, StringSplitOptions.RemoveEmptyEntries);

            string s1 = "", s2 = "";

            foreach (var letter in v1)
                s1 += letter;

            foreach (var letter in v2)
                s2 += letter;



            Console.WriteLine($"Ordinea lexicografica a s1 si s2 este : {(String.Compare(s1, s2) < 0 ? "s1" : "s2")} < {(String.Compare(s1, s2) < 0 ? "s1" : "s2")} ");
        }
        static void _22()
        {
            Console.WriteLine("Vectorul A:");
            int[] a = citireVector().Distinct().ToArray();


            Console.WriteLine("Vectorul B:");
            int[] b = citireVector().Distinct().ToArray();

            string s = "";


            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < b.Length; j++)
                    if (a[i] == b[j])
                        s += $"{a[i]}, ";

            s = s.Remove(s.Length - 2);
            Console.WriteLine($"A intersectat cu B = {{ {s} }} ");
            s = "";

            for (int i = 0; i < a.Length; i++)
                s += $"{a[i]}, ";

            bool ok;
            for (int j = 0; j < b.Length; j++)
            {
                ok = true;
                for (int i = 0; i < a.Length && ok; i++)
                    ok = a[i] != b[j];
                s += ok ? $"{b[j]}, " : "";
            }

            s = s.Remove(s.Length - 2);
            Console.WriteLine($"A reunit cu B = {{ {s} }} ");
            s = "";

            for (int i = 0; i < a.Length; i++)
            {
                ok = true;
                for (int j = 0; j < b.Length && ok; j++)
                    ok = a[i] != b[j];
                s += ok ? $"{a[i]}, " : "";
            }


            s = s.Remove(s.Length - 2);
            Console.WriteLine($"A - B = {{ {s} }} ");
            s = "";



            for (int j = 0; j < b.Length; j++)
            {
                ok = true;
                for (int i = 0; i < a.Length && ok; i++)
                    ok = a[i] != b[j];
                s += ok ? $"{b[j]}, " : "";
            }

            if (s.Length > 0)
                s = s.Remove(s.Length - 2);
            Console.WriteLine($"B - A = {{ {s} }} ");
            s = "";
        }
        static void _23()
        {
            _22();
        }
        static void _24()
        {
            int[] auxA = citireVector();
            int[] a = new int[auxA.Length];
            int n = 0;

            for (int i = 0; i < auxA.Length; i++)
                if (auxA[i] == 1)
                    a[n++] = i;

            int m = 0;
            int[] auxB = citireVector();
            int[] b = new int[auxB.Length];

            for (int i = 0; i < auxB.Length; i++)
                if (auxB[i] == 1)
                    b[m++] = i;

            string s = "";


            for (int i = 0; i < n; i++)
                for (int j = 0; j < m; j++)
                    if (a[i] == b[j])
                        s += $"{a[i]}, ";

            s = s.Remove(s.Length - 2);
            Console.WriteLine($"A intersectat cu B = {{ {s} }} ");
            s = "";

            for (int i = 0; i < n; i++)
                s += $"{a[i]}, ";

            bool ok;
            for (int j = 0; j < m; j++)
            {
                ok = true;
                for (int i = 0; i < n && ok; i++)
                    ok = a[i] != b[j];
                s += ok ? $"{b[j]}, " : "";
            }

            s = s.Remove(s.Length - 2);
            Console.WriteLine($"A reunit cu B = {{ {s} }} ");
            s = "";

            for (int i = 0; i < n; i++)
            {
                ok = true;
                for (int j = 0; j < m && ok; j++)
                    ok = a[i] != b[j];
                s += ok ? $"{a[i]}, " : "";
            }


            s = s.Remove(s.Length - 2);
            Console.WriteLine($"A - B = {{ {s} }} ");
            s = "";



            for (int j = 0; j < m; j++)
            {
                ok = true;
                for (int i = 0; i < n && ok; i++)
                    ok = a[i] != b[j];
                s += ok ? $"{b[j]}, " : "";
            }

            if (s.Length > 0)
                s = s.Remove(s.Length - 2);
            Console.WriteLine($"B - A = {{ {s} }} ");
            s = "";
        }
        static void _25()
        {
            int[] v1 = citireVector();
            int[] v2 = citireVector();
            int[] v3 = new int[v1.Length + v2.Length];

            int i = 0, j = 0, k = 0;
            while (i < v1.Length && j < v2.Length)
                if (v1[i] <= v2[j])
                    v3[k++] = v1[i++];
                else
                    v3[k++] = v2[j++];

            while (i < v1.Length)
                v3[k++] = v1[i++];

            while (j < v2.Length)
                v3[k++] = v2[j++];

            string s = $"{v3[0]}";
            for (i = 1; i < v3.Length; i++)
                s += $", {v3[i]}";

            Console.WriteLine($"Vectorul nou interclasat:\n{s}");
        }
        static void _26()
        {
            int[] v1 = citireVector();
            int[] v2 = citireVector();
            int[] v3 = new int[v1.Length > v2.Length ? v1.Length + 1 : v2.Length + 1];

            int k1 = v1.Length - 1, k2 = v2.Length - 1, k3 = v3.Length - 1, sum = 0;
            while (k1 >= 0 && k2 >= 0)
            {
                sum += v1[k1] + v2[k2];
                v3[k3] = sum % 10;
                sum /= 10;
                k1--;
                k2--;
                k3--;
            }

            while (k1 >= 0)
            {
                sum += v1[k1];
                v3[k3] = sum % 10;
                sum /= 10;
                k1--;
                k3--;
            }

            while (k2 >= 0)
            {
                sum += v2[k2];
                v3[k3] = sum % 10;
                sum /= 10;
                k2--;
                k3--;
            }

            if (sum != 0)
                v3[k3--] = sum;

            string s3 = "";
            for (int i = k3 + 1; i < v3.Length; i++)
                s3 += v3[i];

            Console.WriteLine($"a + b = {s3}");
        }
        static void _27()
        {
            int[] v = citireVector();
            int k = citireInt("k");

            Array.Sort(v);
            Console.WriteLine($"Elementul al {k}-lea din vectorul sortat este {v[k]}");
        }
        static int partition(int[] x, int l, int r)
        {
            int pivotIndex = l;

            for (int i = l; i < r; i++)
                if (x[i] < x[r])
                    pivotIndex++;
            (x[pivotIndex], x[r]) = (x[r], x[pivotIndex]);

            return pivotIndex;
        }
        static void quickSort(int[] x, int l, int r)
        {
            if (l < r)
            {
                int pi = partition(x, l, r);
                quickSort(x, l, pi - 1);
                quickSort(x, pi + 1, r);
            }
        }
        static void _28()
        {
            int[] x = citireVector();

            quickSort(x, 0, x.Length - 1);

            Console.WriteLine("Vectorul sortat prin quick-sort este:");
            printVector(x);
        }
        static void printVector(int[] x)
        {
            Console.Write($"{x[0]}");
            for (int i = 1; i < x.Length; i++)
                Console.Write($", {x[i]}");
            Console.WriteLine();
        }
        static void merge(int[] x, int l, int m, int r)
        {
            int sizeL = m - l + 1, sizeR = r - m;
            int[] L = new int[sizeL + 1];
            int[] R = new int[sizeR + 1];

            for (int i = 0; i < sizeL; i++)
                L[i] = x[l + i];
            for (int i = 0; i < sizeR; i++)
                R[i] = x[m + 1 + i];

            L[L.Length - 1] = int.MaxValue;
            R[R.Length - 1] = int.MaxValue;

            for (int i = 0, j = 0, k = l; k <= r; k++)
                x[k] = L[i] < R[j] ? L[i++] : R[j++];
        }
        static void mergeSort(int[] x, int l, int r)
        {
            if (l < r)
            {
                int m = (l + r) / 2;

                mergeSort(x, l, m);
                mergeSort(x, m + 1, r);
                merge(x, l, m, r);
            }
        }
        static void _29()
        {
            int[] x = citireVector();

            mergeSort(x, 0, x.Length - 1);

            Console.WriteLine("Vectorul sortat prin merge-sort este:");
            printVector(x);
        }
        static void _30()
        {
            Console.WriteLine("Vectorul E:");
            int[] E = citireVector();

            Console.WriteLine("Vectorul W:");
            int[] W = citireVector();

            for (int i = 0; i < E.Length - 1; i++)
                for (int j = i + 1; j < E.Length; j++)
                    if (E[i] > E[j])
                    {
                        (E[i], E[j]) = (E[j], E[i]);
                        (W[i], E[j]) = (W[j], W[i]);
                    }

            for (int i = 0; i < E.Length - 1;)
            {
                int j;
                for (j = i + 1; j < E.Length && E[i] == E[j]; j++) ;

                for (int k = i; k < j - 1; k++)
                    for (int t = k + 1; t < j; t++)
                        if (W[k] > W[t])
                        {
                            (W[k], W[t]) = (W[t], W[k]);
                            (E[k], E[t]) = (E[t], E[k]);
                        }
                i = j;
            }

            Console.WriteLine("Vectorul E sortat cu ponderile din W:");
            printVector(E);

            Console.WriteLine();

            Console.WriteLine("Vectorul de ponderi W:");
            printVector(W);

        }
        static void _31()
        {
            Console.WriteLine("Introduceti numere naturale intre [0,1000]:");
            int[] x = citireVector();
            int[] freq = new int[1001];
            int m = -1;

            foreach (var i in x)
                freq[i]++;

            for (int i = 0; i < freq.Length; i++)
                if (freq[i] > x.Length / 2)
                {
                    m = i;
                    break;
                }

            Console.WriteLine($"{(m != -1 ? $"Exista element majoritate si este {m}." : "Nu exista element majoritate.")}");
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
                 "18. Se da un polinom de grad n ai carui coeficienti sunt stocati intr-un vector. Cel mai putin semnificativ coeficient este pe pozitia zero in vector. Se cere valoarea polinomului intr-un punct x.                                                                  ",
                 "19. Se da un vector s (vectorul in care se cauta) si un vector p (vectorul care se cauta). Determinati de cate ori apare p in s. De ex. Daca s = [1,2,1,2,1,3,1,2,1] si p = [1,2,1] atunci p apare in s de 3 ori. (Problema este dificila doar daca o rezolvati cu un algoritm liniar).                                                                                                  ",
                 "20. Se dau doua siraguri de margele formate din margele albe si negre, notate s1, respectiv s2. Determinati numarul de suprapuneri (margea cu margea) a unui sirag peste celalalt astfel incat margelele suprapuse au aceeasi culoare. Siragurile de margele se pot roti atunci cand le suprapunem.                                                                                      ",
                 "21. Se dau doi vectori. Se cere sa se determine ordinea lor lexicografica (care ar trebui sa apara primul in dictionar).                                                                                                                                                                                                                                                                 ",
                 "22. Se dau doi vectori v1 si v2. Se cere sa determine intersectia, reuniunea, si diferentele v1-v2 si v2 -v1 (implementarea operatiilor cu multimi). Elementele care se repeta vor fi scrise o singura data in rezultat.                                                                                                                                                                 ",
                 "23. Aceleasi cerinte ca si la problema anterioara dar de data asta elementele din v1 respectiv v2  sunt in ordine strict crescatoare.                                                                                                                                                                                                                                                    ",
                 "24. Aceleasi cerinte ca si la problema anterioara dar de data asta elementele sunt stocate ca vectori cu valori binare (v[i] este 1 daca i face parte din multime si este 0 in caz contrar).                                                                                                                                                                                             ",
                 "25. (Interclasare) Se dau doi vector sortati crescator v1 si v2. Construiti un al treilea vector ordonat crescator format din toate elementele din  v1 si v2. Sunt permise elemente duplicate.                                                                                                                                                                                           ",
                 "26. Se dau doua numere naturale foarte mari (cifrele unui numar foarte mare sunt stocate intr-un vector - fiecare cifra pe cate o pozitie). Se cere sa se determine suma, diferenta si produsul a doua astfel de numere.                                                                                                                                                                 ",
                 "27. Se da un vector si un index in vectorul respectiv. Se cere sa se determine valoarea din vector care va fi pe pozitia index dupa ce vectorul este sortat.                                                                                                                                                                                                                             ",
                 "28. Quicksort. Sortati un vector folosind metoda QuickSort.                                                                                                                                                                                                                                                                                                                              ",
                 "29. MergeSort. Sortati un vector folosind metoda MergeSort.                                                                                                                                                                                                                                                                                                                              ",
                 "30. Sortare bicriteriala. Se dau doi vectori de numere intregi E si W, unde E[i] este un numar iar W[i] este un numar care reprezinta ponderea lui E[i]. Sortati vectorii astfel incat elementele lui E sa fie in in ordine crescatoare iar pentru doua valori egale din E, cea cu pondere mai mare va fi prima.                                                                         ",
                 "31. (Element majoritate). Intr-un vector cu n elemente, un element m este element majoritate daca mai mult de n/2 din valorile vectorului sunt egale cu m (prin urmare, daca un vector are element majoritate acesta este unui singur).  Sa se determine elementul majoritate al unui vector (daca nu exista atunci se va afisa <nu exista>). (incercati sa gasiti o solutie liniara).   ",
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
                                                      () => _16(), () => _17(), () => _18(),
                                                      () => _19(), () => _20(), () => _21(),
                                                      () => _22(), () => _23(), () => _24(),
                                                      () => _25(), () => _26(), () => _27(),
                                                      () => _28(), () => _29(), () => _30(), ()=>_31()
                    };

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
