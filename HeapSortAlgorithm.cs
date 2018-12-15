using System;

namespace AlgoAndDS
{
    public class HeapSortAlgorithm
    {
        public void HeapSort(int[] unsortedArray)
        {
            int n = unsortedArray.Length;
            // Build heap (rearrange array) 
            for (int i = n / 2 - 1; i >= 0; i--)
            {
                Heapify(unsortedArray, n, i);
            }

            // One by one extract an element from heap 
            for (int i = n -1; i >= 0; i--)
            {
                // Move current root to end 
                Swap(unsortedArray, 0, i);
                // call max heapify on the reduced heap
                Heapify(unsortedArray, i, 0);
            }
        }

        // To heapify a subtree rooted with node i which is 
        // an index in arr[]. n is size of heap
        private void Heapify(int[] unsortedArray, int n, int i)
        {
            int largest = i; // Initialize largest as root 
            int l = 2 * i + 1; // left = 2*i + 1 
            int r = 2 * i + 2; // right = 2*i + 2 

            // If left child is larger than root 
            if (l < n && unsortedArray[l] > unsortedArray[largest])
                largest = l;

            // If right child is larger than largest so far 
            if (r < n && unsortedArray[r] > unsortedArray[largest])
                largest = r;

            // If largest is not root 
            if (largest != i)
            {
                Swap(unsortedArray, i, largest);

                // Recursively heapify the affected sub-tree 
                Heapify(unsortedArray, n, largest);
            }

            //int t, j;

            //t = unsortedArray[i];
            //j = 2 * i;
            //while (j <= n)
            //{
            //    if (j < n && unsortedArray[j] < unsortedArray[j + 1])
            //        j++;
            //    if (t >= unsortedArray[j])
            //        break;
            //    unsortedArray[j / 2] = unsortedArray[j];
            //    j *= 2;
            //}

            //unsortedArray[j / 2] = t;
        }

        public void Swap(int[] array, int index1, int index2)
        {
            //array[index1] = array[index1] + array[index2];
            //array[index2] = array[index1] - array[index2];
            //array[index1] = array[index1] - array[index2];

            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
