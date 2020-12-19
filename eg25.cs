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
}
class eg25psp
{
public static void Main()
{
bbb b=new bbb();
System.Console.WriteLine(b.getX());
}
}