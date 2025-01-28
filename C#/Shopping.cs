using System;

class item
{
	string itemCode;
	string itemName;
	int itemQty;
	int itemPrice;
	int itemTotal;

	public void inputData()
	{
		Console.WriteLine("enter the item code:");
		itemCode=Convert.ToString(Console.ReadLine());
		Console.WriteLine("enter the item name:");
		itemName=Convert.ToString(Console.ReadLine());
		Console.WriteLine("enter the item quantity:");
		itemQty=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("enter the item price:");
		itemPrice=Convert.ToInt32(Console.ReadLine());
		


	}

	public void calculateTotal()
	{
	itemTotal=itemQty*itemPrice;
	
	}
	public void displayData()
	{
		Console.WriteLine("the total price of the items are:"+itemTotal);
	}
}

class shopping {
	public static void Main(string [] args) {
		item obj=new item();
		obj.inputData();
		obj.calculateTotal();
		obj.displayData();
	}
}

