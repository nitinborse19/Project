using System;

internal class G
{

	internal static int getSum(int n)
	{
		int sum = 0;
		while (n != 0)
		{
			sum = sum + n % 10;
			n = n / 10;
		}
		return sum;
	}
	internal static void smallestNumber(int N)
	{

		int i = getSum(N);
		int d = i * 2;
		int k = N;
		while (k < 100000)
		{
			if (getSum(k) == d)
			{
				Console.WriteLine(k);
				return;
			}
			k++;
		}
	}

	public static void Main(string[] args)
	{
		int N = 99;
		smallestNumber(N);
	}
}
