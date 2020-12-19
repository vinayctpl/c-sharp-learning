class aaa
{
	public void sam()
	{
		int x,y,z;
		x=10;
		y=0;
		z=x/y;
		System.Console.WriteLine(z);
	}
}
class eg85psp
{
	public static void Main()
	{
		aaa a=new aaa();
		try
		{
			a.sam();
		}catch(System.DivideByZeroException)
		{
			System.Console.WriteLine("Caught DBZE");
		}
		System.Console.WriteLine("Neat End");
	}
}