using System;
namespace branchingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to package express! please follow the instructions below");

            Console.WriteLine("");
            Console.WriteLine("What is the package weight?");
            Console.WriteLine("");

            int weight = Convert.ToInt32(Console.ReadLine());
            bool errorWeight = weight > 50;
            if (errorWeight == true)
            {
                Console.WriteLine("This package is to heavy to be shipped via package express. have a nice day");
                Console.ReadLine();
                Environment.Exit(0);
            }
            Console.WriteLine("");
            Console.WriteLine("what is the package width?");
            Console.WriteLine("");

            int width = Convert.ToInt32(Console.ReadLine());
          
            Console.WriteLine("");
            Console.WriteLine("What is the package height?");
            Console.WriteLine("");

            int height = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine("what is the package length?");
            Console.WriteLine("");

            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int packageSize = length + height + width;
            if (packageSize > 50)
            {
                Console.WriteLine("This package is to big to be shipped via package express. have a nice day");
                Console.ReadLine();
                Environment.Exit(0);
            }
            float packageTotal = length * height * width;
            float quote = packageTotal * weight / 100;
            Console.WriteLine("");
            Console.WriteLine("your estimated shipping cost is $" + quote);
            Console.ReadLine();

        }
    }
}
