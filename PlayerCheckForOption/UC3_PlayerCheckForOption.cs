using System;

namespace PlayerCheckForOption
{
    class UC3_PlayerCheckForOption
    {
        static void Main(string[] args)
        {
            int Position = 0;
            int rolls = 0;
            int option = 0;
            Console.WriteLine("Player is at Position: " + Position);
            
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

            while(true)
            {
                option = randomNum.Next(0, 3);
                if (option != 0)
                    break;
            }
            Console.WriteLine("Options: \nOption 1 : No Play \nOption 2 : Ladder \nOption3 : Snake \n");
            Console.WriteLine("Option : " + option);

            switch(option)
            {
                case 1:
                    Console.WriteLine("No Play! Player Stay at same position: " + Position);
                    break;

                case 2:
                    Position += rolls;
                    Console.WriteLine("Ladder! Player Move Ahead by the number of position received by dai");
                    break;

                case 3:
                    Position -= rolls;
                    Console.WriteLine("Snake! Player Move Behind by the number of position received by dai");
                    break;
            }
        }
    }
}
