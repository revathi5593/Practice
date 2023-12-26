using System;

namespace NonConstructibleChange
{
	class Program
	{
		public static int NonConstructibleChange(int[] coins)
		{
			Array.Sort(coins);
			int minimum = 0;
			if (coins.Length == 0 || coins[0] > 1)
				return 1;
			for (int i = 0; i < coins.Length; i++)
			{
				if (minimum + 1 < coins[i])
					minimum += coins[i];
				else
					return minimum;

				//if (coins[i] > minimum + 1)
				//	return minimum + 1;
				//minimum += coins[i];
			}
			return minimum + 1;
		}
		static void Main(string[] args)
		{
			int[] input = new int[] { 5, 7, 1, 1, 2, 3, 22 };
			NonConstructibleChange(input);
			Console.WriteLine("Hello World!");
		}
	}
}
