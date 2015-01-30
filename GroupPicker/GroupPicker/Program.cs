using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupPicker
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> studentList1 = new List<string> {"Andrew","Tim","Michael","Linda","Eugene","Andrii","Nate","Nicole","Juli","Sergio","Mike","Jason","Brandon","Maria","Daniel","Laura","Dustin","Eric","Pat","Jeff","Nicole" };
            PickGroup(studentList1,2);

            List<string> studentList2 = new List<string> { "Andrew", "Tim", "Michael", "Linda", "Eugene", "Andrii", "Nate", "Nicole", "Juli", "Sergio", "Mike", "Jason", "Brandon", "Maria", "Daniel", "Laura", "Dustin", "Eric", "Pat", "Jeff", "Nicole" };
            PickGroup(studentList2,3);

            List<string> studentList3 = new List<string> { "Andrew", "Tim", "Michael", "Linda", "Eugene", "Andrii", "Nate", "Nicole", "Juli", "Sergio", "Mike", "Jason", "Brandon", "Maria", "Daniel", "Laura", "Dustin", "Eric", "Pat", "Jeff", "Nicole" };
            PickGroup(studentList3,4);

            Console.ReadKey();
        }

        /// <summary>
        /// The function randomly distribute students of a list into groups 
        /// </summary>
        /// <param name="StudentList">list of students</param>
        /// <param name="groupSize">size of the group</param>
        static void PickGroup(List<string> StudentList, int groupSize)
        {
            Random numberGenerator = new Random();
            List<string> currentGrouplist = new List<string>();
            int groupNumber = 1;

            while(StudentList.Count>0)
            {
                //generate a random number between 0 and the size of the list of students
                int randomNumber = numberGenerator.Next(0, StudentList.Count);

                //pick up a random student from the list
                string currentStudent = StudentList[randomNumber];
                //add the student to the group
                currentGrouplist.Add(currentStudent);

                //remove the student from the list
                StudentList.RemoveAt(randomNumber);

                //if the group is full or there are no more students in the list
                if (currentGrouplist.Count == groupSize || StudentList.Count == 0)
                {
                    //print out the group
                    Console.WriteLine("GROUP {0}",groupNumber);
                    for (int j = 0; j < currentGrouplist.Count; j++)
                    {
                        Console.WriteLine(currentGrouplist[j]);
                    }

                    Console.WriteLine();

                    //clear the current group list  
                    currentGrouplist.Clear();

                    groupNumber++;


                }
            }
        }
    }
}
