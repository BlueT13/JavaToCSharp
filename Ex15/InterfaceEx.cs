using System;

namespace Ex15
{
	interface PhoneInterface
	{
		const int TIMEOUT = 1000;
		void SendCall();
		void ReceiveCall();
		void PrintLogo();
	}

	class SamsungPhone : PhoneInterface
	{
		public void SendCall()
		{
			Console.WriteLine("Ring-ring-ring");
		}

		public void ReceiveCall()
		{
			Console.WriteLine("You got a call");
		}

		public void PrintLogo()
		{
			Console.WriteLine("** Phone **");
		}

		public void Flash()
		{
			Console.WriteLine("Light is on");
		}
	}

	internal class InterfaceEx
	{
		public static void InterfaceExMainMethod()
		{
			SamsungPhone phone = new SamsungPhone();
			phone.PrintLogo();
			phone.SendCall();
			phone.ReceiveCall();
			phone.Flash();
		}
	}
}
