using System;

namespace Ex09
{
	internal class Ex09_1
	{
		public void Ex09_1_Dice()
		{
			int[] count = new int[6];
			Random random = new Random();
			for (int i = 0; i < 6000; i++)
			{
				int dice_number = 1 + random.Next(6);
				switch (dice_number)
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

			for (int i = 0; i < 6; i++)
			{
				Console.WriteLine((i + 1) + ": " + count[i]);
			}
		}
	}
}
