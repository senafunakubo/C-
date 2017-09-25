using System;

namespace Switch
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine("enter a number between 1:7");
			int day = int.Parse(Console.ReadLine());

			//one expression but multiple value use switch
			switch (day)
			{
				case 1:
					Console.WriteLine("MONDAY");
					break;
				case 2:
					Console.WriteLine("TUESDAY");
					break;
				case 3:
					Console.WriteLine("WEDNESDAY");
					break;
				case 4:
				case 5:
				case 6:
				case 7:
					Console.WriteLine("Any other day");
					break;
				default:
					Console.WriteLine();
					break;
			}
			Console.Read();
        }
    }
}
