using System;
class Converter
{
	public static int ConvertToInt(string data)
	{
		int x=0;
		int y=1;
		char []m;
		m=data.ToCharArray();
		int z=m.Length-1;
		char g;
		while(z>=0)
		{
			g=m[z];
			if(g>=48 && g<=57)
			{
				x=x+((g-48)*y);
			}
			else
			{
				FormatException fe=new FormatException();
				throw fe;
			}
			y=y*10;
			z--;
		}
		return x;
	}
}
class eg99psp
{
	public static void Main()
	{
		String a,b;
		a="101";
		b="101good";
		int x,y;
		try
		{
			x=Converter.ConvertToInt(a);
			System.Console.WriteLine("Value of x is "+x);
			y=Converter.ConvertToInt(b);
			System.Console.WriteLine("Value of y is "+y);
		}catch(FormatException fe)
		{
			System.Console.WriteLine(fe);
		}
	}
}