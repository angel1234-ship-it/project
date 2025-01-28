using System;
class student
{
	int n,rollno,m1,m2,m3,total=0,i;
	double percentage;
	string name,grade,department;
	
	public void inputrecord()
	{
		Console.WriteLine("Enter the no.of students: ");
		n=Convert.ToInt32(Console.ReadLine());
		for(i=1;i<=n;i++)
			{
				total=0;
				Console.WriteLine("Enter roll number: ");
				rollno=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter name: ");
				name=Convert.ToString(Console.ReadLine());
				Console.WriteLine("Enter 1st mark: ");
				m1=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Entert 2nd mark: ");
				m2=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Enter 3rd mark: ");
				m3=Convert.ToInt32(Console.ReadLine());
				total=m1+m2+m3;
				percentage=(double)total*100/300;
				Console.WriteLine("the total mark of "+i+ " student is " + total);
				Console.WriteLine("Percentage is "+percentage+" %");
			}
	}
}
class students
{
	public static void Main(String [] args)
	{
		student obj=new student();
		obj.inputrecord();
	}
}