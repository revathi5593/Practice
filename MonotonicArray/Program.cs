using System;

namespace MonotonicArray
{
	class Program
	{
		public static bool IsMonotonic(int[] array)
		{
			if (array.Length == 0 || array.Length == 1)
				return true;
            bool increasing = true;
            bool decreasing = true;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[i - 1])
                {
                    decreasing = false;
                }
                else if (array[i] < array[i - 1])
                {
                    increasing = false;
                }

                // If neither increasing nor decreasing, the array is not monotonic
                if (!increasing && !decreasing)
                {
                    return false;
                }
            }

            // If either increasing or decreasing, the array is monotonic
            return increasing || decreasing;
        }
		static void Main(string[] args)
		{
			int[] array = new int[] { -1, -5, -10, -1100, -1101, -1102, -9001 };
			bool result = IsMonotonic(array);
			Console.WriteLine("Hello World!");
		}
	}
}
