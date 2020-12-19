class aaa
{
private int x;
public aaa(int e)
{
x=e;
}
public int getX()
{
return x;
}
}
class bbb:aaa
{
public bbb():base(10)
{
}
}
class eg26psp
{
public static void Main()
{
bbb b=new bbb();
System.Console.WriteLine(b.getX());
}
}
