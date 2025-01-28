using System;
class fact {
	public static void Main(string [] args){
		int i,fact=1,sum=0,digit=0,num,temp;
		Console.WriteLine("enter a number:");
		num=Convert.ToInt32(Console.ReadLine());
		temp=num;
			while(num >0)
				{
					
					digit=num%10;
					fact=1;
					for(i=digit;i>0;--i)
						{
							fact=fact*i;
						}
					sum=sum+fact;
					num=num/10;
				}
	if(temp==sum)
		{
			Console.WriteLine("the number is strong");
		}
	else
		{
			Console.WriteLine("the number is not strong");

		}
}
}


					

