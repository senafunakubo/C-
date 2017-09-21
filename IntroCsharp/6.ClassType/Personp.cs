using System;
namespace ClassType
{
    public class Personp
    {
        private int age;
        private string name;

        //constructor
        public Personp(String name, int age)
        {
            this.name = name;
            this.age = age;
        }

        //method
        public void PrintPerson(){
            Console.WriteLine("{0} , {1} years old", name, age);
        }
    }
}
