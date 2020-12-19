class aaa
{
private readonly static int x;
aaa()
{
x=10;
}

public static void sam()
{
System.Console.WriteLine(x);
}
}
class eg42psp
{
public static void Main()
{
aaa.sam();
}
}