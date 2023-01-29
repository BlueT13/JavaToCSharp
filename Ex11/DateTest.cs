using System;

namespace Ex11
{
	class Date
	{
		private int day;
		private int month;
		private int year;

		public Date(int month, int day, int year)
		{
			this.month = CheckMonth(month);
			this.year = year;
			this.day = CheckDay(day);
		}

		private int CheckMonth(int testMonth)
		{
			if (testMonth > 0 && testMonth <= 12)
			{
				return testMonth;
			}
			else
				return 1;
		}

		private int CheckDay(int testDay)
		{
			int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			if (testDay > 0 && testDay <= daysPerMonth[month])
			{
				return testDay;
			}
			else if (month == 2 && testDay == 29 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
			{
				return testDay;
			}
			else
				return 1;
		}

		public string ToString()
		{
			return month + "/" + day + "/" + year;
		}

		public void Increase()
		{
			int[] daysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
			if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
			{
				daysPerMonth[2] = 29;
			}
			
			if (day < daysPerMonth[month] && month < 13)
			{
				day++;
			}
			else if (day == daysPerMonth[month] && month < 12)
			{
				day = 1;
				month++;
			}
			else if (day == daysPerMonth[month] && month == 12)
			{
				year++;
				day = 1;
				month = 1;
			}
		}
	}
	internal class DateTest
	{
		public static void PrintDateTest()
		{
			Date date = new Date(1, 1, 2020);
			Console.WriteLine("Graduation date: " + date.ToString());

			for (int i = 0; i < 1827; i++)
			{
				date.Increase();
				Console.WriteLine(date.ToString());
			}
		}
	}
}
