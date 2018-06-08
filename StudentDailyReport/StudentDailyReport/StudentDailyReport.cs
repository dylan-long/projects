using System;

namespace StudentDailyReport
{
    class Program
    {
        static void Main()
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
