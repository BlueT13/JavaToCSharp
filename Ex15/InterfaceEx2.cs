using System;

namespace Ex15_1
{
	interface PhoneInterface
	{
		const int TIMEOUT = 1000;
		void SendCall();
		void ReceiveCall();
		void PrintLogo();
	}

	interface MobilePhoneInterface : PhoneInterface
	{
		void SendSMS();
		void ReceiveSMS();
	}

	interface MP3Interface
	{
		void Play();
		void Stop();
	}

	class PDA
	{
		public int Calculate(int x, int y)
		{
			return x + y;
		}
	}

	class SmartPhone : PDA, MobilePhoneInterface, MP3Interface
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

		public void SendSMS()
		{
			Console.WriteLine("Sending a text");
		}

		public void ReceiveSMS()
		{
			Console.WriteLine("You got a text");
		}

		public void Play()
		{
			Console.WriteLine("Playing music");
		}

		public void Stop()
		{
			Console.WriteLine("Stop playing");
		}

		public void Schedule()
		{
			Console.WriteLine("Make a schedule");
		}
	}

	internal class InterfaceEx2
	{
		public static void InterfaceEx2_MainMethod()
		{
			SmartPhone phone = new SmartPhone();
			phone.PrintLogo();
			phone.SendCall();
			phone.Play();
			Console.WriteLine("3 + 5 = " + phone.Calculate(3, 5));
			phone.Schedule();

			Console.WriteLine("--------------");
			Console.WriteLine("같은 인터페이스 자료형으로 다른 객체들의 동일한 메소드 호출 가능");

			MP3Interface iphone = new SmartPhone();
			iphone.Play();
			Console.WriteLine();

			MP3Interface[] mP3Interfaces = { iphone, phone };
			foreach (MP3Interface a in mP3Interfaces)
			{
				a.Play();
			}
		}
	}
}
