using System;

namespace CarEx1
{
	class Convertible
	{
		string color;
		int speed;

		public Convertible(string color)
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
		public void OpenRoof()
		{
			Console.WriteLine("open roof");
		}
		public void CloseRoof()
		{
			Console.WriteLine("close roof");
		}
	}

	class DumpTruck
	{
		string color;
		int speed;
		int cargoSize;

		public DumpTruck(string color, int cargoSize)
		{
			this.color = color;
			speed = 0;
			this.cargoSize = cargoSize;
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
		public void Dump()
		{
			Console.WriteLine("dump");
		}
	}

	class FreezerTruck
	{
		string color;
		int speed;
		int cargoSize;
		int temperature;

		public FreezerTruck(string color, int cargoSize, int temp)
		{
			this.color = color;
			speed = 0;
			this.cargoSize = cargoSize;
			temperature = temp;
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
		public void SetTemperature(int temp)
		{
			temperature = temp;
			Console.WriteLine($"set temperature({temperature})");
		}
	}

	internal class CarEx_NoInheritance
	{
		public static void PrintCarEx_NoInheritance()
		{
			Convertible c = new Convertible("red");
			Console.WriteLine("Convertible: ");
			c.EngineStart();
			c.SpeedUp();
			c.OpenRoof();
			c.CloseRoof();
			c.SpeedDown();
			c.EngineStop();
			Console.WriteLine();

			DumpTruck d = new DumpTruck("blue", 10);
			Console.WriteLine("Dump truck: ");
			d.EngineStart();
			d.SpeedUp();
			d.SpeedDown();
			d.Dump();
			d.EngineStop();
			Console.WriteLine();

			FreezerTruck f = new FreezerTruck("blue", 10, 0);
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
