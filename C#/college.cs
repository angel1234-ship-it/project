using System;
class mark {

	int rollno,m1,m2,m3,total=0,percentage;
	string name,dept,grade;
		public void inputrecord()
			{
				Console.WriteLine("enter rollno:");
				rollno=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("enter the name:");
				name=Convert.ToString(Console.ReadLine());
				Console.Write("enter the department:");
				dept=Convert.ToString(Console.ReadLine());
				Console.WriteLine("enter mark 1:");
				m1=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("enter mark 2:");
				m2=Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("enter mark 3:");
				m3=Convert.ToInt32(Console.ReadLine());
			}
		public void calculaterecord()
			{
				total=m1+m2+m3;
				percentage=total*100/300;
				if(percentage>=90)
				{
					grade="A+";
				}
				else
				{
					grade="D";
				}
			}
		public  void displayRecord()
			{
				Console.WriteLine("total mark:"+total);
				Console.WriteLine(" percentage:"+percentage);
				Console.WriteLine(" grade:"+grade);
				
			}
		}
class college{
public static void Main(string [] args)
	{
		mark obj=new mark();
		obj.inputrecord();
		obj.calculaterecord();
		obj.displayRecord();
	}
	}
			

			
		

