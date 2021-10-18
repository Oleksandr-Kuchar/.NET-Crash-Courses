using System;

namespace Homework_4
{
    class Person
    {
        private string name { get; set; }
        private int birthYear { get; set; }
        public override string ToString()
        {
            return string.Format($"Person name - {name}, age - {birthYear}");
        }
        
        public void Input()
        {
            Console.Write("\nEnter name: ");
            name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter birthday year: ");
            birthYear = Convert.ToInt32(Console.ReadLine());
        }

        public void Age()
        {
            birthYear = 2021 - birthYear;
        }

        public void ChangeName()
        {
            if (birthYear < 16)
            {
                name = "Very Young";
            }
        }

        public void Output()
        {
            Console.WriteLine(ToString());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person_1 = new Person();
            Person person_2 = new Person();
            Person person_3 = new Person();
            Person person_4 = new Person();
            Person person_5 = new Person();
            Person person_6 = new Person();

            person_1.Input();
            person_2.Input();
            person_3.Input();
            person_4.Input();
            person_5.Input();
            person_6.Input();

            person_1.Age();
            person_2.Age();
            person_3.Age();
            person_4.Age();
            person_5.Age();
            person_6.Age();

            person_1.Output();
            person_2.Output();
            person_3.Output();
            person_4.Output();
            person_5.Output();
            person_6.Output();

            Console.WriteLine("\nSearch age less then 16 and change name to 'Very Young'");

            person_1.ChangeName();
            person_2.ChangeName();
            person_3.ChangeName();
            person_4.ChangeName();
            person_5.ChangeName();
            person_6.ChangeName();

            person_1.Output();
            person_2.Output();
            person_3.Output();
            person_4.Output();
            person_5.Output();
            person_6.Output();


        }
    }
}
