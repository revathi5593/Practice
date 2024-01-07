using System;
using System.Collections.Generic;

namespace MoveElementToEnd
{
	class Program
	{
		public static List<int> MoveElementToEnd(List<int> array, int toMove)
		{
			List<int> result = new List<int>();
			
			for (int i = 0; i < array.Count; i++)
			{
				if (array[i] != toMove)
				{
					result.Add(array[i]);
				}
			}
			int noOfElementstoMove = array.Count - result.Count;
			for (int j = 0; j < noOfElementstoMove; j++)
			{
				result.Add(toMove);
			}
			
			return result;
		}
		static void Main(string[] args)
		{
			List<int> arr = new List<int>();
			arr.Add(2);
			arr.Add(1);
			arr.Add(2);
			arr.Add(2);
			arr.Add(2);
			arr.Add(3);
			arr.Add(4);
			arr.Add(2);
			MoveElementToEnd(arr, 2);
			Console.WriteLine("Hello World!");
		}
	}
}
