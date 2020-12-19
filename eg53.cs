class aaa
{
public void sam()
{
System.Console.WriteLine("Hello");
}
public void tom()
{
}
}
class bbb:aaa
{
public new void tom()
{
System.Console.WriteLine("good");
}
}
class eg53psp
{
public static void Main()
{
aaa a;
a=new bbb();
a.sam();
a.tom();
System.Console.WriteLine("---------------");
bbb b;
b=new bbb();
b.sam();
b.tom();
}
}