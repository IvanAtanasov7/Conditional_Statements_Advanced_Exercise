using System;

namespace _08._On_Time_for_the_Exam
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int hourExam = int.Parse(Console.ReadLine());
			int minuteExam = int.Parse(Console.ReadLine());
			int hourArrive = int.Parse(Console.ReadLine());
			int minuteArrive = int.Parse(Console.ReadLine());

			int examTime = (hourExam * 60) + minuteExam;
			int arriveTime = (hourArrive * 60) + minuteArrive;
			int difference = 0;

			if (arriveTime > examTime)
			{
				difference = arriveTime - examTime;
				if (difference > 0 && difference < 60)
				{
					Console.WriteLine("Late");
					Console.WriteLine($"{difference} minutes after the start");
				}
				else
				{
					int hour = difference / 60;
					int minutes = difference % 60;
					Console.WriteLine("Late");
					Console.WriteLine($"{hour}:{minutes:00} hours after the start");
				}
			}
			else if (examTime - arriveTime >= 0 && examTime - arriveTime <= 30)
			{
				difference = examTime - arriveTime;
				if (difference == 0)
				{
					Console.WriteLine("On time");
				}
				else
				{
					Console.WriteLine("On time");
					Console.WriteLine($"{difference} minutes before the start");
				}
			}
			else
			{
				difference = examTime - arriveTime;
				if (difference > 30 && difference < 60)
				{
					Console.WriteLine("Early");
					Console.WriteLine($"{difference} minutes before the start");
				}
				else
				{
					int hour = difference / 60;
					int minutes = difference % 60;
					Console.WriteLine("Early");
					Console.WriteLine($"{hour}:{minutes:00} hours before the start");
				}
			}
		}
	}
}
