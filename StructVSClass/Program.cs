using System;

namespace StructVSClass
{
	struct Yogi
	{
		public int inx;
	}
	class MainClass
	{
		public static void Main (string[] args)
		{
			Yogi x = new Yogi ();
			Yogi y;
			x.inx = 1;
			y = x;
			y.inx = 2;
			Console.WriteLine (x.inx+"  "+y.inx);
		}
	}
}
