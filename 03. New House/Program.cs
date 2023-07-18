using System;

namespace _03._New_House
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string flowerType = Console.ReadLine();
			int count = int.Parse(Console.ReadLine());
			int budget = int.Parse(Console.ReadLine());

			double price = 0;

			switch (flowerType)
			{
				case "Roses":
					price = 5; break;
				case "Dahlias":
					price = 3.80; break;
				case "Tulips":
					price = 2.80; break;
				case "Narcissus":
					price = 3; break;
				case "Gladiolus":
					price = 2.50; break;
			}

			double totalPrice = count * price;

			if (count > 80 && flowerType == "Roses")
			{
				totalPrice = totalPrice - totalPrice * 0.1;
			}
			else if (count > 90 && flowerType == "Dahlias")
			{
				totalPrice = totalPrice - totalPrice * 0.15;
			}
			else if (count > 80 && flowerType == "Tulips")
			{
				totalPrice = totalPrice - totalPrice * 0.15;
			}
			else if (count < 120 && flowerType == "Narcissus")
			{
				totalPrice = totalPrice + totalPrice * 0.15;
			}
			else if (count < 80 && flowerType == "Gladiolus")
			{
				totalPrice = totalPrice + totalPrice * 0.2;
			}

			if (budget >= totalPrice)
			{
				double leftMoney = budget - totalPrice;
				Console.WriteLine($"Hey, you have a great garden with {count} {flowerType} and {leftMoney:F2} leva left.");
			}
			else
			{
				double needMoney = totalPrice - budget;
				Console.WriteLine($"Not enough money, you need {needMoney:F2} leva more.");
			}
		}
	}
}
