using System;

namespace TDDChallenge
{
    public class Challenge
    {
        public int[] SortArray(int[] numbers)
        {
            int[] sortedArray = QuickSort(numbers, 0, numbers.Length -1);
            return sortedArray;
        }
        
        private int[] QuickSort(int[] input, int first, int last)
        {
            if (input.Length == 1)
            {
                return input;
            }
            int i = first, j = last, pivot = input[(first + last)/2];
            while(i <= j)
            {
                while (input[i] < pivot) i++;
                while (input[j] > pivot) j--;
                if (i <= j)
                {
                    int tmp = input[i];
                    input[i] = input[j];
                    input[j] = tmp;
                    i++; j--;
                }
            }
            if (first < j)
            {
                QuickSort(input, first, j);
            }
            if (i < last)
            {
                QuickSort(input, i, last);
            }
            return input;
        }

        public static void Main()
        {

        }
    }
}
