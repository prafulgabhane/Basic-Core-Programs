using System;
namespace HelloWorld
{
	public class UserInput
	{
		public static void UserData()
		{

            Console.WriteLine("Enter Username:");

            string userName = Console.ReadLine();

            Console.WriteLine("Username is: " + userName);

        }
    }
}

