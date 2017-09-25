using System;

namespace OptionalParameters
{
    class MainClass
    {
        //optional parameters
        //if you dont pass the parameters in function call
        // it take the optional parameter value
        public void PrintNumber(int start=0, int end=20){
            for (int i = start; i <= end; i++){
                Console.Write("{0}",i);
            }
            Console.WriteLine();
        }

         static void Main(string[] args)
        {
            MainClass m = new MainClass();
            m.PrintNumber();
			m.PrintNumber(5,10);
			m.PrintNumber(15);
            m.PrintNumber(end: 40, start: 35);
            Console.Read();
        }
    }
}
