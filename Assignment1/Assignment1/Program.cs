using System;

namespace Assignment1
{
    
    class MainClass
    {
        //To put these value to global
		//public static int numVal1 = -1;
		//public static int numVal2 = -1;
        public static int num;
        public static int input;
        public static string math;

        public static void Main(string[] args)
        {
            problem1();
            problem2();
            problem3();
            problem4();
            problem5();
            problem6();
            problem7();
            problem8();
            problem9();
            problem10();
        }

        public static void problem1(){
            Console.WriteLine("Problem1");
			Console.WriteLine("Hello!");
			Console.WriteLine("Sena!\n");
        }

        public static void problem2(){
			int numVal1 = 0;
			int numVal2 = 0;

            Console.WriteLine("Problem2");
            Console.WriteLine("Type a first number.");
            string input1 = Console.ReadLine();
            numVal1 = Convert.ToInt32(input1);

            Console.WriteLine("Type a second number.");
            string input2 = Console.ReadLine();
            numVal2 = Convert.ToInt32(input2);

            Console.WriteLine("{0} + {1} = {2}",
                              numVal1,numVal2,numVal1 + numVal2);
			Console.WriteLine("{0} - {1} = {2}",
							  numVal1, numVal2, numVal1 - numVal2);
			Console.WriteLine("{0} * {1} = {2}",
							  numVal1, numVal2, numVal1 * numVal2);
			Console.WriteLine("{0} / {1} = {2}",
							  numVal1, numVal2, numVal1 / numVal2);
			Console.WriteLine("{0} % {1} = {2}\n",
							  numVal1, numVal2, numVal1 % numVal2);

        }

        public static void problem3(){
            int celsius = 0;

            Console.WriteLine("Problem3");
            Console.WriteLine("Type Celsius degrees to covert to Kelvin and Fahrenheit.");
            string celsiusSt = Console.ReadLine();
            celsius = Convert.ToInt32(celsiusSt);

            Console.WriteLine("Kelvin = {0}", celsius + 273);
            Console.WriteLine("Fahrenheit = {0}\n", celsius * 1.8 + 32);
        }

        public static void problem4(){
            char letter1, letter2, letter3;
            Console.WriteLine("Problem4");
            Console.WriteLine("Type a first letter.");
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Type a second letter.");
            letter2 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Type a thied letter.");
            letter3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0} {1} {2}\n", letter3,letter2,letter1);
        }

        public static void problem5(){
            char symbol;
            Console.WriteLine("Problem5");
            Console.WriteLine("Input a symbol.");
            symbol = Convert.ToChar(Console.ReadLine().ToLower());

            if((symbol=='a') || (symbol == 'i') || (symbol == 'u') ||
               (symbol == 'e') || (symbol == 'o')){
                Console.WriteLine("It's a vowel.\n");
            }
            else if((symbol>='0') &&(symbol <= '9')){
                Console.WriteLine("It's a digit.\n");
            }
            else{
                Console.WriteLine("It's another one.\n");
            }
        }

        public static void problem6(){
            int num = 0;
            Console.WriteLine("Problem6");
            Console.WriteLine("Input a number.");
			string numSt = Console.ReadLine();
            num = Convert.ToInt32(numSt);

            if(num == 0){
                Console.WriteLine("This number is zero.\n");
            }
            else if(num%2==0){
                Console.WriteLine("This number is even.\n");
            }
            else
            {
                Console.WriteLine("This number is odd.\n");
            }
        }

		public static void problem7()
		{
            int height = 0;
            Console.WriteLine("Problem7");
            Console.WriteLine("Input your height.");
            string heightSt = Console.ReadLine();
            height = Convert.ToInt32(heightSt);

            if(height < 150){
                Console.WriteLine("You are Dwarf.\n");
            }
            else if(height>=150 && height<165){
                Console.WriteLine("You have an average height.\n");
            }
            else if(height>=165 && height<195){
                Console.WriteLine("You are taller.\n");
            }
            else{
                Console.WriteLine("You have an abnormal height.\n");
            }
		}

		public static void problem8()
		{
			int a, b, c;

			double d, x1, x2;
			Console.WriteLine("Calculate root of Quadratic Equation :\n");

			Console.WriteLine("Input the value of a : ");
			a = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Input the value of b : ");
			b = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Input the value of c : ");
			c = Convert.ToInt32(Console.ReadLine());

			d = b * b - 4 * a * c;
			if (d == 0)
			{
				Console.Write("Both roots are equal.\n");
				x1 = -b / (2.0 * a);
				x2 = x1;
				Console.Write("First  Root Root1= {0}\n", x1);
				Console.Write("Second Root Root2= {0}\n", x2);
			}
			else if (d > 0)
			{
				Console.Write("Both roots are real and diff-2\n");

				x1 = (-b + Math.Sqrt(d)) / (2 * a);
				x2 = (-b - Math.Sqrt(d)) / (2 * a);

				Console.Write("First  Root Root1= {0}\n", x1);
				Console.Write("Second Root root2= {0}\n", x2);
			}
			else
				Console.Write("Root are imeainary.\n");
		}

        public static void problem9(){
            int input1, input2 = 0;
            Console.WriteLine("Problem9");
            Console.WriteLine("Input a first number.");
            string inputSt1 = Console.ReadLine();
            input1 = Convert.ToInt32(inputSt1);

            Console.WriteLine("Input a second number.");
            string inputSt2 = Console.ReadLine();
            input2 = Convert.ToInt32(inputSt2);

            Console.WriteLine("---------------------");
            Console.WriteLine("Here are the options.");
            Console.WriteLine("1.Addition.");
            Console.WriteLine("2.Substraction.");
            Console.WriteLine("3.Multiplication.");
            Console.WriteLine("4.Division.");
            Console.WriteLine("5.Exit.");
            Console.WriteLine("---------------------");

            Console.WriteLine("Choose a menu!");
            num = Convert.ToInt32(Console.ReadLine());

            switch(num){
                case 1:
                    input = input1 + input2;
                    math = "Addition";
                    break;
				case 2:
                    input = input1 - input2;
                    math = "Substraction";
					break;
				case 3:
                    input = input1 * input2;
                    math = "Multiplication";
					break;
				case 4:
                    input = input1 / input2;
                    math = "Division";
					break;
				case 5:
                    Console.WriteLine("Bye!");
					break;
            }
            Console.WriteLine("Input your choice :{0}", num);
            Console.WriteLine("The {0} of {1} and {2} is: {3}\n", math, input1, input2, input);
        }

        public static void problem10(){
            Console.WriteLine("Problem10");
            DateTime date = new DateTime(2017, 9, 22);
			Console.WriteLine(date.ToString("yyyy-MM-dd"));
			Console.WriteLine(date.ToString("dd-MMM-yy"));
			Console.WriteLine(date.ToString("M/d/yyyy"));
			Console.WriteLine(date.ToString("M/d/yy"));
			Console.WriteLine(date.ToString("MM/dd/yyyy"));
			Console.WriteLine(date.ToString("MM/dd/yy"));
			Console.WriteLine(date.ToString("yy/MM/dd"));
            Console.Read();
        }
    }
}
