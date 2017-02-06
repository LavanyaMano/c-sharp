using System;

namespace csharp
{
	class MainClass
	{
		public static void Main(string[] args)
		{
			float f = 123.45f;
			int i = Convert.ToInt32(f);
			int j = (int)f;

			Console.WriteLine("convert to int:f  {0}",i);
			Console.WriteLine("explicit int converter:   {0}", j);
		}
	}
}
