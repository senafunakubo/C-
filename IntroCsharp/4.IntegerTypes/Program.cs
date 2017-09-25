using System;

namespace IntegerTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            byte centuries = 20; //small numbers
            uint year = 2017;
            uint day = 730480;
            ulong hours = 17531520; // a very big number
            Console.WriteLine("{0} centiroes {1} year or {2} " +
               "days or {3} hours", centuries, year, day, hours);

            //string type
            string fname = "Sena";
            string lname = "Funakubo";
            string fullname = fname + lname;
            Console.WriteLine("fname = {0}, lname = {1} and fullname="
                              + "{2} ", fname, lname, fullname);

            //for equality (== and !=)
            string a = "hello";
            string b = "h";
            b += "ello"; //b = hello
            Console.WriteLine(a == b);
            Console.WriteLine((object)a == (object)b); //false , unboxing
                                                       //content of strings literals are same but
                                                       //a & b do not refer to same string instance
                                                       //displaying a path
            //creating a verbatim string
            string path = @"c:\Docs\Source\a.txt";
            Console.WriteLine("path is = {0}", path);

            //Object type
            object o1;
            o1 = 1.0f; //boxing
					   //When you assign a value type to object its said boxing
					   //When a variable of object is converted to value
					   //its said as unboxing
			Console.WriteLine(o1);
			Console.WriteLine(o1.GetType()); // float = single??
			Console.Read();
		}
    }
}
