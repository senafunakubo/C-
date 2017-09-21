using System;

namespace NullableType
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int? someInteger = null;
            Console.WriteLine("This is integer with Null Value {0}",
                              someInteger);
            someInteger = 5;
            Console.WriteLine("value is change to {0}", someInteger);
            Console.Read();
        }
    }
}
