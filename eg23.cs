class Bulb
{
private int w;
public Bulb()
{
w=60;
}
public Bulb(int e)
{
w=e;
}
public int GetWattage()
{
return w;
}
public void SetWattage(int e)
{
w=e;
}
}
class eg23psp
{
public static void Main()
{
Bulb b1=new Bulb(100);
Bulb b2=new Bulb();
System.Console.WriteLine(b1.GetWattage());
System.Console.WriteLine(b2.GetWattage());
}
}
