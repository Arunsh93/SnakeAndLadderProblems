using System;

namespace PlayerRollsDaiUsungRandom
{
    class UC2_RollsDaiUsingRandom
    {
        static void Main(string[] args)

        {
            int Position = 0;
            int rolls = 0;
            Console.WriteLine("Player is at Position: " + Position);

            Random random = new Random();

            while(true)
            {
                rolls = random.Next(7);
                if (rolls != 0)
                    break;
            }
            Console.WriteLine(rolls);
        }
    }
}
