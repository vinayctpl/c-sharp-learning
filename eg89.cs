using System;
class eg89psp
{
	public static void Main()
	{
		int x,y,z;
		x=10;
		y=2;
		int []j;
		j=new int[3];
		try
		{
			j[40]=30;
			z=x/y;
			System.Console.WriteLine(z);
			try
			{
				j[10]=34;
				System.Console.WriteLine(j[10]);
			}catch(IndexOutOfRangeException)
			{
				System.Console.WriteLine("Caught IOORE");
			}
		}
		catch(DivideByZeroException)
		{
			System.Console.WriteLine("Caught DBZE");
		}
	}
}
