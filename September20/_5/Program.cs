using System;

namespace _5.Condition
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter two numbers ");
            int first = int.Parse(Console.ReadLine());
            int second = int.Parse(Console.ReadLine());
            if (first == second)
            {
                Console.WriteLine("both are equal");
            }
            else
            {
                if (first > second){
                    Console.WriteLine("first number is greater");
                }
                else{
					Console.WriteLine("second number is greater");
                }
            }
            // else... if ladder (n conditions)
            if (first == second){
                Console.WriteLine("both are equal");
            }
            else if (first > second){
                Console.WriteLine("first number is greater");
            }
            else if (first < second){
                Console.WriteLine("second number is greater");
            }
            else{
                Console.WriteLine("no comparison result");
            }
            Console.Read();
        }
    }
}
