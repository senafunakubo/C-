using System;

namespace _1.Transformat
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            float pi = 3.14519206f;
            Console.WriteLine("{0:F3}",pi);
            //Hexadecimal X
            Console.WriteLine("{0:X}", 250);
            //string formatting with left align or right align
            double colaPrice = 1.20;
            string cola = "Coca cola";
            double fantaPrice = 1.20;
            string fanta = "FANTA DIZZY";
            double pepsiPrice = 1.50;
            string pepsi = "PEPSI";

            Console.WriteLine("----------");
            // - sign means left align + means right aligned
            // number like 15 means total space is 15
            Console.WriteLine("{0,-15} | {1,15:F2}",cola,colaPrice);
            Console.WriteLine("{0,-15} | {1,10:F2}", fanta, fantaPrice);
            Console.WriteLine("{0,15} | {1,-15:F2}", pepsi, pepsiPrice);
            Console.Read();
        }
    }
}
