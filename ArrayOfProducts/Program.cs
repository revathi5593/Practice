using System;

namespace ArrayOfProducts
{
	class Program
	{
		public int[] ArrayOfProducts(int[] array)
		{
			int[] result = new int[array.Length];
			int productLeft = 1;
			for (int i = 0; i < array.Length; i++)
			{
				result[i] = productLeft;
				productLeft *= array[i];
				 			
			}
			int productRight = 1;
			for (int i = array.Length -1 ; i >=0 ; i--)
			{
				result[i] *= productRight;
				productRight *= array[i];

			}
			return result;
		}
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
