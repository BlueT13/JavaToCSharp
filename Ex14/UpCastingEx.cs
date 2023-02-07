using System;

namespace Ex14
{
	class Person
	{
		public string name;
		public string id;

		public Person(string name)
		{
			this.name = name;
		}
	}

	class Student : Person
	{
		public string grade;
		public string department;

		public Student(string name) : base(name) { }
	}

	internal class UpCastingEx
	{
		public static void PrintUpCastingEx()
		{
			Person p;
			Student s = new Student("James");
			p = s;

			Console.WriteLine(p.name);
			//p.grade = "A";		//error
			//p.department = "SW";	//error
		}
	}
}
