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
			this.day = CheckDay(day);
			this.month = CheckMonth(month);
			this.year = year;
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
			if (month == 2 && testDay == 29 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)))
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
	}
	internal class DateTest
	{
		public static void PrintDateTest()
		{
			Date date1 = new Date(3, 1, 2018);
			Date date2 = new Date(2, 28, 2022);

			Console.WriteLine("Entrace date: " + date1.ToString());
			Console.WriteLine("Graduation date: " + date2.ToString());
		}
	}
}
