using System;

namespace csharp
{
	class MainClass
	{
		//Encapsulation: Enclosing one or more items within in a physical or logical package.
		//Its done using access specifiers.(Public, Private, Protected, Internal, Protected internal)


	}
	class Rectangle
	{
		//member variables public
		public double length;
		public double width;

		public double GetArea()
		{
			return length * width;
		}

		public void Display()
		{
			Console.WriteLine("Length: {0}", length);
			Console.WriteLine("Width:{0}", width);
			Console.WriteLine("Area:{0}", GetArea());
		}

		//private variables
		private double length1;
		private double width1;

		public void Acceptdetails()
		{
			Console.WriteLine("Enter length : ");
			length1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Enter width: ");
			width1 = Convert.ToDouble(Console.ReadLine());
		}

		public void Display1()
		{
			Console.WriteLine("Private variable length1 is {0}",length1);
			Console.WriteLine("Private variable width1 is {0}", width1);
		}

	}// end class Rectangle
	class ExecuteRectangle
	{
		static void Main(string[] args)
		{
			Rectangle r = new Rectangle();

			r.length = 4.5;
			r.width = 3.5;
			r.Display();
			Console.WriteLine("length1 and width1 are private. Can't call here");
			r.Acceptdetails();
			r.Display1();
		}

	}

}
