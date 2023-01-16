using System;

namespace Ex09
{
	internal class Ex09_1
	{
		public void PrintEx09_1()
		{
			int[] dice = new int[6000];
			int[] count = new int[6];
			Random random = new Random();
			for(int i =0; i < 6000; i++)
			{
				dice[i] = 1 + random.Next(6);
				switch(dice[i])
				{
					case 1:
						count[0]++;
						break;
					case 2:
						count[1]++;
						break;
					case 3:
						count[2]++;
						break;
					case 4:
						count[3]++;
						break;
					case 5:
						count[4]++;
						break;
					case 6:
						count[5]++;
						break;
				}
			}
			int[] numbers = new int[6] { 1, 2, 3, 4, 5, 6 };
			for(int i = 0; i<6; i++)
			{
				Console.WriteLine(numbers[i]+": " + count[i]);
			}
		}
	}
}
