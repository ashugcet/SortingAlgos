namespace AlgoAndDS
{
    public class MergeSortAlgorithm
    {
        public void MergeSort(int[] unsortedArray)
        {
            int unsortedArrayLength = unsortedArray.Length;

            if (unsortedArrayLength < 2)
            {
                return;
            }
            int midIndex = unsortedArrayLength / 2;
            int[] firstArray = new int[midIndex];
            int[] secondArray = new int[unsortedArrayLength - midIndex];

            int i = 0;
            while (i < midIndex)
            {
                firstArray[i] = unsortedArray[i];
                i++;
            }
            while (i < unsortedArrayLength)
            {
                secondArray[i - midIndex] = unsortedArray[i];
                i++;
            }

            MergeSort(firstArray);
            MergeSort(secondArray);
            Merge(firstArray, secondArray, unsortedArray);
        }

        public void Merge(int[] firstArray, int[] secondArray, int [] unsortedArray)
        {
            int i = 0;
            int j = 0;
            int k = 0;
            while (i < firstArray.Length && j < secondArray.Length)
            {
                if (firstArray[i] <= secondArray[j])
                {
                    unsortedArray[k] = firstArray[i];
                    i++;
                }
                else
                {
                    unsortedArray[k] = secondArray[j];
                    j++;
                }
                k++;
            }
            while (i < firstArray.Length)
            {
                unsortedArray[k] = firstArray[i];
                i++;
                k++;
            }

            while (j < secondArray.Length)
            {
                unsortedArray[k] = secondArray[j];
                j++;
                k++;
            }
        }
    }
}
