// Program gets a quantity ordered from user
// then determines price and discount based on quantity
// price per item before discounts is $6.00
// order 15 or more, get a 20% discount
// order 10 to 14 - get a 14% discount
// order 5 to 9, get a 10% discount
using System;
using static System.Console;
using System.Globalization;
class DebugSeven3
{
	static void Main()
	{
		int quantity;
		double price;
		quantity = GetQuantity();
		price = CalculatePrice(quantity);
		WriteLine("{0}", price.ToString("c", CultureInfo.GetCultureInfo("en-US")));
	}
	private static int GetQuantity()
	{
		int quan;
		Write("Enter number of items >> ");
		quan = Convert.ToInt32(ReadLine());
		return quan;
	}
	private static double CalculatePrice(int quantityOrdered)
	{
		double PRICE_PER_ITEM = 6.00;
		double price = 0;
		double discount = 0;
		int[] quanLimits = { 0, 5, 10, 15 };
		double[] limits = { 0, 0.10, 0.14, 0.20 };
		for (int x = limits.Length - 1; x >= 0; --x)
		{
			if (quantityOrdered >= limits[x])
				discount = limits[x];
			x = 0;
		}
		price = quantityOrdered * PRICE_PER_ITEM;
		price = price - price * discount;
		return price;
	}
}
