using System;
using System.Collections.Generic;

internal class GFG
{
// Function to find the smallest
// substring occurring only once
internal static int smallestSubstring(string a)
{
	List<string> a1 = new List<string>();
	for (int i = 0; i < a.Length; i++)
	{
		for (int j = i + 1; j <= a.Length; j++)
		{
			if (i != j)
			{
				a1.Add(a.Substring(i, j - i));
			}
		}
	}
	SortedDictionary<string, int> a2 = new SortedDictionary<string, int>();
	foreach (string s in a1)
	{
		  a2[s] = a2.GetOrDefault(s, 0) + 1;
	}
	List<string> freshlist = new List<string>();
foreach (string s in a2.Keys)
{
		if (a2[s] == 1)
		{
			freshlist.Add(s);
		}
}
	SortedDictionary<string, int> dictionary = new SortedDictionary<string, int>();
	foreach (string s in freshlist)
	{
		dictionary[s] = s.Length;
	}
	List<int> newlist = new List<int>();
	foreach (string s in dictionary.Keys)
	{
		newlist.Add(dictionary[s]);
	}

	int ans = int.MaxValue;
  foreach (int i in newlist)
  {
		ans = Math.Min(ans, i);
  }
	return ans == int.MaxValue ? 0 : ans;
}
public static void Main(string[] args)
{
	string S = "ababaabba";
	Console.WriteLine(smallestSubstring(S));
}
}
