using System;

namespace _07._Hotel_Room
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string month = Console.ReadLine();
			int overnightStay = int.Parse(Console.ReadLine());
			double pricePerNightStudio = 0;
			double pricePerNightApartment = 0;

			if (month == "May" || month == "October")
			{
				pricePerNightStudio = 50;
				pricePerNightApartment = 65;
			}
			else if (month == "June" || month == "September")
			{
				pricePerNightStudio = 75.20;
				pricePerNightApartment = 68.70;
			}
			else if (month == "July" || month == "August")
			{
				pricePerNightStudio = 76;
				pricePerNightApartment = 77;
			}

			double totalPriceStudio = overnightStay * pricePerNightStudio;
			double totalPriceApartment = overnightStay * pricePerNightApartment;

			if (overnightStay > 14 && (month == "May" || month == "October"))
			{
				totalPriceStudio = totalPriceStudio - totalPriceStudio * 0.3;
			}
			else if (overnightStay > 7 && (month == "May" || month == "October"))
			{
				totalPriceStudio = totalPriceStudio - totalPriceStudio * 0.05;
			}
			else if (overnightStay > 14 && (month == "June" || month == "September"))
			{
				totalPriceStudio = totalPriceStudio - totalPriceStudio * 0.2;
			}

			if (overnightStay > 14)
			{
				totalPriceApartment = totalPriceApartment - totalPriceApartment * 0.1;
			}

			Console.WriteLine($"Apartment: {totalPriceApartment:F2} lv.");
			Console.WriteLine($"Studio: {totalPriceStudio:F2} lv.");
		}
	}
}
