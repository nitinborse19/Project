internal class Solution
{
	public virtual string solution(string s)
	{
	char[] str = S.ToCharArray();
		int n = str.Length;
		for (int i = 0;i < n / 2;i++)
		{
	if (str[i] != '?' && str[n - i - 1] != '?' && str[i] != str[n - i - 1])
	{
	return "NO";
	}
		}
for (int i = 0;i < n;i++)
{
	if (str[i] == '?')
	{
		if (str[n - i - 1] != '?')
		{
		str[i] = str[n - i - 1];
		}
		else
		{
		str[i] = str[n - i - 1] = 'a';
		}
	}
}
string arr = new string(str);
return arr;
	}
}
