using System;
class aaa
{
public static void Sam()
{
Console.WriteLine("I have fixed Behavior");
}
public void Tom()
{
Console.WriteLine("I change my behavior");
}
}
class eg5psp
{
public static void Main()
{
aaa.Sam();
//aaa.Tom();
aaa a =new aaa();
//a.Sam();
a.Tom();
}
}