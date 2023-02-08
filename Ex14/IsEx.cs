using System;

namespace Ex14_1
{

	class Person { }
	class Student : Person { }
	class Researcher : Person { }
	class Professor : Researcher { }

	internal class IsEx
	{
		static void Print(Person p) 
		{
			if(p is Person)
			{
				Console.Write("Persone ");
			}
			if(p is Student)
			{
				Console.Write("Student ");
			}
			if(p is Researcher)
			{
				Console.Write("Researcher ");
			}
			if(p is Professor)
			{
				Console.Write("Professor ");
			}
			Console.WriteLine();
		}

		public static void PrintIsEx()
		{
			Console.Write("new Student() ->\t"); Print(new Student());
			Console.Write("new Researcher ->\t"); Print(new Researcher());
			Console.Write("new Professor ->\t"); Print(new Professor());
		}
	}
}
