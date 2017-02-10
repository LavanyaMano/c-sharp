using System;

namespace csharp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter a number");
			int Usernumber = int.Parse(Console.ReadLine()); //readline gets string. So we are parsing to int

			if (Usernumber >= 0)
			{
				Console.WriteLine("Your number is {0}", Usernumber);
			}
			else
			{
				Console.WriteLine("You have entered number less than 1");
			}

		}

	}
}
