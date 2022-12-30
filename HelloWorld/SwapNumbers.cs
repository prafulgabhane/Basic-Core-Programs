using System;
namespace BasicCoreProgram
{
	public class SwapNumbers
	{
		public static void Input()
		{
            int temp = 0;
            int a = 0, b = 0;
            Console.WriteLine("Enter Two Numbers: ");
            Console.Write("a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping a= {0} b= {1}", a, b);
            temp = a;
            a = b;
            b = temp;
        }
	}
}

