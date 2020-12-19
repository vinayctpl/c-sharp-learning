class eg105psp
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
		}
		finally
		{
			System.Console.WriteLine("Finally Executed");
		}
	}
}