using System;

namespace CarEx2
{
	class Car
	{
		private string color;
		private int speed;

		public Car(string color)
		{
			this.color = color;
			speed = 0;
		}

		public void EngineStart()
		{
			Console.WriteLine("engine start");
		}
		public void EngineStop()
		{
			Console.WriteLine("engine stop");
		}
		public void SpeedUp()
		{
			speed++;
			Console.WriteLine($"speed up({speed})");
		}
		public void SpeedDown()
		{
			if (speed > 0)
			{
				speed--;
			}
			Console.WriteLine($"speed down({speed})");
		}
	}

	class Convertible : Car
	{

		public Convertible(string color) : base(color) { }

		public void OpenRoof()
		{
			Console.WriteLine("open roof");
		}
		public void CloseRoof()
		{
			Console.WriteLine("close roof");
		}
	}

	class DumpTruck : Car
	{
		int cargoSize;

		public DumpTruck(string color, int cargoSize) : base(color)
		{
			this.cargoSize = cargoSize;
		}
		public void Dump()
		{
			Console.WriteLine("dump");
		}
	}

	class FreezerTruck : Car
	{
		private int cargoSize;
		private int temp;

		public FreezerTruck(string color, int cargoSize, int temp) : base(color)
		{
			this.cargoSize = cargoSize;
			this.temp = temp;
		}
		public void SetTemperature(int temp)
		{
			this.temp = temp;
			Console.WriteLine($"set temperature({temp})");
		}
	}

	internal class CarEx_Inheritance
	{
		public static void PrintCarEx_Inheritance()
		{
			Convertible c = new Convertible("white");
			Console.WriteLine("Convertible: ");
			c.EngineStart();
			c.SpeedUp();
			c.OpenRoof();
			c.CloseRoof();
			c.SpeedDown();
			c.EngineStop();
			Console.WriteLine();

			DumpTruck d = new DumpTruck("black", 10);
			Console.WriteLine("Dump truck: ");
			d.EngineStart();
			d.SpeedUp();
			d.SpeedDown();
			d.Dump();
			d.EngineStop();
			Console.WriteLine();

			FreezerTruck f = new FreezerTruck("purple", 10, 0);
			Console.WriteLine("Freezer truck: ");
			f.EngineStart();
			f.SetTemperature(-20);
			f.SpeedUp();
			f.SpeedDown();
			f.EngineStop();
			Console.WriteLine();
		}
	}
}
