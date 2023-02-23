using System;

namespace Ex15_1
{
	interface Payable
	{
		double GetPaymentAmount();
	}

	class Invoice : Payable
	{
		private string description;
		private int quantity;
		private double price;
		private static int count = 0;

		public Invoice(string description, int quantity, double price)
		{
			this.description = description;
			this.quantity = quantity;
			this.price = price;
			count++;
		}

		public double GetPaymentAmount()
		{
			return quantity * price;
		}

		public override string ToString()
		{
			return description + "\n"
				+ "quantity: " + String.Format("{0:0}", quantity) + "\n"
				+ "price: " + String.Format("{0:0,0}", price);
		}

		public static int GetCount()
		{
			return count;
		}
	}

	abstract class Employee : Payable
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

		public abstract double GetPaymentAmount();

		public override string ToString()
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

		public override double GetPaymentAmount()
		{
			return monthlySalary;
		}

		public override string ToString()
		{
			return base.ToString() + "\n" +
				"monthly salary: " + String.Format("{0:0}", monthlySalary);
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

		public override double GetPaymentAmount()
		{
			return wage * hours;
		}

		public override string ToString()
		{
			return base.ToString() + "\n"
				+ "wage: " + String.Format("{0:0}", wage) + "\n"
				+ "hours: " + String.Format("{0:0}", hours);
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

		public override double GetPaymentAmount()
		{
			return commissionRate * grossSales;
		}

		public override string ToString()
		{
			return base.ToString() + "\n"
				+ "gross sales: " + String.Format("{0:0,0}", grossSales) + "\n"
				+ "commission rate: " + String.Format("{0:0.##}", commissionRate);
		}
	}

	class BasePlusCommissionEmployee : CommissionEmployee
	{
		private double baseSalary;

		public BasePlusCommissionEmployee(string name, string id, double sales, double rate, double salary) : base(name, id, sales, rate)
		{
			baseSalary = salary;
		}

		public override double GetPaymentAmount()
		{
			return baseSalary + base.GetPaymentAmount();
		}

		public override string ToString()
		{
			return base.ToString() + "\n"
				+ "base salary: " + String.Format("{0:0}", baseSalary);
		}
	}

	internal class EmployeeTest2
	{
		public static void EmployeeTest2_MainMethod()
		{
			Payable[] arr = new Payable[6];
			arr[0] = new SalariedEmployee("Smith", "s1111", 300);
			arr[1] = new HourlyEmployee("Karen", "h2222", 1, 160);
			arr[2] = new CommissionEmployee("Jones", "c3333", 2000, 0.1);
			arr[3] = new BasePlusCommissionEmployee("Lewis", "b4444", 2000, 0.06, 100);
			arr[4] = new Invoice("seat", 2, 30000);
			arr[5] = new Invoice("tire", 4, 80000);

			double sum = 0.0;
			foreach (Payable e in arr)
			{
				Console.WriteLine(e.ToString());
				Console.WriteLine("payment: {0:0,0}", e.GetPaymentAmount());
				Console.WriteLine();
				sum += e.GetPaymentAmount();
			}
			Console.WriteLine("Total employees: {0}", Employee.GetCount());
			Console.WriteLine("Total invoices: {0}", Invoice.GetCount());
			Console.WriteLine("Total payment: {0:0,0}", sum);
		}
	}
}
