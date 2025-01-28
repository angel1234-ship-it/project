using System;

class student {

	public static void Main(string [] args){

	int rollno,m1,m2,m3,total,percentage;
	string name;
	Console.WriteLine("Enter roll number:");
	rollno=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the name:");
	name=Convert.ToString(Console.ReadLine());
	Console.WriteLine("Enter mark 1:");
	m1=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter mark 2:");
	m2=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter mark 3:");
	m3=Convert.ToInt32(Console.ReadLine());
        total=m1+m2+m3;
	percentage=total*100/300;
		Console.WriteLine("the total mark:"+total);
		Console.WriteLine("percentage is:"+percentage);
	if(percentage>=80)
		{
				Console.WriteLine("grade:A");
		}
	else if(percentage>=70)
		{
				Console.WriteLine("grade:B"); 
		}
	else if(percentage>=60)
		{
				Console.WriteLine("grade:C"); 
		}

	else if(percentage>=50)
		{
				Console.WriteLine("grade:D"); 
		}
		else
		{
				Console.WriteLine("failed");
		}
	}
}
