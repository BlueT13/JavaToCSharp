using System;
using System.Threading.Tasks.Sources;

namespace Ex09
{
	internal class Ex09_2
	{
		public void Ex09_2_Score()
		{
			int[] scores = new int[50];
			double sum = 0;
			Console.Write("scores[]: ");
			for (int i = 0; i < scores.Length; i++)
			{
				Random random = new Random();
				scores[i] = random.Next(101);
				sum += scores[i];
				Console.Write("{0} ", scores[i]);
			}
			Console.WriteLine();
			Console.Write("Average: {0:N2}\n", sum / scores.Length);

			const int SCORE_RANGE_LENGTH = 100 / 10 + 1;
			int[] count = new int[SCORE_RANGE_LENGTH];

			for (int i = 0; i < scores.Length; i++)
			{
				switch (scores[i])
				{
					case 100:
						count[0]++;
						break;
					case >= 90:
						count[1]++;
						break;
					case >= 80:
						count[2]++;
						break;
					case >= 70:
						count[3]++;
						break;
					case >= 60:
						count[4]++;
						break;
					case >= 50:
						count[5]++;
						break;
					case >= 40:
						count[6]++;
						break;
					case >= 30:
						count[7]++;
						break;
					case >= 20:
						count[8]++;
						break;
					case >= 10:
						count[9]++;
						break;
					default:
						count[10]++;
						break;
				}
			}

			string[] scoreRange = {"100", "99-90", "89-80", "79-70", "69-60", "59-50",
				"49-40", "39-30", "29-20","19-10","09-00"};
			for (int i = 0; i < scoreRange.Length; i++)
			{
				Console.Write("{0,5}: {1} ", scoreRange[i], count[i]);
				for (int j = 0; j < count[i]; j++)
				{
					Console.Write("*");
				}
				Console.WriteLine();
			}
		}
	}
}
