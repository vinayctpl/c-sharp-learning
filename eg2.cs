using System;
class Calculator
{
public void Add(int e,int f,int g)
{
Console.WriteLine("Total is "+(e+f+g));
}
public void Add(int e,int f)
{
Console.WriteLine("Total is "+(e+f));
}
}
class eg3psp
{
public static void Main()
{
Calculator c=new Calculator();
c.Add(10,20);
c.Add(10,20,30);
}
}
