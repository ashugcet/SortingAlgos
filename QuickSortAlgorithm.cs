namespace AlgoAndDS
{
    public class QuickSortAlgorithm
    {
        public void QuickSort(int[] unsortedArray, int low, int high)
        {
            if (low < high)
            {
                /* pi is partitioning index, unsortedArray[pi] is now
                   at right place */
                int pi = Partition(unsortedArray, low, high); // pi is actually correct position of the pivot

                QuickSort(unsortedArray, low, pi - 1);  // Before pi
                QuickSort(unsortedArray, pi + 1, high); // After pi
            }
        }

        public int Partition(int[] unsortedArray, int low, int high)
        {
            // pivot (Element to be placed at right position)
            int pivot = unsortedArray[high];

            int i = low;  // Index of smaller element compare to pivot

            for (int j = low; j< high ; j++)
            {
                if (unsortedArray[j] <= pivot)
                {
                    Swap(unsortedArray, i, j);
                    i++;    // increment index of smaller element
                }
            }
            Swap(unsortedArray, i , high);// Put pivot at right place

            return i; // return pivot position
        }

        public void Swap(int[] array, int index1, int index2)
        {
            int temp = array[index1];
            array[index1] = array[index2];
            array[index2] = temp;
        }
    }
}
