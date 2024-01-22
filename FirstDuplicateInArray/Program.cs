using System;
using System.Collections.Generic;

public class Program
{
    public static int FirstDuplicateValue(int[] array)
    {
        HashSet<int> seen = new HashSet<int>();

        foreach (int num in array)
        {
            if (seen.Contains(num))
            {
                return num; // First duplicate found
            }

            seen.Add(num);
        }

        return -1; // No duplicates found
    }

    public static void Main()
    {
        int[] array = { 1, 3, 4, 2, 2, 5 };

        int result = FirstDuplicateValue(array);

        Console.WriteLine($"First duplicate: {result}");
    }
}
