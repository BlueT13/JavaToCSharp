using System;

namespace Ex10
{
	internal class AlarmTime
	{
		private int hour;
		private int minute;
		private DayOfWeek day;
		private bool active = false;

		public AlarmTime(int hour, int minute, DayOfWeek day) : this(hour, minute, day, false) { }

		public AlarmTime(int hour, int minute, DayOfWeek day, bool active)
		{
			this.hour = hour;
			this.minute = minute;
			this.day = day;
			this.active = active;
		}

		public bool IsActive()
		{
			string activeCheck = Console.ReadLine();
			if (activeCheck == "활성화")
			{
				Console.WriteLine("알람이 활성화됐습니다.");
				active = true;
			}
			else if (activeCheck == "비활성화")
			{
				Console.WriteLine("알람이 비활성화됐습니다.");
				active = false;
			}
			else
			{
				Console.WriteLine("틀린 명령어입니다. \"활성화\" 또는 \"비활성화\"를 입력하시오.");
			}
			return active;
		}

		public int GetHour()
		{
			return hour;
		}

		public int GetMinute()
		{
			return minute;
		}

		public void SetHour(int hour)
		{
			this.hour = hour;
		}

		public void SetMinute(int minute)
		{
			this.minute = minute;
		}

		public void PrintAlarmTime()
		{
			Console.WriteLine("{0} {1}시 {2}분\t활성화 상태: {3}", day, hour, minute, active);
		}
	}
}
