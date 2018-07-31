using System;

namespace TDDChallenge
{
    public class Challenge
    {
        public int[] SortArray(int[] numbers)
        {
            int[] sortedArray = numbers;
            for (int i = 0; i < sortedArray.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (sortedArray[j - 1] > sortedArray[j])
                    {
                        int temp = sortedArray[j - 1];
                        sortedArray[j - 1] = sortedArray[j];
                        sortedArray[j] = temp;
                    }
                }
            }

            return sortedArray;
        }

        public static void Main()
        {

        }
    }
}
