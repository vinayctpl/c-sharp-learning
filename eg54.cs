class aaa
{
public void sam()
{
System.Console.WriteLine("Hello");
}
virtual public void tom()
{
}
}
class bbb:aaa
{
public override void tom()
{
System.Console.WriteLine("good");
}
}
class eg54psp
{
public static void Main()
{
aaa a;
a=new bbb();
a.sam();
a.tom();
System.Console.WriteLine("--------------");
bbb b;
b=new bbb();
b.sam();
b.tom();
}
}