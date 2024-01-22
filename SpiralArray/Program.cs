using System;
using System.Collections.Generic;

namespace SpiralArray
{
	class Program
	{
        public static List<int> SpiralTraverse(int[,] array)
        {
            List<int> result = new List<int>();

            int rows = array.GetLength(0);
            int columns = array.GetLength(1);

            int top = 0, bottom = rows - 1, left = 0, right = columns - 1;

            while (top <= bottom && left <= right)
            {
                // Traverse top row
                for (int i = left; i <= right; i++)
                {
                    result.Add(array[top, i]);
                }
                top++;

                // Traverse right column
                for (int i = top; i <= bottom; i++)
                {
                    result.Add(array[i, right]);
                }
                right--;

                // Traverse bottom row
                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        result.Add(array[bottom, i]);
                    }
                    bottom--;
                }

                // Traverse left column
                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        result.Add(array[i, left]);
                    }
                    left++;
                }
            }

            return result;
        }

        static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
		}
	}
}
