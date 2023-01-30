using System;

namespace Ex11
{
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

	class Date
	{
		private static readonly int[] kDaysPerMonth = { 0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
		private static readonly int[] kLeapDaysPerMonth = { 0, 31, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

		private int day;
		private int month;
		private int year;

		public Date(int day, int month, int year)
		{
			if (CheckDate(day, month, year))
			{
				this.day = day;
				this.month = month;
				this.year = year;
			}
			else
			{
				this.day = -1;
				this.month = -1;
				this.year = -1;
			}
		}

		private static bool CheckDate(int day, int month, int year)
		{
			if (month < 1 || month > 12)
			{
				return false;
			}

			int[] daysPerMonth = IsLeapYear(year) ? kLeapDaysPerMonth : kDaysPerMonth;
			if (day < 1 || day > daysPerMonth[month])
			{
				return false;
			}
			return true;
		}

		private static bool IsLeapYear(int year)
		{
			return year % 400 == 0 || (year % 4 == 0 && year % 100 != 0);
		}

		public string ToString()
		{
			return month + "/" + day + "/" + year;
		}

		public void Increase()
		{
			int[] daysPerMonth = kDaysPerMonth;

			if (IsLeapYear(year))
			{
				daysPerMonth = kLeapDaysPerMonth;
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
				day = 1;
				month = 1;
				year++;
			}
		}
	}
}
