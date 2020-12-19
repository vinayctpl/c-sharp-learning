abstract class aaa
{
	abstract public void sam();
}
class bbb:aaa
{
	public void lion()
	{
		System.Console.WriteLine("cool");
	}
	public override void sam()
	{
		System.Console.WriteLine("good");
	}
}
class eg61psp
{
	public static void Main()
	{
		bbb b=new bbb();
		b.lion();
		b.sam();
	}
}