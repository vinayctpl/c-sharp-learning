using System;
class Rectangle
{
private int length;
private int breadth;
public void SetLength(int length)
{
this.length=length;
}
public void SetBreadth(int breadth)
{
this.breadth=breadth;
}
public int GetBreadth()
{
return breadth;
}
public int GetLength()
{
return length;
}
}
class Box:Rectangle
{
private int height;
public void SetHeight(int height)
{
this.height=height;
}
public int GetHeight()
{
return height;
}
}
class eg4psp
{
public static void Main()
{
Box x=new Box();
x.SetLength(10);
x.SetBreadth(3);
x.SetHeight(4);
Console.WriteLine("Length :"+x.GetLength());
Console.WriteLine("Breadth :"+x.GetBreadth());
Console.WriteLine("Height :"+x.GetHeight());
}}
