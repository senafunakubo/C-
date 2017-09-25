using System;

namespace Assignment2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            problem1();
            problem2();
            problem3();
        }


        public static void problem1()
        {
            Console.WriteLine("Problem1");


            int num = 5;

            for (int i = 1; i < num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");

            for (int i = 1; i < num; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n");
        }



        public static void problem2()
        {
            Console.WriteLine("Problem2");

            int i, j, number = 0;
            int RowSize = 5;
            int ColSize = 5;

            int[,] Matrix1 = new int[RowSize, ColSize];
            int[,] Matrix2 = new int[RowSize, ColSize];
            int[,] ResultMatrix = new int[RowSize, ColSize];

            Console.Write("Input the size of the square matrix (less than 5): ");
            number = Convert.ToInt32(Console.ReadLine()); //switch string to int

            if (number <= 5)
            {
                //Input numbers into the matrices
                Console.Write("\nInput elements in the first matrix :\n");
                for (i = 0; i < number; i++)
                {
                    for (j = 0; j < number; j++)
                    {
                        Console.Write("element - [{0},{1}] : ", i, j);
                        Matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                Console.Write("\nInput elements in the second matrix :\n");
                for (i = 0; i < number; i++)
                {
                    for (j = 0; j < number; j++)
                    {
                        Console.Write("element - [{0},{1}] : ", i, j);
                        Matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }

                // show up the inside of the matrices
                Console.WriteLine("\nThe First matrix is :");
                for (i = 0; i < number; i++)
                {
                    Console.WriteLine("");
                    for (j = 0; j < number; j++)
                    {
                        Console.Write("{0}\t", Matrix1[i, j]);
                    }
                }

                Console.WriteLine("\n\nThe Second matrix is :");
                for (i = 0; i < number; i++)
                {
                    Console.WriteLine("");
                    for (j = 0; j < number; j++)
                    {
                        Console.Write("{0}\t", Matrix2[i, j]);
                    }
                }


                // calculate the sum of the matrix
                for (i = 0; i < number; i++)
                {
                    for (j = 0; j < number; j++)
                    {
                        ResultMatrix[i, j] = Matrix1[i, j] + Matrix2[i, j];
                    }
                }

                Console.Write("\n\nThe Addition of two matrix is : \n");
                for (i = 0; i < number; i++)
                {
                    Console.Write("\n");
                    for (j = 0; j < number; j++)
                    {
                        Console.Write("{0}\t", ResultMatrix[i, j]);
                    }
                }
                Console.Write("\n\n");
            }
            else
            {
                Console.WriteLine("Inputting the size is more than 6.\n\n");
            }

        }// problem2



        public static void problem3(){
            Console.WriteLine("Problem3");

			int num;

			Console.Write("Enter a number (less than 43): ");
			num = Convert.ToInt32(Console.ReadLine());

            if (num <= 43)
            {
                Console.WriteLine("\nThe Fibonacci of {0} th term  is {1} \n", num, Fib(num));
            }
            else{
                Console.WriteLine("Inputting the number is more than 44.");
            }
        }

		public static int Fib(int number)
		{
            if (number <= 2)
            {
                return 1;
            }
            else
            {
                return Fib(number - 1) + Fib(number - 2);
            }
		}

    }//class

}