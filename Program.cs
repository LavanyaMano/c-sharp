using System;

namespace csharp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			// methods (static and instance).

			MainClass.EvenNumbers(50); //direct access

			MainClass M = new MainClass(); // instance is created

			int sum = M.AddNumbers(10, 30);

			Console.WriteLine("Sum is {0}", sum);

		}
		/// <summary>
		/// This is a static method.
		/// This doesn't return anything. (thats why Void keyword is used.)
		/// It is public and static method, so instance of class need not to be created.
		/// </summary>
		/// <param name="endNumber">End number.</param>
		public static void EvenNumbers(int endNumber)
		{
			int startNumber = 0;

			while (startNumber <= endNumber)
			{
				Console.WriteLine(startNumber);
				startNumber += 2;

			}
		}

		/// <summary>
		/// Adds the numbers.
		/// This is not a static method. Hence to access this instance of the class has to be created.
		/// It returns int type value.
		/// </summary>
		/// <returns>The numbers.</returns>
		/// <param name="firstNumber">First number.</param>
		/// <param name="secondNumber">Second number.</param>
		public int AddNumbers(int firstNumber, int secondNumber)
		{
			return firstNumber + secondNumber;
		}
	}
}
