using System;

namespace PlayerReachesWinningPosition100
{
    class UC4_PlayerWinningPosition
    {
       public const int NoPlay = 1;
       public const int IsLadder = 2;
       public const int IsSnake = 3;
        static void Main(string[] args)
        {
            //Variables
            int Position = 0;
            int rolls = 0;
            int option = 0;
            int winningPosition = 100;
            Console.WriteLine("Player is at Position: " + Position);

            //Untill Winning Position 100
            while(Position < winningPosition)
            {
                //Roll dai Using Random Function
                Random random = new Random();

                while (true)
                {
                    rolls = random.Next(7);
                    if (rolls != 0)
                        break;
                }
                Console.WriteLine("Rolls: " + rolls);

                //Option for Player
                Random randomNum = new Random();

                while (true)
                {
                    option = randomNum.Next(0, 3);
                    if (option != 0)
                        break;
                }
                Console.WriteLine("Options: \nOption 1 : No Play \nOption 2 : Ladder \nOption3 : Snake \n");
                Console.WriteLine("Option : " + option);

                switch (option)
                {
                    case NoPlay:
                        Console.WriteLine("No Play! Player Stay at same position: " + Position);
                        break;

                    case IsLadder:
                        Position += rolls;
                        Console.WriteLine("Ladder! Player Move Ahead by the number of position received by dai");
                        break;

                    case IsSnake:
                        Console.WriteLine("Snake! Player Move Behind by the number of position received by dai");
                        Position -= rolls;
                        if (Position < 0)
                        {
                            Position = 0;
                        }
                        break;
                    default:
                        Console.WriteLine("You Can't Play! Please Enter Correct Value");
                        break;

                }
            }

        }
    }
}
