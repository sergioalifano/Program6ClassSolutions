using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1review
{
    class Program
    {
        static void Main(string[] args)
        {
           // SpecificLetter("s", "Sally is sunny");
            Console.WriteLine( NumberRounder(21) );
            Console.WriteLine(NumberRounder(16));
            Console.WriteLine(NumberRounder(8));
            Console.WriteLine(NumberRounder(2));

            Console.WriteLine(Annoying("nickelback"));
            Console.ReadKey();
        }

        /// <summary>
        /// counts the number of instances of a specific letter in a string
        /// </summary>
        /// <param name="letterToCount"></param>
        /// <param name="stringToSearch"></param>
        static void SpecificLetter(string letterToCount, string stringToSearch)
        {
            int counter = 0;
            for (int i = 0; i < stringToSearch.Length; i++)
            {
                if (letterToCount == stringToSearch[i].ToString().ToLower())
                {
                    counter++;
                }
            }

            Console.WriteLine("{0} has {1} {2} in it",stringToSearch, counter, letterToCount);
        }

        /// <summary>
        /// round an integer to the nearest 5
        /// </summary>
        /// <param name="numberToRound"></param>
        /// <returns></returns>
        static int NumberRounder(int numberToRound)
        {
           
            int modulus=numberToRound%5;
            if (modulus <= 2)
                numberToRound = numberToRound- modulus;
            if (modulus == 3)
            {
                numberToRound += 2;
            }
            if (modulus == 4)
            {
                numberToRound += 1;
            }

            return numberToRound;
        }


        static string Annoying(string notAnnoying)
        {
            string news="";
            for (int i = 0; i < notAnnoying.Length; i++)
            {
                if (i % 2 == 0)
                {
                    news+= notAnnoying[i].ToString().ToUpper();
                }
                else news+= notAnnoying[i].ToString().ToLower();
            }
            return news;
        }

    }
   }        
              
           
        
    

