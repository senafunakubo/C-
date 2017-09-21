using System;

namespace ClassType
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Personp p1 = new Personp("Craig", 10);
            Personp p2 = new Personp("Salley", 29);
            Console.WriteLine("Child #1");
            p1.PrintPerson();
            Console.WriteLine("Child #2");
            p2.PrintPerson();
            Console.Read();
        }
    }
}
