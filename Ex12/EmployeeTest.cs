using System;

namespace Ex12
{
	internal class EmployeeTest
	{
		public static void PrintEmployee()
		{
			Console.WriteLine(Employee.GetCount());
			Employee e1 = new Employee("Susan Baker");
			Employee e2 = new Employee("Bob Blue");
			Console.WriteLine(e1.ToString());
			Console.WriteLine(e2.ToString());
			Console.WriteLine(Employee.GetCount());
		}
	}
}
