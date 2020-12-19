class Bulb
{
	private int w;
	public void setWattage(int e)
	{
		w=e;
	}
	public int getWattage()
	{
		return w;
	}
}
class eg72psp
{
	public static void Main()
	{
		Bulb[] b=new Bulb[2];
		b[0]=new Bulb();
		b[1]=new Bulb();
		b[0].setWattage(60);
		b[1].setWattage(100);
		System.Console.WriteLine(b[0].getWattage());
		System.Console.WriteLine(b[1].getWattage());
	}
}