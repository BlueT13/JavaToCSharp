using System;

namespace Ex11
{
	internal class ArrayParameterEx
	{
		static void ReplaceSpace(char[] a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				if (a[i] == ' ')
				{
					a[i] = ',';
				}
			}
		}

		static void PrintCharArray(char[] a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write(a[i]);
			}
			Console.WriteLine();
		}

		public static void ArrayParameterExMainMethod()
		{
			char[] c = { 'T', 'h', 'i', 's', ' ', 'i', 's', ' ', 'a', ' ', 'p', 'e', 'n', 'c', 'i', 'l', '.' };
			PrintCharArray(c);
			ReplaceSpace(c);
			PrintCharArray(c);
		}
	}
}
