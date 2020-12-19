using System;
class Bulb
{
private int w;
static private int p;
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
public static void SetPrice(int e)
{
p=e;
}
public static int GetPrice()
{
return p;
}
}
class eg6psp
{
public static void Main()
{
Bulb b1=new Bulb();
Bulb b2=new Bulb();
b1.SetWattage(60);
Bulb.SetPrice(10);
Console.WriteLine("Wattage is "+b1.GetWattage());
Console.WriteLine("Price is :"+Bulb.GetPrice());
b2.SetWattage(100);
Bulb.SetPrice(15);
Console.WriteLine("Wattage is "+b2.GetWattage());
Console.WriteLine("Price is "+Bulb.GetPrice());
Console.WriteLine("Wattage is "+b1.GetWattage());
Console.WriteLine("Price is "+Bulb.GetPrice());
}
}
