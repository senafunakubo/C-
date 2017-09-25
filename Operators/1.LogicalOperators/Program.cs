using System;

namespace _1.LogicalOperators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            bool a = true;
            bool b = false;
            Console.WriteLine(a && b); //false
            Console.WriteLine(a || b); //true
            Console.WriteLine(!b); //true
            Console.Write("\n");

            //bitwise operator
            ushort a1 = 3; //              00000000 00000011 = 3
			ushort b1 = 5; //              00000000 00000101 = 5

            Console.WriteLine(a1 | b1); // 00000000 00000111 = 7

            Console.WriteLine("left shift operation");
            Console.WriteLine(a1 << 2); // 00000000 00001100 = 12
            //左から２桁消して右に２桁足す

			Console.WriteLine("Right shift operation");
			Console.WriteLine(a1 >> 2); // 00000000 00000000 = 0
            //上のやつの反対

			Console.Read();
		}
    }
}
