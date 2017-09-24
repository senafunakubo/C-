using System;

namespace ForLoopFactorial
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Factrial 2! = 2*1 = 2;
            //Factrial 3! = 3*2*1 = 6;
            //Factrial 4! = 4*3*2*1 = 24;
            //Factrial 5! = 5*4*3*2*1 = 120;

            //intialization; condition; increment/decrement
            int n = 5;
            int factrial = 1;
            for (int i = n; i >= 1; i--){
                factrial = factrial * i;
            }
            Console.WriteLine("{0}! = {1}", n, factrial);

			int m = 20;
            decimal fac = 1;
			for (int i = m; i >= 1; i--)
			{
				fac = fac * i;
			}
			Console.WriteLine("{0}! = {1}", m, fac);

            //Variation of for loop
            //For-each loop
            string[] dayName = new string[]{
                "MONDAY","TUESDAY","WEDNESDAY",
                "THURSDAY","FRIDAY","SATURDAY","SUNDAY"
            };
            //datatype variable keyword(in) collection_name
            //for-each is used over collection i.g. list, arrays
            //maps,sets
            //foreach(string day)

            Console.Read();
		}
    }
}
