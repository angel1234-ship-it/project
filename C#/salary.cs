using System;
class employee{
		int Bsalary,TC;
		double HRA,Totalsalary;
		string Name;
		public int Id;
	public void InputData()
			{
			Console.WriteLine("Enter Employee id:");
			Id=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter Employee Name:");
			Name=Convert.ToString(Console.ReadLine());
			Console.WriteLine("Enter Basic salary:");
			Bsalary=Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter HRA:");
			HRA=Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter TC:");
			TC=Convert.ToInt32(Console.ReadLine());
			}
	public void CalculateData()
			{
			Totalsalary=Bsalary+HRA+TC;
			}
	public void DisplayData(){
			
			Console.WriteLine(" Employee id:"+Id);
			Console.WriteLine(" Employee Name:"+Name);
			Console.WriteLine(" Employee  Basic Salary:"+Bsalary);
			Console.WriteLine(" Employee HRA:"+HRA);
			Console.WriteLine(" Employee TC:"+TC);
			Console.WriteLine(" Employee Total Salary:"+Totalsalary);
			}
}
class salary{
	public static void Main(string [] args)

	{       int n,i,flag=0,element;
		Console.WriteLine("Enter Number of Employees:");
		n=Convert.ToInt32(Console.ReadLine());
		employee [] e=new employee[n];
		for(i=0;i<n;i++)
		{
		e[i]=new employee();
		e[i].InputData();
		e[i].CalculateData();
		e[i].DisplayData();
		
		}
		Console.WriteLine("The Details of employees is:");
		for(i=0;i<n;i++)
		{
		e[i].DisplayData();
		}
		Console.WriteLine("Enter the Id of the employee to search");
		element=Convert.ToInt32(Console.ReadLine());
		for(i=0;i<n;i++)
		{
		 if(e[i].Id==element)
			{
			flag=1;
			e[i].DisplayData();
			}
			}
		if(flag==0)
		{
			Console.WriteLine("Id not found !!!");
		}
		
		
	}
	}

			
			