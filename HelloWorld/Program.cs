﻿namespace BasicCoreProgram
{
    class Program
    {
       public static void Main(string[] args)
       {
            Console.WriteLine("Welcome to Basic Core Program:");

            Console.WriteLine("Choose any Program");
            Console.WriteLine("1:User Data\n2:Flip Coin\n3:Leap Year\n4:Power of Two\n5:Harmonic No");
            Console.WriteLine("6:Quotient and Remainder\n");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Print Username");
                    UserInput.UserData();
                    break;

                case 2:
                    Console.WriteLine("Flip a coin");
                    FlipCoin.Toss();
                    break;

                case 3:
                    Console.WriteLine("Flip a coin");
                    LeapYear.Year();
                    break;
                case 4:
                    Console.WriteLine("Power of Two");
                    PowerOfTwo.Power();
                    break;
                case 5:
                    Console.WriteLine("Harmonic Number");
                    HarmonicNumber.Input();
                    break;

                case 6:
                    Console.WriteLine("Quotient and Remainder");
                    QuotientAndRemainder.Input();
                    break;
                  
                default:
                    Console.WriteLine("Enter Between Range");
                    break;
            }
        Console.WriteLine("Program Ends Press Any Key");
        Console.ReadLine();
        }
    }
}