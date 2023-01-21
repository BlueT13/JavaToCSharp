using System;

namespace Ex11
{
	internal class ArrayPassing
	{
		public static void PrintArray()
		{
			int[] a = { 1, 2, 3, 4, 5 };
			increase(a);
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write(a[i] + " ");
			}
		}

		static void increase(int[] array)
		{
			for (int i = 0; i < array.Length; i++)
			{
				array[i]++;
			}
		}
	}
}