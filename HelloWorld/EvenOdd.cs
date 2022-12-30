using System;
namespace BasicCoreProgram
{
	public class EvenOdd
	{
		public static void Input()
		{
            int num;

            Console.WriteLine("Enter Any Positive Number :");
            num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("Even Number");
            }

            else
            {
                Console.WriteLine("Odd Number");

            }
            Console.ReadLine();
        }
	}
}

