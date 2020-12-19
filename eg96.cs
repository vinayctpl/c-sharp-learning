using System;
class eg103psp
{
	public static void Main()
	{
		try
		{
			int x,y,z;
			x=10;
			y=0;
			z=x/y;
			System.Console.WriteLine(z);
		}catch(DivideByZeroException)
		{
			System.Console.WriteLine("Caught DBZE");
		}
		finally
		{
			System.Console.WriteLine("Finally Executed");
		}
	}
}