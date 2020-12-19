abstract class Animal
{
	public virtual int getAge()
	{
		return 10;
	}
}
class Donkey:Animal
{
	public override int getAge()
	{
		return 15;
	}
}
class Monkey:Animal
{
	public int getage()
	{
		return 20;
	}
}
class Tommy
{
	public int getAge()
	{
		return 50;
	}
}
class Lion
{
	public void eat(Animal a)
	{
		int x;
		x=a.getAge();
		System.Console.WriteLine(x);
	}
}
class Zoo
{
	public static Lion sherKhan=new Lion();
}
class eg66psp
{
	public static void Main()
	{
		Donkey d=new Donkey();
		Monkey m=new Monkey();
		Tommy t=new Tommy();
		Zoo.sherKhan.eat(d);
		Zoo.sherKhan.eat(m);
		// Zoo.sherKhan.eat(t);
	}
}