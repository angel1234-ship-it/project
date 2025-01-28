using System;

class mark
{
	int M1,M2,M3;
	double Percentage;
	string Name,Department,Grade;
	public int Rollno,Total=0;
	
	public void inputrecord()
	{
	Console.WriteLine("Enter the Roll Number: ");
	Rollno=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter the name: ");
	Name=Convert.ToString(Console.ReadLine());
	Console.WriteLine("Enter the department: ");
	Department=Convert.ToString(Console.ReadLine());
	Console.WriteLine("Enter the 1st mark: ");
	M1=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter the 2nd mark: ");
	M2=Convert.ToInt32(Console.ReadLine());
	Console.WriteLine("Enter the 3rd mark: ");
	M3=Convert.ToInt32(Console.ReadLine());
	}
	public void calculateresult()
	{
		Total=M1+M2+M3;
		Percentage=(Total*100/300);
		if(Percentage >=90)
			{
				Grade="A+";
			}
		else if(Percentage >=80)
			{
				Grade="A";
			}
		else if(Percentage >=70)
			{
				Grade="B+";
			}
		else if(Percentage >=60)
			{
				Grade="B";
			}
		else if(Percentage >=50)
			{
				Grade="C+";
			}			
		else
			{
				Grade="D";
			}
	}
	public void display()
	{
		Console.WriteLine(Rollno+"\t"+Name+"\t"+M1+"\t"+M2+"\t"+M3+"\t"+Total+"\t"+Percentage+"\t"+"\t"+Grade);
	}
}
class colleges
{
	public static void Main(string [] args)
		{	
			int n,i,element,flag=0,j;

			Console.WriteLine("Enter no.of students: ");
			n=Convert.ToInt32(Console.ReadLine());

			mark[] obj=new mark[n];
			mark temp=new mark();

			Console.WriteLine("Enter the details");

			for(i=0;i<n;i++)
			{
				obj[i]=new mark();
				obj[i].inputrecord();
				obj[i].calculateresult();
			}

			Console.WriteLine("Roll no\tName\tm1\tm2\tm3\tTotal\tPercentage\tGrade");
			for(i=0;i<n;i++)
			{
				obj[i].display();
			}

			Console.WriteLine("Enter the searching Roll Number: ");
			element=Convert.ToInt32(Console.ReadLine());

			for(i=0;i<n;i++)
			{
				if(obj[i].Rollno==element)
					{
						obj[i].display();
						flag=1;
					}
			}

			if(flag==0)
				{
					Console.WriteLine("There is no record!!!");
				}
			
			for(i=0;i<n;i++)	
			{
				for(j=i+1;j<n;j++)
				{
					if(obj[i].Total<obj[j].Total)
					{
						temp=obj[i];
						obj[i]=obj[j];
						obj[j]=temp;
					}
				}
			}

			Console.WriteLine("RankList");
			Console.WriteLine("Roll no\tName\tm1\tm2\tm3\tTotal\tPercentage\tGrade");
			for(i=0;i<n;i++)
			{
				obj[i].display();
			}
			
	
		}
}
			