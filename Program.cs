using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace AlgoAndDS
{
    class Program
    {
        private static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();

            #region MergeSort
            int[] unsortedArray = {5,7,2,9,3,4,6,1,8};

            Console.Write("UnsortedArray is: [");
            int i = 0;
            foreach (var item in unsortedArray)
            {
                Console.Write(item);
                if (i < unsortedArray.Length - 1)
                    Console.Write(", ");
                i++;
            }
            Console.Write("]");
            Console.WriteLine();
            Console.WriteLine();

            MergeSortAlgorithm mergeSortAlgorithm = new MergeSortAlgorithm();
            
            watch.Start();
            mergeSortAlgorithm.MergeSort(unsortedArray);
            watch.Stop();

            Console.WriteLine("MiliSeconds taken by Merge Sort algorithm is: " + watch.ElapsedMilliseconds);
            Console.Write("SortedArray using Merge Sort algorithm is: [");
            i = 0;
            foreach (var item in unsortedArray)
            {
                Console.Write(item);
                if ( i < unsortedArray.Length -1)
                Console.Write(", ");
                i++;
            }
            Console.Write("]");

            #endregion

            #region QuickSort

            Console.WriteLine();
            Console.WriteLine();

           int[] unsortedArray1 = { 5,7,2,9,3,4,6,1,8};

            QuickSortAlgorithm quickSortAlgorithm = new QuickSortAlgorithm();
            watch.Start();
            quickSortAlgorithm.QuickSort(unsortedArray1, 0, unsortedArray1.Length-1);
            watch.Stop();
            Console.WriteLine("MiliSeconds taken by Quick Sort algorithm is: " + watch.ElapsedMilliseconds);
            Console.Write("SortedArray using Quick Sort algorithm is: [");
            i = 0;
            foreach (var item in unsortedArray1)
            {
                Console.Write(item);
                if (i < unsortedArray1.Length - 1)
                    Console.Write(", ");
                i++;
            }
            Console.Write("]");
            Console.WriteLine();

            #endregion

            #region InsertionSort

            Console.WriteLine();
            Console.WriteLine();

            int[] unsortedArray2 = { 5, 7, 2, 9, 3, 4, 6, 1, 8 };

            InsertionSortAlgorithm insertionSortAlgorithm = new InsertionSortAlgorithm();
            watch.Start();
            insertionSortAlgorithm.InsertionSort(unsortedArray2);
            watch.Stop();
            Console.WriteLine("MiliSeconds taken by Insertion Sort algorithm is: " + watch.ElapsedMilliseconds);
            Console.Write("SortedArray using Insertion Sort algorithm is: [");
            i = 0;
            foreach (var item in unsortedArray2)
            {
                Console.Write(item);
                if (i < unsortedArray2.Length - 1)
                    Console.Write(", ");
                i++;
            }
            Console.Write("]");
            Console.WriteLine();

            #endregion

            #region HeapSort

            Console.WriteLine();
            Console.WriteLine();

            int[] unsortedArray3 = { 5, 7, 2, 9, 3, 4, 6, 1, 8 };

            HeapSortAlgorithm heapSortAlgorithm = new HeapSortAlgorithm();
            watch.Start();
            heapSortAlgorithm.HeapSort(unsortedArray3);
            watch.Stop();
            Console.WriteLine("MiliSeconds taken by Heap Sort algorithm is: " + watch.ElapsedMilliseconds);
            Console.Write("SortedArray using Heap Sort algorithm is: [");
            i = 0;
            foreach (var item in unsortedArray3)
            {
                Console.Write(item);
                if (i < unsortedArray3.Length - 1)
                    Console.Write(", ");
                i++;
            }
            Console.Write("]");
            Console.WriteLine();

            #endregion

            #region Anagrams

            string[] stringArray = {"eat", "tea", "tan", "ate", "nat", "bat"};

            Console.WriteLine();
            Console.WriteLine();
            Console.Write("**********************************************************************************");
            Console.WriteLine();
            Console.WriteLine();
            Console.Write("String Array is: [");
            i = 0;
            foreach (var item in stringArray)
            {
                Console.Write(item);
                if (i < stringArray.Length - 1)
                    Console.Write(", ");
                i++;
            }
            Console.Write("]");

            AnagramCheckAlgorithm anagramCheckAlgorithm = new AnagramCheckAlgorithm();
            Dictionary<string, IList<string>> dictAnagrams = anagramCheckAlgorithm.GroupAnagrams(stringArray);

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Anagrams in sorted order are:");
            Console.WriteLine();
            Console.WriteLine("[");
            int j = 0;
            foreach (var item in dictAnagrams)
            {
                Console.Write("  [");
                i = 0;
                stringArray = item.Value.ToArray();
                Array.Sort(stringArray);
                foreach (var itemString in stringArray)
                {
                    Console.Write(itemString);
                    if (i < item.Value.Count - 1)
                        Console.Write(", ");
                    i++;
                }
                Console.Write("]");
                if (j < dictAnagrams.Count - 1)
                    Console.Write(", ");
                j++;
                Console.WriteLine();
            }
            Console.WriteLine("]");

            #endregion

            Console.ReadLine();
        }
    }
}
