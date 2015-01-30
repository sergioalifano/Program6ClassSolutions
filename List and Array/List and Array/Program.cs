using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_and_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //ARRAY
            string[] foodArray = new string[5];
            foodArray[0] = "quinoa";
            foodArray[1] = "grapes";

            //or
            string[] foodArray2 = { "qinoa", "grapes" };

            //multidimensional array
            int[,] twoD=new int[2,5];
            twoD[1, 2] = 5;

            //LIST
            List<string>teams=new List<string>();
            teams.Add("Broncos");
            teams.Add("49ers");

            teams.IndexOf("Broncos");

            teams.Contains("broncos"); //<---return T or F
    
            //FROM ARRAY to LIST
            


            Console.ReadKey();

        }
    }
}
