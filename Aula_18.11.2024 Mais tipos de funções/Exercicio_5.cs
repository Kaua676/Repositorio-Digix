using System;
using System.Diagnostics;

namespace Exercicio_5
{
    class Program
    {
        static int MeasureTime(Action sortMethod)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            sortMethod();
            stopwatch.Stop();
            return (int)stopwatch.ElapsedMilliseconds;
        }

        static void BubbleSort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void SelectionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[minIndex];
                arr[minIndex] = temp;
            }
        }

        static void InsertionSort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                int key = arr[i];
                int j = i - 1;
                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = key;
            }
        }

        static void Main(string[] args)
        {
            Random rand = new Random();
            int[] arr = new int[1000];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 10001);
            }

            var bubbleSortTime = MeasureTime(() => BubbleSort((int[])arr.Clone()));
            var selectionSortTime = MeasureTime(() => SelectionSort((int[])arr.Clone()));
            var insertionSortTime = MeasureTime(() => InsertionSort((int[])arr.Clone()));

            Console.WriteLine($"Bubble Sort: {bubbleSortTime}ms");
            Console.WriteLine($"Selection Sort: {selectionSortTime}ms");
            Console.WriteLine($"Insertion Sort: {insertionSortTime}ms");

            int minTime = Math.Min(bubbleSortTime, Math.Min(selectionSortTime, insertionSortTime));
            if (minTime == bubbleSortTime) Console.WriteLine("Melhor desempenho: Bubble Sort");
            else if (minTime == selectionSortTime) Console.WriteLine("Melhor desempenho: Selection Sort");
            else Console.WriteLine("Melhor desempenho: Insertion Sort");
        }
    }
}