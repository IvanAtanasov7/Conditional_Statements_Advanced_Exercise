using System;

namespace _01._Cinema
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string projectionType = Console.ReadLine();
			int countOfRows = int.Parse(Console.ReadLine());
			int countOfColums = int.Parse(Console.ReadLine());

			double income = 0;

			if (projectionType == "Premiere")
			{
				income = countOfRows * countOfColums * 12;
			}
			else if (projectionType == "Normal")
			{
				income = countOfRows * countOfColums * 7.50;
			}
			else if (projectionType == "Discount")
			{
				income = countOfRows * countOfColums * 5;
			}
			Console.WriteLine($"{income:F2} leva");
		}
	}
}
