using System; //namespace --- collection of classes

class claculator
{
	public static void Main(string []args)
	{
		int a,b,c,d;

		Console.WriteLine("Enter Two Numbers ");

		a=Convert.ToInt32(Console.ReadLine());
		b=Convert.ToInt32(Console.ReadLine());

		c=a+b;
		d=a-b;

		Console.WriteLine("Sum = "+c);
		Console.WriteLine("Difference = "+d);
	}
}
		