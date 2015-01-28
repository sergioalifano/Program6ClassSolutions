using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopingThroughStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            string testSring= "the lazy dog jumps over the lazy bear";
            Console.WriteLine("We found {0} vowels in {1}", VowelCounter3000(testSring),testSring );
            Console.WriteLine("The average length of a word in {0} is {1}", testSring,AvarageWorldLengthFinder3000(testSring));
            OldTimeyTextPrinter(testSring, 100);
            OldTimeyTextPrinter(testSring, 50);

            Console.ReadKey();
        }

        /// <summary>
        /// Count the number of vowels in a string
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns>the number of vowels found</returns>
        static int VowelCounter3000(string inputText)
        {
            int numberOfVowelsFound = 0;

            for (int i = 0; i < inputText.Length; i++)
            {
                char letter = char.ToLower(inputText[i]);

                if (letter == 'a' || letter == 'e' || letter == 'i' || letter == 'o' || letter == 'u')
                {
                    numberOfVowelsFound++;
                }
            }

            return numberOfVowelsFound;
        }
       
        /// <summary>
        /// finds the average length of a word in a string
        /// </summary>
        /// <param name="inputText"></param>
        /// <returns>average length of characters in a word</returns>
        static double AvarageWorldLengthFinder3000(string inputText)
        {
            int totalNumberOfCharacters = 0;
          //  int totalNumberOfWords = 0;

            string[] wordArray = inputText.Split(' ');

            //loop over each word of the array
            for (int i = 0; i < wordArray.Length; i++)
            {
                //get the current word
                string currentWord = wordArray[i];

                totalNumberOfCharacters += currentWord.Length;

            }
            
            //average = total number of characters / total number of words
            double result = (totalNumberOfCharacters)/wordArray.Length;
            return result;
        }


        /// <summary>
        /// Prints text to the screen likean 80s ApleIIe
        /// </summary>
        /// <param name="inpuText">text to print</param>
        /// <param name="pauseDuration">duration of tha pause in milliseconds</param>
        static void OldTimeyTextPrinter(string inpuText, int pauseDuration)
        {
            //loop over each character
            for (int i = 0; i < inpuText.Length; i++)
            {
                char letter = inpuText[i];
                Console.Write(letter);

                System.Threading.Thread.Sleep(pauseDuration);
            }

            //after the text is complete write a line break
            Console.WriteLine();
        }
    }
}
