using System;
using System.Collections.Generic;

namespace PascalTriangle
{

    class Solution
    {
        public IList<IList<int>> Generate(int numRows)
        {
            IList<IList<int>> triangle = new List<IList<int>>();

            // Base case: numRows = 0
            if (numRows == 0)
                return triangle;

            // First row
            triangle.Add(new List<int> { 1 });

            // Generating Pascal's Triangle for subsequent rows
            for (int i = 1; i < numRows; i++)
            {
                IList<int> row = new List<int>();
                IList<int> prevRow = triangle[i - 1];

                // First element of the row is always 1
                row.Add(1);

                // Generating elements in the middle of the row
                for (int j = 1; j < i; j++)
                {
                    row.Add(prevRow[j - 1] + prevRow[j]);
                }

                // Last element of the row is always 1
                row.Add(1);

                // Add the row to the triangle
                triangle.Add(row);
            }

            return triangle;
        }

        public IList<int> GetRow(int rowIndex)
        {
            IList<int> row = new List<int>();

            // Base case: rowIndex = 0
            if (rowIndex == 0)
            {
                row.Add(1);
                return row;
            }

            // Generating Pascal's Triangle up to the given rowIndex
            IList<int> prevRow = new List<int> { 1 };
            for (int i = 1; i <= rowIndex; i++)
            {
                row.Clear(); // Clear the row for the current iteration

                // First element of the row is always 1
                row.Add(1);

                // Generating elements in the middle of the row
                for (int j = 1; j < i; j++)
                {
                    row.Add(prevRow[j - 1] + prevRow[j]);
                }

                // Last element of the row is always 1
                row.Add(1);

                // Update prevRow for the next iteration
                prevRow = new List<int>(row);
            }

            return row;
        }
    }
    class Program
	{
		static void Main(string[] args)
		{
            Solution solution = new Solution();

            // Test the function with numRows = 5
         //   IList<IList<int>> triangle = solution.Generate(5);

            IList<int> result = solution.GetRow(3);

            // Display the generated triangle
            //foreach (var row in triangle)
            //{
            //    Console.WriteLine(string.Join(" ", row));
            //}
        }
	}
}
