using System;
class eg102psp
{
	public static void Main(string []gg)
	{
		if(gg.Length!=2)
		{
			System.Console.WriteLine("Usage : eg109psp num1 num2");
		}
		else
		{
			try
			{
				int sum=Int32.Parse(gg[0])+Int32.Parse(gg[1]);
				System.Console.WriteLine("Sum is "+sum);
			}catch(FormatException fe)
			{
				System.Console.WriteLine(fe);
			}
		}
	}
}