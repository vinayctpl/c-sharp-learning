using System;
class eg107psp
{
	public static void Main()
	{
		String a,b;
		a="101";
		b="101good";
		int x,y;
		try
		{
			x=Int32.Parse(a);
			System.Console.WriteLine("Value of x is "+x);
			y=Int32.Parse(b);
			System.Console.WriteLine("Value of y is "+y);
		}catch(FormatException fe)
		{
			System.Console.WriteLine(fe);
		}
	}
}