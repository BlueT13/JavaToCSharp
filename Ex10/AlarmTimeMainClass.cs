using System;

namespace Ex10
{
	internal class AlarmTimeMainClass
	{
		public static void AlarmTimeMain()
		{
			AlarmTime[] alarmTimes = new AlarmTime[10];
			while (true)
			{
				Console.WriteLine("1.알람출력 2.알람설정 3.알람활성화 4.종료");
				int menuIndex = Convert.ToInt32(Console.ReadLine());
				if (menuIndex == 1)
				{
					for (int i = 0; i < alarmTimes.Length; i++)
					{
						if (alarmTimes[i] != null)
						{
							Console.Write("{0,2}. ", (i + 1));
							alarmTimes[i].PrintAlarmTime();
						}
						else
						{
							Console.WriteLine("{0,2}. 미설정", (i + 1));
						}
					}
					Console.WriteLine();
				}
				else if (menuIndex == 2)
				{
					Console.Write("설정할 알람번호를 입력하시오: ");
					int alarmNum = Convert.ToInt32(Console.ReadLine());

					Console.Write("시간을 입력하시오(ex:23): ");
					int hour = Convert.ToInt32(Console.ReadLine());

					Console.Write("분을 입력하시오(ex:59): ");
					int minute = Convert.ToInt32(Console.ReadLine());

					Console.WriteLine("요일을 입력하시요(ex:6): ");
					Console.WriteLine("일요일:0, 월요일:1, 화요일:2, 수요일:3, 목요일:4, 금요일:5, 토요일:6");
					DayOfWeek day = (DayOfWeek)Convert.ToInt32(Console.ReadLine());

					alarmTimes[alarmNum - 1] = new AlarmTime(hour, minute, day);
				}
				else if (menuIndex == 3)
				{
					int alarmNum;
					Console.Write("설정할 알람번호를 입력하시오: ");
					alarmNum = Convert.ToInt32(Console.ReadLine());
					alarmTimes[alarmNum - 1].IsActive();
				}
				else if (menuIndex == 4)
				{
					break;
				}
			}
		}
	}
}
