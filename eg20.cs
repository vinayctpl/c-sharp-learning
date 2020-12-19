class aaa
{
}
class bbb
{
static private aaa a;
static private decimal b;
static private double c;
static private float d;
static private ulong e;
static private long f;
static private uint g;
static private int h;
static private ushort i;
static private short j;
static private sbyte k;
static private byte l;
static private char m;
static private bool n;
public void sam()
{
System.Console.WriteLine("----------");
System.Console.WriteLine(a);
System.Console.WriteLine(b);
System.Console.WriteLine(c);
System.Console.WriteLine(d);
System.Console.WriteLine(e);
System.Console.WriteLine(f);
System.Console.WriteLine(g);
System.Console.WriteLine(h);
System.Console.WriteLine(i);
System.Console.WriteLine(j);
System.Console.WriteLine(k);
System.Console.WriteLine(l);
System.Console.WriteLine(m);
System.Console.WriteLine(n);
System.Console.WriteLine("----------");
}
}
class eg19psp
{
public static void Main()
{
bbb b=new bbb();
b.sam();
}
}