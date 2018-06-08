using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Anonymous Income Comparison Program
//Person 1
//Hourly Rate?
//15
//Hours worked per week?
//40
//Person 2
//Hourly Rate?
//20
//Hours worked per week?
//40
//Annual salary of Person 1:
//600
//Annual salary of Person 2:
//800
//Does Person 1 make more money than Person 2?
//false
namespace Anonymous_Income_Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("");
            Console.WriteLine("person 1");

            Console.WriteLine("");
            Console.WriteLine("Hourly rate?");
            Console.WriteLine("");
            string input1 = Console.ReadLine();
            int rate1 = Convert.ToInt32(input1);

            Console.WriteLine("");
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine("");
            string input2 = Console.ReadLine();
            int hours1 = Convert.ToInt32(input2);

            Console.WriteLine("");
            Console.WriteLine("Person 2");

            Console.WriteLine("");
            Console.WriteLine("Hourly rate?");
            Console.WriteLine("");
            string input3 = Console.ReadLine();
            int rate2 = Convert.ToInt32(input3);

            Console.WriteLine("");
            Console.WriteLine("Hours worked per week?");
            Console.WriteLine("");
            string input4 = Console.ReadLine();
            int hours2 = Convert.ToInt32(input4);

            Console.WriteLine("");
            Console.WriteLine("Anual salery of person 1");
            Console.WriteLine("");
            int salery = (int)rate1 * hours1 * 52;
            Console.WriteLine(salery);

            Console.WriteLine("");
            Console.WriteLine("Anual salery of person 2");
            Console.WriteLine("");
            int salery2 = (int)rate2 * hours2 * 52;
            Console.WriteLine(salery2);

            Console.WriteLine("");
            Console.WriteLine("Does person 1 make more than person 2?");
            Console.WriteLine("");

            bool compare = salery > salery2;
            Console.WriteLine(compare);
            Console.ReadLine();


        }
    }
}
