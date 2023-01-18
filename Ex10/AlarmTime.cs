using System;

namespace Ex10
{
	internal class AlarmTime
	{
		int hour;
		int minute;
		bool active = false;

		public AlarmTime(int hour, int minute) : this(hour, minute, false) { }

		public AlarmTime(int hour, int minute, bool active)
		{
			this.hour = hour;
			this.minute = minute;
			this.active = active;
		}

		public bool IsActive()
		{
			return true;
		}

		public int GetHour()
		{
			return hour;
		}

		public void SetHour(int hour)
		{

		}

		public int GetMinute()
		{
			return minute;
		}

		public void SetMinute(int minute)
		{

		}
	}


}
