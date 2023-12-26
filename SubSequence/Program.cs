using System;
using System.Collections.Generic;
using System.Linq;

namespace SubSequence
{
	class Program
	{
		public static bool IsValidSubsequence(List<int> array, List<int> sequence)
		{
			Dictionary<int, int> dictionary = new Dictionary<int, int>();
			int currentidx = 0;
			int dictionaryidx = 0;
			if (array.Count < sequence.Count)
				return false;
			for (int i = 0; i < array.Count; i++)
			{
				dictionary.Add(i, array[i]);
			}
			for (int j = 0; j < sequence.Count; j++)
			{
				if (dictionary.ContainsKey(j))
				{
					if (dictionary.ContainsValue(sequence[j]) && currentidx == 0)
					{
						dictionaryidx = dictionary.FirstOrDefault(x => x.Value == sequence[j]).Key;
						currentidx++;
					}
					else if (dictionary.ContainsValue(sequence[j]) && currentidx > 0)
					{
						int newdictionaryidx = 0;
						newdictionaryidx = dictionary.FirstOrDefault(x => x.Value == sequence[j]).Key;
						if (newdictionaryidx > dictionaryidx)
							dictionaryidx = newdictionaryidx;
						else
							return false;
					}
					else
						return false;
				}
			}
			if (dictionaryidx > 0)
				return true;
			return false;
		 }
		public static bool IsValidSubsequenceV1(List<int> array, List<int> sequence)
		{
			int arrayIndex = 0;
			int sequenceIndex = 0;

			while (arrayIndex < array.Count && sequenceIndex < sequence.Count)
			{
				if (array[arrayIndex] == sequence[sequenceIndex])
				{
					sequenceIndex++;
				}

				arrayIndex++;
			}

			return sequenceIndex == sequence.Count;
		}
		static void Main(string[] args)
		{
			List<int> input = new List<int> { 1, 1, 1, 1, 1 };
			List<int> sub = new List<int> { 1, 1, 1 };
			//bool res = IsValidSubsequence(input, sub);
			bool res1 = IsValidSubsequenceV1(input, sub);
			Console.WriteLine("Hello World!");
		}
	}
}
