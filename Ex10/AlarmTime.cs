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
			return active;
		}

		public void SetActive(bool flag)
		{
			active = flag;
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
