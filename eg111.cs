class Bulb
{
	private int w;
	public void SetWattage(int e)
	{
		if(e>=0 && e<=240)
		{
			w=e;
		}
		else
		{
			w=0;
		}
	}
	public int GetWattage()
	{
		return w;
	}
}
class eg111psp
{
	public static void Main()
	{
		Bulb b=new Bulb();
		b.SetWattage(60);
		System.Console.WriteLine(b.GetWattage());
	}
}