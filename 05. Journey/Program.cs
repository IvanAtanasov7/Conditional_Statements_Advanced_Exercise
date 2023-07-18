using System;

namespace _05._Journey
{
	internal class Program
	{
		static void Main(string[] args)
		{
			double budget = double.Parse(Console.ReadLine());
			string season = Console.ReadLine();

			string destination = "";
			string placeType = "";
			double price = 0;

			if (budget <= 100)
			{
				destination = "Bulgaria";
			}
			else if (budget <= 1000)
			{
				destination = "Balkans";
			}
			else
			{
				destination = "Europe";
			}

			if (season == "summer")
			{
				placeType = "Camp";
			}
			else if (season == "winter")
			{
				placeType = "Hotel";
			}

			if (destination == "Bulgaria")
			{
				if (season == "summer")
				{
					price = budget * 0.3;
				}
				else if (season == "winter")
				{
					price = budget * 0.7;
				}

			}
			else if (destination == "Balkans")
			{
				if (season == "summer")
				{
					price = budget * 0.4;
				}
				else if (season == "winter")
				{
					price = budget * 0.8;
				}
			}
			else
			{
				price = budget * 0.9;
				placeType = "Hotel";
			}
			Console.WriteLine($"Somewhere in {destination}");
			Console.WriteLine($"{placeType} - {price:F2}");
		}
	}
}
