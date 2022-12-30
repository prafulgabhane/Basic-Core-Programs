using System;
namespace BasicCoreProgram
{
	public class LeapYear
	{
		public static void Year()
		// UC-3 Determine entered year is Leap Year or not
        {
            // ensure it is a 4 digit number.
            Console.WriteLine("Enter four digits year : ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year > 999 && year <= 9999)
            {
                if (year % 4 == 0 || year % 400 == 0 && year % 100 != 0)
                {
                    Console.WriteLine("year is leap year");
                }
                else
                {
                    Console.WriteLine("year is not leap year");
                }
            }
            else
            {
                Console.WriteLine("Invalid: Please Enter 4 digit only");
            }
            Console.ReadLine();

        }
    }

}