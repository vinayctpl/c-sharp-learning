class aaa
{
private int y;
readonly private int x;
public void sam()
{
System.Console.WriteLine(x);
}
public aaa()
{
x=20;
}
public aaa(int e)
{
y=e;
x=30;
}
}
class eg38psp
{
public static void Main()
{
aaa a=new aaa();
a.sam();
aaa b=new aaa(10);
b.sam();
}
}
