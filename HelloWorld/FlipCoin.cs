using System;
namespace HelloWorld
{
	public class FlipCoin
    {
        // UC-2 Flip Coin and print percentage of Heads and Tails

        public const int HEAD = 0;
        public const int TAIL = 1;

        public static void Toss()
        {
            int HeadCount = 0;
            int TailCount = 0;
            int conditionCheck = 0, number = 0;
            double PercentageHead = 0, PercentageTail = 0;

            //input  -> The number of times to Flip Coin.
            Console.WriteLine("How many time do you want to flip ?");
            number = Convert.ToInt32(Console.ReadLine());

            Random random = new Random(); //random function

            for (int i = 0; i < number; i++)
            {
                // Use Random Function to get value between 0 and 1
                conditionCheck = random.Next(0, 2);

                //head or tail select randomly
                switch (conditionCheck)
                {
                    case HEAD:
                        HeadCount = HeadCount + 1;
                        //Console.WriteLine("Head");
                        break;

                    case TAIL:
                        TailCount = TailCount + 1;
                        // Console.WriteLine("Tail");
                        break;

                    default:
                        Console.WriteLine("default");
                        break;
                }
            }
            Console.WriteLine("Head {0} \t Tail {1}\n", HeadCount, TailCount);
            PercentageHead = (HeadCount * 100 / number);
            PercentageTail = TailCount * 100 / number;
            Console.WriteLine("Probability of getting:\nHead {0} % \tTail {1} %", PercentageHead, PercentageTail);
            Console.ReadLine();
        }
    }

}

