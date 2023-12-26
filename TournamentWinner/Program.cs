using System;
using System.Collections.Generic;
using System.Linq;

namespace TournamentWinner
{
	class Program
	{
		public static string TournamentWinner(List<List<string>> competitions, List<int> results)
		{
			Dictionary<string, int> Result = new Dictionary<string, int>();
			for (int i = 0; i < results.Count; i++)
			{
				if (results[i] == 0) //away team won
				{
					if (Result.ContainsKey(competitions[i][1]))
					{
						int currentWin = Result[competitions[i][1]];
						Result[competitions[i][1]] = currentWin + 1;
					}
					else
					{
						Result.Add(competitions[i][1], 1);
					}
				}
				else if (results[i] == 1) //home team won
				{
					if (Result.ContainsKey(competitions[i][0]))
					{
						int currentWin = Result[competitions[i][0]];
						Result[competitions[i][0]] = currentWin + 1;
					}
					else
					{
						Result.Add(competitions[i][0], 1);
					}
				}
			}
			var r = Result.Aggregate((l, r) => l.Value > r.Value ? l : r).Key;

			return r;
		}
		static void Main(string[] args)
		{
			List<List<string>> competitions = new List<List<string>> { new List<string>{ "HTML","C#"}, new List<string> { "C#", "Python" }, new List<string> { "Python", "HTML" } };
			//List<string> elements1 = new List<string>();
			//elements1.Add("HTML");
			//elements1.Add("C#");
			//List<string> elements2 = new List<string>();
			//elements2.Add("C#");
			//elements2.Add("Python");
			//List<string> elements3 = new List<string>();
			//elements3.Add("Python");
			//elements3.Add("HTML");
			//competitions.Add(elements1);
			//competitions.Add(elements2);
			//competitions.Add(elements3);
			List<int> results = new List<int> { 0, 0, 1 };
			string res = TournamentWinner(competitions, results);
			Console.WriteLine("Hello World!");
		}
	}
}
