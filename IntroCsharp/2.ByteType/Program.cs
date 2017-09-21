using System;

namespace ByteType
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            byte myValue = 255;
            byte x = 10, y = 20;

            // All of them are 'X'
            char char1 = 'X';
            char char2 = '\x0058';
            char char3 = (char)88; //cast from integer value
            char char4 = '\u0058';

            Console.WriteLine("Byte values mybyte = {0}", myValue);
            Console.WriteLine("Byte values x = {0} and y = {1} and myvalue = {2}",
                              x, y, myValue);
            Console.WriteLine("value for char1 ={0}", char1);
            Console.WriteLine("value for char2 ={0}", char2);
            Console.WriteLine("value for char3 ={0}", char3);
            Console.WriteLine("value for char4 ={0}", char4);

            char symbol = 'a';
            Console.WriteLine("the code for {0} is : {1}", symbol, (int)symbol);
            Console.Read();
        }
    }
}
