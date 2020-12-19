class aaa
{
	public void sam()
	{
		System.Console.WriteLine("Hello");
	}
	virtual public void tom()
	{
	}
}
class bbb:aaa
{
	sealed public override void tom()
	{
		System.Console.WriteLine("Good");
	}
}
class ccc:bbb
{
	public override void tom()
	{
		System.Console.WriteLine("Clear");
	}
}
class eg55psp
{
	public static void Main()
	{
	}
}