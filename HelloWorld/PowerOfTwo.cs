using System;
namespace BasicCoreProgram
{
	public class PowerOfTwo
	{
		public static void Power()
        { 
            /* UC-4 Power of 2
            a.Desc -> This program takes a command-line argument N and prints a table of the
            powers of 2 that are less than or equal to 2^N.
            b.I/P -> The Power Value N.Only works if 0 <= N< 31 since 2^31 overflows an int
            c.Logic -> repeat until i equals N.  */

            int powOfTwo;
            Console.WriteLine("Enter value to print Power of 2 table");
            int n = Convert.ToInt32(Console.ReadLine());

            if (n > 0 && n < 31)
            {
                Console.WriteLine("Displaying upto {0}", n);

                for (int i = 0; i <= n; i++)
                {
                    powOfTwo = Convert.ToInt32(Math.Pow(2, i)); //using math function 2 ^ i
                    Console.WriteLine("2^" + i + " : " + powOfTwo);
                }

                //here i=n condition satisfied
            }
            else
            {
                Console.WriteLine("Please Enter value of n from 0 to 30");
            }
            Console.ReadLine();

        }
    }
    }