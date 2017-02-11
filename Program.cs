using System;

namespace csharp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// coffee shopping
			int TotalCoffee = 0;
			Console.WriteLine("Welcome to coffee shopping.");
			Start: //this is label 
			Console.WriteLine("please enter- 1 for small, 2 for medium or 3 for large cup coffee");
			int UserChoice = int.Parse(Console.ReadLine());

			switch (UserChoice)
			{
				case 1:
					TotalCoffee += 1;
					break;
				case 2:
					TotalCoffee += 2;
					break;
				case 3:
					TotalCoffee += 3;
					break;
				default:
					Console.WriteLine("Your choice {0} is invalid", UserChoice);
					break;
			}
			Reorder:
			Console.WriteLine("Do you want to order more? yes or no?");
			string options = Console.ReadLine();

			switch (options)
			{
				case "yes":
					goto Start;
				case"no":
					break;
					default:
					Console.WriteLine("Please enter a valid option");
					goto Reorder;
			}

			Console.WriteLine("Your total order is {0}",TotalCoffee);

		}

	}
}
