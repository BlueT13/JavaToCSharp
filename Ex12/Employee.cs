using System;

namespace Ex12
{
	internal class Employee
	{
		private string name;
		private static int count = 0;

		public Employee(string name)
		{
			this.name = name;
			++count;
		}

		public string ToString()
		{
			return "Employee: " + name;
		}

		public static int GetCount()
		{
			return count;
		}
	}
}
