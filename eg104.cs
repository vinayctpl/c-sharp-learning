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
class eg111psp
{
	public static void Main()
	{
		ii i=new aaa();
		i.sam();
	}
}