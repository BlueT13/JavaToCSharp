using System;

namespace Ex14
{

	internal class DownCastingEx
	{
		public static void PrintDownCastingEx()
		{
			Person p = new Student("James");
			Student s;

			s = (Student) p;

			Console.WriteLine(s.name);
			s.grade = "A";
		}
	}
}
