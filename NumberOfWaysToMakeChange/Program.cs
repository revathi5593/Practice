using System;

public class Program
{
    public static int NumberOfWaysToMakeChange(int n, int[] denoms)
    {
        // Create an array to store the number of ways for each amount
        int[] ways = new int[n + 1];

        // There is one way to make change for 0
        ways[0] = 1;

        // Iterate through each coin denomination
        foreach (int denom in denoms)
        {
            // Update the ways array for each amount greater than or equal to the current denomination
            for (int amount = denom; amount <= n; amount++)
            {
                ways[amount] += ways[amount - denom];
            }
        }

        // The final result is stored in the last element of the ways array
        return ways[n];
    }

    // Example usage
    public static void Main(string[] args)
    {
        int targetAmount = 6;
        int[] coinDenoms = { 1, 5 };

        int result = NumberOfWaysToMakeChange(targetAmount, coinDenoms);

        Console.WriteLine($"Number of ways to make change for {targetAmount} is: {result}");
    }
}
