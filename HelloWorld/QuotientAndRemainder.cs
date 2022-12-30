using System;
namespace BasicCoreProgram
{
	public class QuotientAndRemainder
	{
		public static void Input()
		{
            // UC-6 Program to Compute Quotient and Remainder

            int dividend, divisor, quotient, remainder;

            Console.WriteLine("Enter Dividend"); // eg 12
            dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Divisor");  //eg 3
            divisor = Convert.ToInt32(Console.ReadLine());

            quotient = dividend / divisor;
            remainder = dividend % divisor;

            Console.WriteLine("Quotient is " + quotient); // 4 
            Console.WriteLine("Remainder is " + remainder); // 0
            Console.ReadLine();
        }
	}
}

