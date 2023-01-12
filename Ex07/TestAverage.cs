using System;

namespace Ex07
{
	internal class TestAverage
	{
		public void PrintTestAverage()
		{

			int[,] score =  { { 87, 96, 70 },
							  { 68, 87, 90 },
							  { 94, 100, 90 },
							  { 100, 81, 82 },
							  { 83, 65, 85 },
							  { 78, 87, 65 },
							  { 85, 75, 83 },
							  { 91, 94, 100 },
							  { 76, 72, 84 },
							  { 87, 93, 73 } };
			double[] personAverage = new double[score.GetLength(0)];
			double[] courseAverage = new double[score.GetLength(1)];


			for (int i = 0; i < score.GetLength(0); i++)
			{
				double totalScore = 0;

				for (int j = 0; j < score.GetLength(1); j++)
				{
					totalScore += score[i, j];
				}
				personAverage[i] = totalScore / score.GetLength(1);
			}

			for (int j = 0; j < score.GetLength(1); j++)
			{
				double totalTestScore = 0;

				for (int i = 0; i < score.GetLength(0); i++)
				{
					totalTestScore += score[i, j];
				}
				courseAverage[j] = totalTestScore / (double)score.GetLength(0);
			}

			for(int i = 0; i<score.GetLength(0);i++)
			{
				for(int j = 0; j<score.GetLength(1);j++)
				{
					Console.Write("{0,3}\t", score[i, j]);
				}
				Console.Write("{0:N1}",personAverage[i]);
				Console.WriteLine();
			}
			foreach (double average in courseAverage)
			{
				Console.Write("{0:N1}\t", average);
			}
		}
	}
}