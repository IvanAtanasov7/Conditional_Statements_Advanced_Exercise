using System;

namespace _09._Ski_Trip
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int daysToStay = int.Parse(Console.ReadLine());
			string typeOfRoom = Console.ReadLine();
			string feedback = Console.ReadLine();

			double price = 0;
			int nights = daysToStay - 1;

			switch (typeOfRoom)
			{
				case "room for one person":
					price = 18.00;
					break;
				case "apartment":
					price = 25.00;
					if (daysToStay < 10)
					{
						price = price - price * 0.3;
					}
					else if (daysToStay >= 10 && daysToStay <= 15)
					{
						price = price - price * 0.35;
					}
					else
					{
						price = price - price * 0.50;
					}
					break;
				case "president apartment":
					price = 35.00;
					if (daysToStay < 10)
					{
						price = price - price * 0.10;
					}
					else if (daysToStay >= 10 && daysToStay <= 15)
					{
						price = price - price * 0.15;
					}
					else
					{
						price = price - price * 0.20;
					}
					break;
			}
			if (feedback == "positive")
			{
				price = price + price * 0.25;
			}
			else if (feedback == "negative")
			{
				price = price - price * 0.10;
			}
			double totalPrice = nights * price;
			Console.WriteLine($"{totalPrice:F2}");
		}
	}
}
