using System;

namespace csharp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			int[] evenNumbers = new int [3];

			evenNumbers[0] = 0;
			evenNumbers[1] = 2;
			evenNumbers[2] = 4;

			Console.WriteLine("even number array type{0}", evenNumbers);

			Console.WriteLine("first even number - {0}",evenNumbers[0]);
		}
	}
}
