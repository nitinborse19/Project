using System;

public class demoDemo
{
	public virtual int solution(int N, int K)
	{
	int n1, n2, n3, ncopy;
		ncopy = N;
		n3 = ncopy % 10;
		ncopy = ncopy / 10;
		n2 = ncopy % 10;
		ncopy = ncopy / 10;
		n1 = ncopy % 10;
		while (n1 != 9 && K != 0)
		{
			n1 += 1;
			K += -1;
		}
		while (n2 != 9 && K != 0)
		{
			n2 += 1;
			K += -1;
		}
		while (n3 != 9 && K != 0)
		{
			n3 += 1;
			K += -1;

		}


 n1 = n1 * 10 + n2;
 n2 = n1 * 10 + n3;

				return n2;

	}
	public static void Main(string[] args)
	{
		Scanner sc = new Scanner(System.in);
		int n = sc.nextInt();
		int k = sc.nextInt();
			demoDemo d1 = new demoDemo();
			//d1.solution(n, k);
			int result = d1.solution(n, k);
			Console.WriteLine(result);


	}
}






