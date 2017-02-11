using System;

namespace csharp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			//for loop

			int[] Numbers = new int[3];

			Numbers[0] = 1;
			Numbers[1] = 2;
			Numbers[2] = 3;

			int i = 0;
			for (i = 0; i < Numbers.Length; i++) 
			{
				Console.WriteLine("printing array value in position {0} = {1}",i,Numbers[i]);
			}
		}

	}
}
