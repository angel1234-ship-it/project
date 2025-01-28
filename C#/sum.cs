using System;
class sum {
	public static void Main (string [] args){
		int digit=0,sum=0,rev=0,num,temp;
		Console.WriteLine("enter a number:");
		num=Convert.ToInt32(Console.ReadLine());
		temp=num;
			while(num>0)
				{
					digit=num%10;
					sum=sum+digit;
					rev=rev*10+digit;
					num=num/10;
					Console.WriteLine(digit);
				}
			if(temp==rev)
				{
					Console.WriteLine("number is palindrom");
				}
			else	
				{

				Console.WriteLine("number not palindrom");
				}
				
			Console.WriteLine("sum of number:"+sum);
			Console.WriteLine("reverse of number:"+rev);
			Console.WriteLine("reverse of number:"+count);
}
}		