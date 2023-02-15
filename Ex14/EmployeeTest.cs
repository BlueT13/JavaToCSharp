using System;
using System.Xml.Linq;

namespace Ex14
{
	class Employee
	{
		private string name;
		private string id;
		private static int count = 0;

		public Employee(string name, string id)
		{
			this.name = name;
			this.id = id;
			count++;
		}

		public virtual double Earnings()
		{
			return 0;
		}

		public virtual string ToString()
		{
			return name + "(" + id + ")";
		}

		public static int GetCount()
		{
			return count;
		}
	}

	class SalariedEmployee : Employee
	{
		private double monthlySalary;

		public SalariedEmployee(string name, string id, double salary) : base(name, id)
		{
			monthlySalary = salary;
		}

		public override double Earnings()
		{
			return monthlySalary;
		}

		public override string ToString()
		{
			return base.ToString() + "\n" +
				"monthly salary: " + String.Format("{0:0.0}", monthlySalary);
		}
	}

	class HourlyEmployee : Employee
	{
		private double wage;
		private double hours;

		public HourlyEmployee(string name, string id, double wage, double hours) : base(name, id)
		{
			this.wage = wage;
			this.hours = hours;
		}

		public override double Earnings()
		{
			return wage * hours;
		}

		public override string ToString()
		{
			return base.ToString() + "\n" +
				"wage: " + String.Format("{0:0.0}", wage) + "\n" +
				"hours: " + String.Format("{0:0.0}", hours);
		}
	}

	class CommissionEmployee : Employee
	{
		private double grossSales;
		private double commissionRate;

		public CommissionEmployee(string name, string id, double sales, double rate) : base(name, id)
		{
			grossSales = sales;
			commissionRate = rate;
		}

		public override double Earnings()
		{
			return grossSales * commissionRate;
		}

		public override string ToString()
		{
			return base.ToString() + "\n" +
				"gross sales: " + String.Format("{0:0.0}", grossSales) + "\n" +
				"commission rate: " + String.Format("{0:0.##}", commissionRate);
		}
	}

	class BasePlusCommissionEmployee : CommissionEmployee
	{
		private double baseSalary;

		public BasePlusCommissionEmployee(string name, string id, double sales, double rate, double salary) : base(name, id, sales, rate)
		{
			baseSalary = salary;
		}
		public override double Earnings()
		{
			return base.Earnings() + baseSalary;
		}

		public override string ToString()
		{
			return base.ToString() + "\n" +
				"base salary: " + String.Format("{0:0.0}", baseSalary);
		}
	}

	internal class EmployeeTest
	{
		public static void EmployeeTestMainMethod()
		{
			Employee[] arr = new Employee[4];
			arr[0] = new SalariedEmployee("Smith", "s1111", 300);
			arr[1] = new HourlyEmployee("Karen", "h2222", 1, 160);
			arr[2] = new CommissionEmployee("Jones", "c3333", 2000, 0.1);
			arr[3] = new BasePlusCommissionEmployee("Lewis", "b4444", 2000, 0.06, 100);

			double sum = 0.0;
			foreach (Employee e in arr)
			{
				Console.WriteLine(e.ToString());
				Console.WriteLine("payment: " + String.Format("{0:0.0}", e.Earnings()));
				Console.WriteLine();
				sum += e.Earnings();
			}
			Console.WriteLine("Total employees: " + Employee.GetCount());
			Console.WriteLine("Total payment: " + String.Format("{0:0.0}", sum));
		}
	}
}
