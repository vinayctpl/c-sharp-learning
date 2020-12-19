using System;
class aaa
{
public void sam(int e)
{
Console.WriteLine(e);
}
public void sam(char e)
{
Console.WriteLine(e);
}
}
namespace Ujjain
{
class bbb
{
public static aaa a=new aaa();
public static void sam(int e)
{
a.sam(e);
}
public static void sam(char e)
{
a.sam(e);
}
}
}
class eg22psp
{
public static void Main()
{
Ujjain.bbb.a.sam(10);
Ujjain.bbb.a.sam('A');
Console.Out.WriteLine(10);
Console.Out.WriteLine('A');
Console.WriteLine(10);
Console.WriteLine('A');
Ujjain.bbb.sam(10);
Ujjain.bbb.sam('A');
}
}