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
			SmallestDifference_V2(arrayOne, arrayTwo);
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

		public static int[] SmallestDifference_V2(int[] arrayOne, int[] arrayTwo)
		{
			// Sort the arrays
			Array.Sort(arrayOne);
			Array.Sort(arrayTwo);

			int[] result = new int[2];
			int smallestDiff = int.MaxValue;
			int i = 0;
			int j = 0;

			while (i < arrayOne.Length && j < arrayTwo.Length)
			{
				int currentDiff = Math.Abs(arrayOne[i] - arrayTwo[j]);

				if (currentDiff < smallestDiff)
				{
					smallestDiff = currentDiff;
					result[0] = arrayOne[i];
					result[1] = arrayTwo[j];
				}

				if (arrayOne[i] < arrayTwo[j])
					i++;
				else
					j++;
			}

			return result;
		}
	}
}
