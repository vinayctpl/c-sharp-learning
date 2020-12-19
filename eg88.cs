using System;
class eg87psp
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
			z=x/y;
			System.Console.WriteLine(z);
			try
			{
				x=10;
				y=0;
				z=x/y;
				System.Console.WriteLine(z);
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
