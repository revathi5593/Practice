using System;

namespace LongestPeak
{
	class Program
	{
        public static int LongestPeak(int[] array)
        {
            int longestPeakLength = 0;
            int i = 1; // Start from index 1 to avoid checking peaks at the edges

            while (i < array.Length - 1)
            {
                bool isPeak = array[i - 1] < array[i] && array[i] > array[i + 1];

                if (!isPeak)
                {
                    i++;
                    continue;
                }

                int leftIdx = i - 2;
                while (leftIdx >= 0 && array[leftIdx] < array[leftIdx + 1])
                {
                    leftIdx--;
                }

                int rightIdx = i + 2;
                while (rightIdx < array.Length && array[rightIdx] < array[rightIdx - 1])
                {
                    rightIdx++;
                }

                int currentPeakLength = rightIdx - leftIdx - 1;
                longestPeakLength = Math.Max(longestPeakLength, currentPeakLength);

                i = rightIdx;
            }

            return longestPeakLength;
        }

        static void Main(string[] args)
		{
            int[] array = { 1,2,3,3,4,0,10,6,5,-1,-3,2,3 };
            int result = LongestPeak(array);
            Console.WriteLine("Hello World!");
		}
	}
}
