namespace AlgoAndDS
{
    public class InsertionSortAlgorithm
    {
        public void InsertionSort(int[] unsortedArray)
        {
            int i = 0;
            while (i < unsortedArray.Length)
            {
                int j = i;
                while (j > 0 && unsortedArray[j - 1] > unsortedArray[j])
                {
                    Swap(unsortedArray, j, j - 1);
                    j--;
                }
                i++;
            }
        }
        public void Swap(int[] array, int index1, int index2)
        {
            array[index1] = array[index1] + array[index2];
            array[index2] = array[index1] - array[index2];
            array[index1] = array[index1] - array[index2];
        }
    }
        
    }