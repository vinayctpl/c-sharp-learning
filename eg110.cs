class bbb
{
	public void tom()
	{
		System.Console.WriteLine("Good");
	}
}
interface ii
{
	void sam();
}
class aaa:bbb,ii
{
	public void sam()
	{
		System.Console.WriteLine("hello");
	}
}
class eg110psp
{
	public static void Main()
	{
		ii i;
		i=new aaa();
		i.sam();
	}
}