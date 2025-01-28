using System;
class bank{
	int Opbalance=0,Deposit,With;
	string Name,Actype;
	public int Accno;
	public void OpenAccount()
		{
		Console.WriteLine("Enter the Account no:");
		Accno=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter the Name:");
		Name=Convert.ToString(Console.ReadLine());
		Console.WriteLine("Enter the Account type:");
		Actype=Convert.ToString(Console.ReadLine());
		Console.WriteLine("Enter the Opening balance:");
		Opbalance=Convert.ToInt32(Console.ReadLine());
		} 
	public void DepositAmount()
		{	
		Console.WriteLine("Enter the Amount To Deposit:");
		Deposit=Convert.ToInt32(Console.ReadLine());
		Opbalance=Opbalance+Deposit;
		}
	public void WithdrawAmount()
		{
		Console.WriteLine("Enter the Amount to Withdraw:");
		With=Convert.ToInt32(Console.ReadLine());
		Opbalance=Opbalance-With;
		}
	public void Displaydetails()
		{
		Console.WriteLine("The Account Number:"+Accno);
		Console.WriteLine("Name: "+Name);
		Console.WriteLine("The Account Type:"+Actype);
		Console.WriteLine("The Opening Balance:"+Opbalance);
		}
}
class Account
	{
	public static void Main(string [] args)
		{
			int choice=0,i,n,element,flag=0;
			Console.WriteLine("Enter the Number of Accounts To create:");
			n=Convert.ToInt32(Console.ReadLine());
			bank[] obj=new bank[n];
			for(i=0;i<n;i++)
			{
			obj[i]=new bank();
			obj[i].OpenAccount();
			}
 			Console.WriteLine("The Account Details are:");
			for(i=0;i<n;i++)
			{
				obj[i].Displaydetails();
			}
			Console.WriteLine(" Enter Account Number:");
			element=Convert.ToInt32(Console.ReadLine());
			for(i=0;i<n;i++)
			{
			if(obj[i].Accno==element)
                       {
			flag=1;
			Console.WriteLine("1.Deposit Amount");
			Console.WriteLine("2.Withdraw Amount");
			Console.WriteLine("3.Display");
			Console.WriteLine("4.Exit");
			while(choice!=4)
			{
			Console.WriteLine("Enter Your Choice:");
			choice=Convert.ToInt32(Console.ReadLine());
                        switch(choice)
				{
				case 1:
					
						obj[i].DepositAmount();
						break;
					
				case 2:
					
						obj[i].WithdrawAmount();
						break;
					
				case 3:
					
						obj[i].Displaydetails();
						break;
					
				case 4:
						Console.WriteLine("Exit");
						break;
		
				
				default: 
						Console.WriteLine("invalid choice Please select valid choice");
						break;
                              }
                              }
                              }
			    }
				if(flag==0)
				{
				Console.WriteLine("Account Number to Found !!!");
			
				}
			
				
}
}





AutoGenerateEditButton="True"
		
		

	
		
		


			

