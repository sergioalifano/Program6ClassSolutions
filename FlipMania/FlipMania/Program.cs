using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlipMania
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipCoins(10000);
            FlipForHeads(10000);

            Console.ReadKey();
        }
        /// <summary>
        /// Take the number of flips and count how many Heads and Tails we get
        /// </summary>
        /// <param name="numberOfFlips">Number of flips</param>
        static void FlipCoins(int numberOfFlips)
        {
            int NumberOfHeads = 0;
            int numberOfTails = 0;
            Random randomGenerator = new Random();

            //loop to flip the coin numberOfFlips times
            for (int i = 0; i < numberOfFlips; i++)
            {
                int randomNumber = randomGenerator.Next(0, 2);
                if (randomNumber == 0)
                {
                    //increment number of Heads found
                    NumberOfHeads++;
                }
                else
                {
                    //increment number of Tails found
                    numberOfTails++;
                }
            }

            Console.WriteLine("We flipped a coin {0} times", numberOfFlips);
            Console.WriteLine("Number of Heads: {0}", NumberOfHeads);
            Console.WriteLine("Number of Tails: {0}", numberOfTails);

            

         }

        /// <summary>
        /// Flip a coin until we get a specific number of Heads that we give as input
        /// </summary>
        /// <param name="numberOfHeads">Number of Heads we want to find</param>
        static void FlipForHeads(int numberOfHeads)
        {
            int numberOfHeadFlipped = 0;
            int totalFlips = 0;
            Random randomGenerator = new Random();

            //loop until we get numberOfHeads times Heads
            while (numberOfHeadFlipped <= numberOfHeads)
            {
                int randomNumber = randomGenerator.Next(0,2);
                totalFlips++;

                if (randomNumber == 0)
                {
                    numberOfHeadFlipped++;
                }
            }

            Console.WriteLine("We are flipping a coin until we find {0} Heads", numberOfHeads);
            Console.WriteLine("It took {0} to find {1} Heads", totalFlips,numberOfHeads);
        }
    }
}
