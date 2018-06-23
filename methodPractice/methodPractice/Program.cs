using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodPractice
{
   public class Program
    {
        
        public static void Main(string[] arg)
        {
           

            Console.WriteLine("please input a number: ");
            int userInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("this is your number: " + userInput);
            int product = MathOperations.Multiply(userInput);
            int sum = MathOperations.Add(userInput);
            int quotient = MathOperations.Divide(userInput);

            Console.WriteLine(product + " this is your number times 4");
            Console.WriteLine(sum + " this is your number plus 10");
            Console.WriteLine(quotient + " this is your number divided by 2 (rounded to the nearest whole number)");

            Console.ReadLine();

        }
    }
   
}

