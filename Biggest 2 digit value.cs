internal class Solution
{
	public virtual int solution(string s)
	{
		int max = 0;
	for (int i = 1; i < s.Length();i++)
	{
		int current = (S.charAt(i - 1) - '0') * 10 + (S.charAt(i) - '0');
		if (current > max)
		{
			max = current;
		}
	}
	return max;
	}
}
