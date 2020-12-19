class Bulb
{
	private int w;
	public void SetWattage(int e)
	{
		w=e;
	}
	public int GetWattage()
	{
		return w;
	}
}
class BulbFactory
{
	private BulbFactory()
	{
	}
	public static Bulb PrepareBulb(int wattage)
	{
		Bulb b=null;
		if(wattage>=0 && wattage<=240)
		{
			b=new Bulb();
			b.SetWattage(60);
		}
		return b;
	}
}
class eg103psp
{
	public static void Main()
	{
		Bulb k;
		k=BulbFactory.PrepareBulb(60);
		if(k!=null)
		{
			System.Console.WriteLine(k.GetWattage());
		}
	}
}