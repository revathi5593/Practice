using System;

namespace MinNoOfCoinsForChange
{
	class Program
	{
        public static int MinNumberOfCoinsForChange(int n, int[] denoms)
        {
            int[] dp = new int[n + 1];
            Array.Fill(dp, n + 1); // Initialize with n + 1 (maximum possible coins needed + 1)

            dp[0] = 0;

            for (int i = 1; i <= n; i++)
            {
                foreach (int denom in denoms)
                {
                    if (denom <= i)
                    {
                        dp[i] = Math.Min(dp[i], dp[i - denom] + 1);
                    }
                }
            }

            return dp[n] > n ? -1 : dp[n]; // If dp[n] is greater than n, it means it's impossible
        }
        static void Main(string[] args)
		{
            int[] input = new int[] { 1, 5, 10 };
            MinNumberOfCoinsForChange(7,input);
			Console.WriteLine("Hello World!");
		}
	}
}
