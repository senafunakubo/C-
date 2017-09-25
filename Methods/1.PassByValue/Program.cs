using System;

namespace PassByValue
{
    //program for exchanging the values for two variable
    // input : a =10, b=5;
    // output: a = 5, b=10;
    class MainClass
    {
		// Method declatation here
		// Method will always have a name, return detatype and arguments ()
		// Method means separete block for code

        public void swap(int x, int y)
        {
            int temp = 0;
            temp = x;
            x = y;
            y = temp;
            Console.WriteLine("Inside the swap Method a = {0} b = {1}",x,y);

        }

	     static void Main(string[] args)
        {
            int a = 10;
            int b = 5;
            Console.WriteLine("Before method call values are a={0} & b={1}",a,b);
            MainClass m = new MainClass();
            m.swap(a,b);
            Console.WriteLine("After method call values are a={0} & b={1}",a,b);
            Console.Read();
        }
    }
}
