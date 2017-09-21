using System;

namespace BooleanType
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			bool b1 = false;
			Console.WriteLine(b1);
			b1 = true;
			Console.WriteLine(b1);
			int a = 1;
			bool b2 = (a == 1);
			Console.WriteLine(b2);
			Console.Read();
        }
    }
}
