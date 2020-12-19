class aaa
{
	public void sam(long g)
	{
		System.Console.WriteLine("long :"+g);
	}
	public void sam(int g)
	{
		System.Console.WriteLine("int :"+g);
	}
}
class eg62psp
{
	public static void Main()
	{
		aaa a=new aaa();
		long e=20;
		int f=20;
		a.sam(e);
		a.sam(f);
	}
}