class eg84psp
{
	public static void Main()
	{
		int []j;
		j=new int[5];
		int x,y,z;
		x=20;
		y=2;
		try
		{
			z=x/y;
			System.Console.WriteLine(z);
			j[z]=33;
			System.Console.WriteLine(j[z]);
		}catch(System.DivideByZeroException)
		{
			System.Console.WriteLine("Caught dbze");
		}
		catch(System.IndexOutOfRangeException)
		{
			System.Console.WriteLine("Caught AIOORE");
		}
		System.Console.WriteLine("Neat End");
	}
}