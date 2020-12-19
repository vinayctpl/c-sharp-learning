class aaa
{
	public void sam()
	{
		System.Console.WriteLine("Hello");
	}
	public void tom()
	{
	}
}
class bbb:aaa
{
	public void tom()
	{
		System.Console.WriteLine("good");
	}
}
class eg52psp
{
	public static void Main()
	{
		aaa a;
		a=new bbb();
		a.sam();
		a.tom();
	}
}