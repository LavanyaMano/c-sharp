using System;

namespace csharp
{
	class MainClass
	{
		public void swap(int x, int y)
		{
			int temp;
			temp = x;
			x = y;
			y = temp;
		}
		public void swapRef(ref int x, ref int y)
		{
			int temp;
			temp = x;
			x = y;
			y = temp;

		}

		public void getValue(out int x)
		{
			int temp = 5;
			x = temp;
		}
		static void Main(string[] args)
		{
			MainClass m = new MainClass();

			int a = 10;
			int b = 20;
			int c = 30;
			int d = 40;

			Console.WriteLine("Before swaping, value of a : {0}", a);
			Console.WriteLine("Before swaping, value of b : {0}", b);
			Console.WriteLine("Before swaping, value of c : {0}", c);
			Console.WriteLine("Before swaping, value of d : {0}", d);
			// Passing parameters by value (copies the value of an arg)

			m.swap(a, b);

			// Reference Parameters(copies the reference to the memory location of an arg)

			m.swapRef(ref c, ref d);

			Console.WriteLine("After swaping, value of a : {0}", a);
			Console.WriteLine("After swaping, value of b : {0}", b);
			Console.WriteLine("After swaping, value of c : {0}", c);
			Console.WriteLine("After swaping, value of d : {0}", d);

			//output parameter

			m.getValue(out a);

			Console.WriteLine("After getvalue method call, value of a is {0}", a);
		}
	}

}
