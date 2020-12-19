class aaa
{
public void sam()
{
System.Console.WriteLine("Hello");
}
public void tom()
{
System.Console.WriteLine("Good");
}
}
class bbb:aaa
{
public void sam()
{
base.sam();
System.Console.WriteLine("Great");
base.sam();
}
}
class eg28psp
{
public static void Main()
{
bbb b=new bbb();
b.sam();
}
}