class eg83psp
{
	public static void Main()
	{
		int x,y,z;
		x=10;
		y=0;
		try
		{
			z=x/y;
			System.Console.WriteLine(z);
		}catch(System.DivideByZeroException ae)
		{
			System.Console.WriteLine("y reset to 1");
			y=1;
			z=x;
			System.Console.WriteLine(z);
		}
		System.Console.WriteLine("Neat End");
	}
}