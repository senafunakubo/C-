using System;

namespace Comparator
{
    class MainClass
    {
		//1. create a NumberComparator class that imlements IComparer<int>
		//2. compare using module 6
		private class StudentComparator : System.Collections.Generic.IComparer<string>
        {
			public int Compare(string x, string y)
			{
				// use var for reference data type (i.e. structures, object)
				//if value datatype than use the data type not var
				// Mitali Pattani
				//spilting student name from ' '
				string lastName1 = x.Substring(x.IndexOf(' ') + 1);
				string lastname2 = y.Substring(y.IndexOf(' ') + 1);
				return lastName1.CompareTo(lastname2);
			}
		}


		static void Main(string[] args)
		{
			int[] numbers = { 1, 2, 5, 10, 11, 12 };
			Console.WriteLine("Numbers Sorted by module 6");
			//using lamdba expression
			Array.Sort(numbers, (x, y) => (x % 6).CompareTo(y % 6));
			//excercise : use the IComparer interface for sorting here

			Console.WriteLine("output ");
			foreach (int no in numbers)
			{
				Console.Write("{0}\t", no);
			}

			//Sorting by last name
			string[] students = {"Doncho Mikov", "Nikola Kostov",
				"Ivaylo Kenoz","Evalogi Hristov" };
			Console.WriteLine("\nstudents sorted by first letter of their last name");
			Array.Sort(students, new StudentComparator());
			foreach (string studentname in students)
			{
				Console.WriteLine(studentname);
			}

			Console.Read();
		}

    }
}
