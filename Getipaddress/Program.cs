using System;

namespace Getipaddress
{
	class Program
	{
		static void Main(string[] args)
		{
			//version
			int version = 1;

			//Greeting
			Console.WriteLine($"Console application Get IP address version: {version}");
			Console.WriteLine("Get IP address hosts by domain name.");

			//input value
			Console.Write("Input domain name: ");
			string domain = Console.ReadLine();
			

			//Close window
			Console.ReadKey();
		}
	}
}
