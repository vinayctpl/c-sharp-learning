using System;
class eg104psp
{
	public static void Main()
	{
		try
		{
			int x,y,z;
			x=10;
			y=2;
			z=x/y;
			System.Console.WriteLine(z);
		}catch(ArithmeticException)
		{
			System.Console.WriteLine("Caught AE");
		}
		finally
		{
			System.Console.WriteLine("Finally Executed");
		}
	}
}