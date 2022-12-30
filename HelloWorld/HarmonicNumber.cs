using System;
namespace BasicCoreProgram
{
	public class HarmonicNumber
	{
		public static void Input()
		{
            {
                /* Harmonic Number
                     Prints the Nth harmonic number: 1 / 1 + 1 / 2 + ... +1 / N
                     The Harmonic Value N.Ensure N != 0
                     compute 1 / 1 + 1 / 2 + 1 / 3 + ... +1 / N
                     Print the Nth Harmonic Value.

                        example:
                        H1 = 1 
                        H2 = H1 + 1/2 
                        H3 = H2 + 1/3 
                        H4 = H3 + 1/4 
                        . 
                        . 
                        . 
                        Hn = Hn-1 + 1/n 

                 */

                Console.Write("Enter the value of N: ");
                int N = Convert.ToInt32(Console.ReadLine());
                float harmonic = 1;

                // loop to apply the formula
                // Hn = H1 + H2 + H3 ... + Hn-1 + Hn-1 + 1/n 

                for (int i = 2; i <= N; i++)
                {
                    harmonic += (float)1 / i;
                    Console.WriteLine("{0} = {1}/{2}", N, N, i);
                }
                Console.WriteLine("Harmonic:" + harmonic);
            }
        }
    }
}

