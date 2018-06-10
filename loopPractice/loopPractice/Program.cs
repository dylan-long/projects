using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is 27 + 33?");
            int answer = Convert.ToInt32(Console.ReadLine());
            bool correct = answer == 60;

            do
            {
                switch (answer)
                {
                    case 60:
                        Console.WriteLine("That is the correct answer. good job!");
                        correct = true;
                        break;

                    default:
                        Console.WriteLine("that is incorect. please try again.");
                        Console.WriteLine("what is 27 + 33?");
                        answer = Convert.ToInt32(Console.ReadLine());
                        break;

                }

            }
            while (!correct);
            Console.ReadLine();

        }
    }
}
