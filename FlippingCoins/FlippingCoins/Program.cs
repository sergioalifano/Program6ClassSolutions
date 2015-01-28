using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlippingCoins
{
    class Program
    {
        static Random RandomNumberGenerator = new Random();

        static void Main(string[] args)
        {
            for(int i=0; i<10; i++)
                Console.WriteLine(  FlipACoin() );

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(FlipForHeads());
            }

            Console.ReadKey();
        }

        /// <summary>
        /// flips a coin
        /// </summary>
        /// <returns>heads or tails</returns>
        static string FlipACoin()
        {
            //random number between 0 and 1
            int theFlip = RandomNumberGenerator.Next(0, 2);
            if (theFlip == 0)
            {
                return "Heads";
            }
            return "Tails";
        }

        /// <summary>
        /// counts how many times we need to flip a coin to get a heads
        /// </summary>
        /// <returns>number of flips to get Heads</returns>
        static int FlipForHeads()
        {
            bool headsHasNotBeenFlipped = true;
            int howManyFlips = 0;
            while (headsHasNotBeenFlipped)
            {
                string theFlip=FlipACoin();
                howManyFlips++;

                if (theFlip == "Heads")
                {
                    headsHasNotBeenFlipped = false;
                }
            }

            return howManyFlips;
        }
    }
}
