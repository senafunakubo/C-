using System;

namespace _2.NumberConversions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int numValue = 0;
            Console.WriteLine("enter a number between -217483684 to +2147483647");
            string input = Console.ReadLine();
            try{
                numValue = Convert.ToInt32(input);
            }
            catch(FormatException e){
                Console.WriteLine("INPUT STRING IS NOT A SEQUENCE OF DIGITS" + e.Message);
            }
            catch(OverflowException e){
                Console.WriteLine("THE NUMBER CANNOT FIT IN INT32" + e.Message);
            }
            finally{
                if(numValue < Int32.MaxValue){
                    Console.WriteLine("your new value is {0}", numValue + 1);
                }
                else{
                    Console.WriteLine("numVal cannot be incremented beyond its current");
                }
            }
            Console.Read();
        }
    }
}
