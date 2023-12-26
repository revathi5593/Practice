using System;
using System.Collections.Generic;
using System.Linq;

namespace TwoSum
{
	class Program
	{
		public static int[] TwoNumberSum(int[] array, int targetSum)
		{
			int[] result ;
			List<int> res = new List<int>();
			Dictionary<int, int> dictionary = new Dictionary<int, int>();

			for (int i = 0; i < array.Length; i++)
			{
				dictionary.Add(i, array[i]);
			}
			for (int i = 0; i < array.Length; i++)
			{
				if (dictionary.ContainsKey(i))
				{
					int y = targetSum - dictionary[i];
					int targetKey = dictionary.FirstOrDefault(x => x.Value == y).Key;
					if (dictionary.ContainsValue(y) && i != targetKey)
					{
						res.Add(dictionary[i]);
						res.Add(y);
					}
				}
			}
			if (res.Count > 0)
			{
				List<int> distinctResult = res.Distinct().ToList();
				result = distinctResult.ToArray();
				return result;
			}
			else
				return new int[0];
		}
		static void Main(string[] args)
		{
			int[] input = new int[] { 3, 5, -4, 8, 11, 1, -1, 6 };
			TwoNumberSum(input, 10);
			Console.WriteLine("Hello World!");
		}
	}
}
