using System;

namespace MaxSubsetSumNoAdjacent
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[] { 75, 105, 120, 75, 90, 135 };
			MaxSubsetSumNoAdjacent(arr);
			Console.WriteLine("Hello World!");
		}
		public static int MaxSubsetSumNoAdjacent(int[] array)
        {
            int n = array.Length;

            if (n == 0)
            {
                return 0;
            }

            if (n == 1)
            {
                return array[0];
            }

            if (n == 2)
            {
                return Math.Max(array[0], array[1]);
            }

            // Initialize an arrayay to store the maximum sum up to each index
            int[] maxSum = new int[n];

            // Set the initial values for the first two elements
            maxSum[0] = array[0];
            maxSum[1] = Math.Max(array[0], array[1]);

            // Iterate through the arrayay to calculate the maximum sum at each index
            for (int i = 2; i < n; i++)
            {
                maxSum[i] = Math.Max(maxSum[i - 1], maxSum[i - 2] + array[i]);
            }

            // The final element of maxSum arrayay contains the maximum sum
            return maxSum[n - 1];
        }
    }
}
