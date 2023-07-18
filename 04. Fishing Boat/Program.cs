using System;

namespace _04._Fishing_Boat
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int budget = int.Parse(Console.ReadLine());
			string season = Console.ReadLine();
			int countFishermen = int.Parse(Console.ReadLine());

			double price = 0;

			switch (season)
			{
				case "Spring":
					price = 3000; break;
				case "Summer":
				case "Autumn":
					price = 4200; break;
				case "Winter":
					price = 2600; break;
			}

			if (countFishermen <= 6)
			{
				price = price - price * 0.1;
			}
			else if (countFishermen >= 7 && countFishermen <= 11)
			{
				price = price - price * 0.15;
			}
			else if (countFishermen > 12)
			{
				price = price - price * 0.25;
			}

			if (countFishermen % 2 == 0 && season != "Autumn")
			{
				price = price - price * 0.05;
			}

			if (budget >= price)
			{
				double leftMoney = budget - price;
				Console.WriteLine($"Yes! You have {leftMoney:F2} leva left.");
			}
			else if (budget < price)
			{
				double needMoney = price - budget;
				Console.WriteLine($"Not enough money! You need {needMoney:F2} leva.");
			}
		}
	}
}
