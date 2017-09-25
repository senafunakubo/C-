using System;

namespace DecimalTypes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			// https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/formatting-numeric-results-table

            //M makes the number a decimal representation(10進数=ふつうの) in code.
			decimal myValue = 300.07m;
            Console.WriteLine("myValue = {0}", myValue);

            decimal myValue2 = 9.1m;
            int y = 3;
            Console.WriteLine(myValue2 + y); //Result will be converted to decimal
			
            //“Currency formatting”
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
            double d2 = 1.76E+10; //   ex)1.7E+3 = 1.7 x 10^3 = 1700
			Console.WriteLine("value for double = {0}",d2);

            //float
            float pi = 3.1415926535897932f;
            float test = 1.7817811f; //小数点以下7つめで四捨五入決まる
            Console.WriteLine("value for pi = {0}", pi);
            Console.WriteLine("value for test = {0}", test);

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
