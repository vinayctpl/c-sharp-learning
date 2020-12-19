class eg71psp
{
	public static void Main()
	{
		int []x;
		x=new int[3];
		x[0]=30;
		x[1]=43;
		x[2]=44;
		int []t;
		t=new int[5];
		int e;
		for(e=0;e<x.Length;e++)
		{
			t[e]=x[e];
		}
		x=t;
		x[3]=54;
		x[4]=39;
		for(e=0;e<x.Length;e++)
		{
			System.Console.WriteLine(x[e]);
		}
	}
}