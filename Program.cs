using System;

namespace csharp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Please enter a number");
			int Usernumber = int.Parse(Console.ReadLine()); //readline gets string. So we are parsing to int

			switch (Usernumber)
			{ 
				case 10:
					Console.WriteLine("Your number is 10");
					break;
				case 20:
					Console.WriteLine("Your number is 20");
					break;
				default:
					Console.WriteLine("You have entered neither 10 nor 20.");
					break;
			}
			//also it is possible to combine the cases. 

		}

	}
}
