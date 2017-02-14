using System;

namespace csharp
{
	class MainClass
	{
		public int factorial(int num)
		{
			// recursive method call

			int result;

			if (num == 1)
			{
				return 1;
			}
			else
			{
				result = factorial(num - 1) * num;
				return result;
			}
		}
		static void Main(string[] args)
		{
			MainClass m = new MainClass();

			// calling the factorial method

			Console.WriteLine("Factorial of 6 is {0}", m.factorial(6));
		}
	}

}
