using System;
class number {
	public static void Main(string [] args) 
{
	int n1,n2,s,d,choice;
	Console.WriteLine("enter first number:");
	n1=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("enter  second number:");
	n2=Convert.ToInt32(Console.ReadLine());
		s=n1+n2;
		d=n1-n2;
	Console.WriteLine("enter  your choice:");
	choice=Convert.ToInt32(Console.ReadLine());
		switch(choice)
		{
			case 1:Console.WriteLine("sum of numbers:"+s);
			break;
			case 2:Console.WriteLine("difference of numbers:"+d);
			break;
		}
}
}
	
