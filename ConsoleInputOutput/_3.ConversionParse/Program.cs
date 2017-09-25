using System;

namespace _3.ConversionParse
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.Write("a = ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("float b = ");
            float f = float.Parse(Console.ReadLine());
            Console.WriteLine("double d = ");
            double d = double.Parse(Console.ReadLine());

            Console.WriteLine("{0},{1},{2}", a, f, d);
            string str = Console.ReadLine();
            int number;
            if(int.TryParse(str, out number)){ //output number
                Console.WriteLine("Valid Number{0}", number);
            }
            else{
                Console.WriteLine("Invalid Number{0}", str);
            }
            Console.Read();
        }
    }
}

// ! ... Negation or logicalNot or Complement
