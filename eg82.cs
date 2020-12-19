class eg82psp
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

		}
		System.Console.WriteLine("Neat End");
	}
}