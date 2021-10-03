using System;

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1
            Console.WriteLine("\t--- Task 1 ---");

            Console.Write("Enter number a: ");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter number b: ");
            int b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));

            if (b != 0)
            {
                Console.WriteLine("a / b = " + (a / b));
            }
            else
            {
                Console.WriteLine("Number cannot be divided by zero");
            }

            // Task 2
            Console.WriteLine("\n\t--- Task 2 ---");

            Console.Write("How are you ? ");
            string answer = Console.ReadLine();

            Console.WriteLine($"You are {answer}");

            // Task 3
            Console.WriteLine("\n\t--- Task 3 ---");

            Console.Write("Enter first char: ");
            char first = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter second char: ");
            char second = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter third char: ");
            char third = Convert.ToChar(Console.ReadLine());

            Console.WriteLine($"You enter {first}, {second}, {third}");

            // Task 4
            bool result;

            Console.WriteLine("\n\t--- Task 4 ---");

            Console.Write("Enter first number: ");
            int first_number = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int second_number = Convert.ToInt32(Console.ReadLine());

            if (first_number > 0 && second_number > 0)
            {
                result = true;
            }
            else
            {
                result = false;
            }

            if (result)
            {
                Console.WriteLine("Numbers are positive");
            }
            else
            {
                if (first_number < 0 && second_number > 0)
                {
                    Console.WriteLine("Only second numbers are positive");
                }
                else if (first_number > 0 && second_number < 0)
                {
                    Console.WriteLine("Only first numbers are positive");
                }
                else if (first_number < 0 && second_number < 0) 
                {
                    Console.WriteLine("Numbers are negative");
                }
                else
                {
                    Console.WriteLine("Numbers are not positive and are not negative");
                }
            }
            Console.ReadKey();
        }
    }
}
