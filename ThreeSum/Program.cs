using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int[] nums = { 12,3,1,2,-6,5,-8,6 };
        int targetSum = 0;

        List<int[]> result = ThreeSum(nums, targetSum);

        Console.WriteLine("Triplets:");
        foreach (var triplet in result)
        {
            Console.WriteLine(string.Join(", ", triplet));
        }
    }

    static List<int[]> ThreeSum(int[] array, int targetSum)
    {
        Array.Sort(array);
        List<int[]> result = new List<int[]>();

        for (int i = 0; i < array.Length - 2; i++)
        {
            if (i == 0 || (i > 0 && array[i] != array[i - 1]))
            {
                int left = i + 1;
                int right = array.Length - 1;
                int sum = targetSum - array[i];

                while (left < right)
                {
                    if (array[left] + array[right] == sum)
                    {
                        result.Add(new int[] { array[i], array[left], array[right] });

                        while (left < right && array[left] == array[left + 1])
                            left++;

                        while (left < right && array[right] == array[right - 1])
                            right--;

                        left++;
                        right--;
                    }
                    else if (array[left] + array[right] < sum)
                    {
                        left++;
                    }
                    else
                    {
                        right--;
                    }
                }
            }
        }

        return result;
    }
}
