using System;

namespace FP_Laborator_Problema
{
    // 44. Să se scrie un program care memorează 100 de numere aleatoare cuprinse între 0 și 99
    // întrun tablou și care afișează numerele care se repetă în tablou.
    class Problem44
    {

        static int[] randomArray(int length, int maxValue)
        {
            Random rnd = new Random();
            int[] arr = new int[length];

            for (int i = 0; i < arr.Length; i++)
                arr[i] = rnd.Next(maxValue + 1);

            return arr;
        }

        static void printArray(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                Console.WriteLine("Array is null.");
            else
            {
                Console.Write(arr[0]);
                for (int i = 1; i < arr.Length; i++)
                    Console.Write($", {arr[i]}");
                Console.WriteLine();
            }
        }

        static int[] frequencyOfArray(int[] arr, int maxValue)
        {
            int[] freq = new int[maxValue + 1];

            foreach (var i in arr)
                freq[i]++;

            return freq;
        }

        static int[] repeatingFrequencyArray(int[] arr)
        {
            int[] newArr = new int[arr.Length];
            int length = 0;

            for (int i = 0; i < arr.Length; i++)
                if (arr[i] >= 2)
                    newArr[length++] = i;

            int[] resultArr = new int[length];
            for (int i = 0; i < length; i++)
                resultArr[i] = newArr[i];

            return resultArr;
        }
        static void Main(string[] args)
        {
            const int SIZE = 100;
            const int MAX_VALUE = 99;

            int[] arr = randomArray(SIZE, MAX_VALUE);


            int[] freq = frequencyOfArray(arr, MAX_VALUE);

            Console.WriteLine("The repeating numbers in the random array are: ");
            int[] repeatingValues = repeatingFrequencyArray(freq);

            printArray(repeatingValues);
        }
    }
}
