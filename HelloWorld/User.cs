using System;
namespace HelloWorld
{
	public class UserInput
	{
		public static void UserData()
		{
            // UC-1 To Display username 

            Console.WriteLine("Enter Username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);
        }
    }
}

