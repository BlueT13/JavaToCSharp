using System;

namespace Ex13
{
	class Person
	{
		private int weight;
		int age;
		protected int height;
		public string name;

		public void SetWeight(int weight)
		{
			this.weight = weight;
		}

		public int GetWeight()
		{
			return weight;
		}
	}

	class Student : Person
	{
		public void Set()
		{
			//age = 30; //기본 접근지정자는 private
			name = "James";
			height = 175;
			//weight = 99; //private은 해당 클래스에서만 접근이 가능
			SetWeight(100);
		}
	}

	internal class InheritanceEx
	{

		public static void PrintStudentInfo()
		{
			Student s = new Student();
			s.Set();

			//Console.WriteLine(s.age); //private은 해당 클래스에서만 접근이 가능
			Console.WriteLine(s.name);
			//Console.WriteLine(s.height); //protected는 상속받은 자식의 클래스에서만 사용 가능
			int weight = s.GetWeight();
			Console.WriteLine(weight);
		}
	}
}
