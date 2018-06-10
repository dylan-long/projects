using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loopPractice2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("what is your favorite color?");
            Console.WriteLine("you may pick from either \"red\" \"green\" or \"blue\".");
            string favColor = Console.ReadLine();
            
            bool correct = favColor == "blue";

            while (!correct)
            {
                switch (favColor)
                {
                    case "green":
                        Console.WriteLine("that color isnt that great. ill give you another chance to choose a better one.");
                        Console.WriteLine("what is your favorite color?");
                        Console.WriteLine("you may pick from either \"red\" \"green\" or \"blue\".");
                        favColor = Console.ReadLine();
                        break;
                    case "red":
                        Console.WriteLine("that color isnt that great. ill give you another chance to choose a better one.");
                        Console.WriteLine("what is your favorite color?");
                        Console.WriteLine("you may pick from either \"red\" \"green\" or \"blue\".");
                        favColor = Console.ReadLine();
                        break;
                    case "blue":
                        Console.WriteLine("Thats a good choice. alright, you may leave now.");
                        correct = true;
                        Console.ReadLine();
                        Environment.Exit(0);
                        break;


                }
            }

                    while(correct)
                    {
                        switch (favColor)
                        {
                            case "blue":
                                Console.WriteLine("Thats a good choice. alright, you may leave now.");
                                correct = true;
                                Console.ReadLine();
                                Environment.Exit(0);
                                break;
                        }
                    }
        }
        
        
    }
}
