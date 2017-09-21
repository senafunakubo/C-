using System;

namespace DecimalTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // m, M, C, E, f の意味調べる

            decimal myValue = 300.07m;
            Console.WriteLine("myValue = {0}", myValue);

            decimal myValue2 = 9.1m;
            int y = 3;
            Console.WriteLine(myValue2 + y); //Result will be converted to decimal
			
            //formatted output
			//formatted into currency format string
			decimal x = 0.999m;
			decimal z = 99999999m;
            Console.WriteLine("My x = {0:C}", x);
            Console.WriteLine("My z = {0:C}", z);

            //double
            //Add D/d only if you want integer to be treated as 
            //double otherwise its ok
            double d1 = 2D;
            Console.WriteLine("value for double = {0}",d1);
            double d2 = 1.76E+10;
            Console.WriteLine("value for double = {0}",d2);

            //float
            float pi = 3.1415926535897932f;
            Console.WriteLine("value for pi = {0}", pi);

            //Example for comparison abnormalities
            double a = 1.0f;
            double b = 0.33f;
            double sum = 1.33f;
            bool equal = (a + b == sum); // true?
            Console.WriteLine("Float calculation = a+b={0} " + 
                              "sum ={1} equal ={2} ",a+b,sum,equal);

            //Example for decimal comparison
            decimal aDecimal = 1.0M;
            decimal bDecimal = 0.33M;
            decimal sumDecimal = 1.33M;
            bool equalDecimal = (aDecimal + bDecimal == sumDecimal); // true?
            Console.WriteLine("Decimal calculation = a+b={0} " +
                              "sum={1} equal ={2} ",
                              aDecimal + bDecimal, sumDecimal, equalDecimal);

            Console.Read();

		}
    }
}
