using System;

namespace OneDimensionsalArray
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			//one dimensional array 
			string[] cities = new string[10];
			cities[0] = "Vancouver";
			cities[1] = "Richmond";
			cities[2] = "Burnbay";
			//or
			string[] citiesName = {"VANCOUVER","LANGLEY","SURREY" ,
					"KELOWNA","RICHMOND","NEW WESTMINISTER","COQUITLAM"};
			Console.WriteLine("Unsorted : {0} ", string.Join(" , ", citiesName));
			Array.Sort(citiesName);
			Console.WriteLine("Sorted : {0} ", string.Join(" , ", citiesName));
			Console.WriteLine("size of array is  {0}", citiesName.Length);
			
            //Binary search
			//1.  values must be sorted in ascending
			//use binaryserach()
			//Result give you the index value if target is present
			//otherwise -1;
			string target = "RICHMOND";
			int index = Array.BinarySearch(citiesName, target);
			Console.WriteLine("{0} element is fount at index {1}", target, index);
			Console.Read();
        }
    }
}
