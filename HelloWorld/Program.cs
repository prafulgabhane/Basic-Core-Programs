namespace HelloWorld
{
    class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Core Program:");

            Console.WriteLine("Choose any Program");
            Console.WriteLine("1:User Data\n2:Flip Coin\n");
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

                default:
                    Console.WriteLine("Enter Between Range");
                    break;
            }
            Console.WriteLine("Program Ends Press Any Key");
            Console.ReadLine();
        }
    }
}