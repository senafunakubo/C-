using System;

namespace Testtt
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());


            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                for (int column = 0; column < columns; column++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, column);
                    matrix[row, column] = int.Parse(Console.ReadLine());
                }
            }
        }
    }
}