class bbb
{
	private int []x;
	public int Length
	{
		get
		{
			return x.Length;
		}
	}
	public bbb()
	{
		x=new int[10];
	}
	public int this[int e]
	{
		set
		{
			x[e]=value;
		}
		get
		{
			return x[e];
		}
	}
}
class eg113psp
{
	public static void Main()
	{
		bbb b=new bbb();
		b[0]=44;
		System.Console.WriteLine(b[0]);
		System.Console.WriteLine(b.Length);
	}
}