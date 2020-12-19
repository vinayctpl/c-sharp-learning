class aaa
{
public void sam()
{
System.Console.WriteLine("Hello");
}
}
class bbb:aaa
{
public void tom()
{
System.Console.WriteLine("good");
}
}
class eg51psp
{
public static void Main()
{
aaa a;
a=new bbb();
a.sam();
a.tom();
}
}