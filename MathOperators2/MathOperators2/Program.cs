using System;

namespace MathOperators2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Time to learn you some math, kids!");
            Console.WriteLine("");
            Console.WriteLine("Multiplies by 50");
            string input1 = Console.ReadLine();
            int multiply = Convert.ToInt32(input1);
            int total1 = 50;
            Console.WriteLine( multiply * total1);
            Console.WriteLine("");
            Console.WriteLine("adds 25");
            string input2 = Console.ReadLine();
            int addition = Convert.ToInt32(input2);
            int total2 = 25;
            Console.WriteLine(addition + total2);
            Console.WriteLine("");
            Console.WriteLine("Devides by 12.5");
            string input3 = Console.ReadLine();
            float devide = Convert.ToSingle(input3);
            float total3 = 12.5f;
            Console.WriteLine(devide / total3);
            Console.WriteLine("");
            Console.WriteLine("Checks if greater than 50");
            string input4 = Console.ReadLine();
            int check = Convert.ToInt32(input4);
            bool total4 = 50 < check;
            Console.WriteLine(total4);
            Console.WriteLine("");
            Console.WriteLine("Shows remainder of input / 7");
            string input5 = Console.ReadLine();
            int remainder = Convert.ToInt32(input5);
            int total5 = remainder % 7;
            Console.WriteLine(total5);
            Console.ReadLine();
        }
    }
}
