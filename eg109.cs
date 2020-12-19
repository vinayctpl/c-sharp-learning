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
class bbb:aaa
{
	public void sameer()
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
		i.sam();
	}
}