using System;

namespace _4
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

            //bitwise operator
            ushort a1 = 3; //               00000000 00000011 = 3
            ushort b1 = 5; //               00000000 00000101 = 5
            Console.WriteLine(a1 | b1); //  00000000 00000111 = 7
            Console.WriteLine("left shift operation");
            Console.WriteLine(a1 << 2); //  00000000 00001100 左から2削り、右に0を減ったぶん足す
            Console.WriteLine("right shift operation");
            Console.WriteLine(a1 >> 2); //  00000000 00000000 右から
			Console.Read();
        }
    }
}
