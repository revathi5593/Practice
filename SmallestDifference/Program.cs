using System;

namespace SmallestDifference
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arrayOne = new int[] { -1, 5, 10, 20, 28, 3 };
			int[] arrayTwo = new int[] { 26, 134, 135, 15, 17 };
			SmallestDifference(arrayOne, arrayTwo);
		}
		public static int[] SmallestDifference(int[] arrayOne, int[] arrayTwo)
		{
			// Write your code here.
			int[] result = new int[2];

			int smallestDiff = int.MaxValue;
			for (int i = 0; i < arrayOne.Length; i++)
			{
				for (int j = 0; j < arrayTwo.Length; j++)
				{
					int tempDiff = Math.Abs(arrayOne[i] - arrayTwo[j]);
					if (tempDiff < smallestDiff) {
						smallestDiff = tempDiff;
						result[0] = arrayOne[i];
						result[1] = arrayTwo[j];
					}
				}
			}
			return result;
		}
	}
}
