using System;

public virtual int solution(int N)
{
	 int ans = ((N % 9 + 1) * (int) Math.Pow(10, (N / 9)) - 1);
	 return ans;

}
