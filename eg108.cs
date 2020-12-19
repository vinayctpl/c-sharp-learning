interface ii
{
	void sam();
}
class aaa:ii
{
	public void sam()
	{
		System.Console.WriteLine("Hello");
	}
}
class bbb
{
	public void sam()
	{
		System.Console.WriteLine("Great");
	}
}
class eg108psp
{
	public static void Main()
	{
		ii i;
		i=new bbb();
	}
}