using System;
using System.Collections.Generic;

namespace SortedSquare
{
	class Program
	{
		public int[] SortedSquaredArray(int[] array)
		{
			List<int> result = new List<int>();
			foreach (int i in array)
			{
				result.Add(i * i);
			}
			if (result.Count > 0)
			{
				result.Sort();
				return result.ToArray();
			}
			else
				return new int[] { };
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
