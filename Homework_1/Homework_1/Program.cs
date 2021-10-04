using System;

namespace Homework_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //task 1
            Console.WriteLine("\t--- Task 1 ---");

            jump_1:
            Console.Write("Enter side of the square: ");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a > 0)
            {
                Console.WriteLine("S = " + (a * a));
                Console.WriteLine("P = " + (a * 4));
            }
            else
            {
                Console.WriteLine("\nSide must be greater than 0");
                goto jump_1;
            }

            //task 2
            Console.WriteLine("\n\t--- Task 2 ---");

            Console.WriteLine("What is your name? ");
            string name = Console.ReadLine();

            Console.WriteLine($"How old are you, {name}? ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Your name is {name}, you are {age} years old");

            //task 3
            Console.WriteLine("\n\t--- Task 3 ---");

            double pi = 3.14;

            jump_2:
            Console.Write("Enter radius of a circle: ");
            double r = Convert.ToDouble(Console.ReadLine());

            if (r > 0)
            {
                Console.WriteLine("l = " + (2 * pi * r));
                Console.WriteLine("S = " + (pi * r * r));
                Console.WriteLine("V = " + (4.0 / 3.0 * pi * r * r * r));
            }
            else
            {
                Console.WriteLine("\nRadius must be greater than 0");
                goto jump_2;
            }

            Console.ReadKey();
        }
    }
}
