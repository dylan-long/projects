using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//- The program must start by printing “The Tech Academy”.

//- The next line below that must be “Student Daily Report”

//- You must ask and save to a well-named variable and proper data type answers to the following questions:

//What course are you on?

//What page number?

//Do you need help with anything? Please answer “true” or “false”.

//Were there any positive experiences you’d like to share? Please give specifics.

//Is there any other feedback you’d like to provide? Please be specific.

//How many hours did you study today?

//- After all of the questions are asked, print, “Thank you for your answers. An Instructor will respond to this shortly.Have a great day!” This would be the end of the program.
namespace StudentDailyReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student daily report");
            Console.WriteLine("what course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number are you on?");
            string pageNumber = Console.ReadLine();
            int page = Convert.ToInt32(pageNumber);
            Console.WriteLine("Do you need help with anything? please answer \"true\" or \"false\"");
            string helpAnswer = Console.ReadLine();
            bool answer = Convert.ToBoolean(helpAnswer);
            Console.WriteLine("Were there any positive experiences youd like to share? Please give specifics");
            string positiveExp = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study?");
            string studyTime = Console.ReadLine();
            byte Time = Convert.ToByte(studyTime);
            Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly.         Have a great day!");
            Console.ReadLine();
          








        }
    }
}
