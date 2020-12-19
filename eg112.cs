class Bulb
{
	private int w;
	public int Wattage
	{
		set
		{
			if(value>=0 && value<=240){
				w=value;
			}
			else
			{
				w=0;
			}
		}
		get
		{
			return w;
		}
	}
}
class eg111psp
{
	public static void Main()
	{
		Bulb b=new Bulb();
		b.Wattage=40;
		System.Console.WriteLine(b.Wattage);
	}
}