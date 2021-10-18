using System;

namespace Task_4
{
    class Car
    {
        string name;
        internal string color;
        double price;
        const string CompanyName = "Shreder";

        public void Input()
        {
            Console.Write("\nEnter car name: ");
            name = Convert.ToString(Console.ReadLine());

            Console.Write("Enter car color: ");
            color = Convert.ToString(Console.ReadLine());

            Console.Write("Enter car price: ");
            price = Convert.ToSingle(Console.ReadLine());
        }

        public void NewPrice()
        {
            price -= price * 10 / 100;
        }

        public void Print()
        {
            Console.WriteLine($"\nName - {name}\nColor - {color}\nPrice - {price} (-10%)");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Car car_1 = new Car();
            Car car_2 = new Car();
            Car car_3 = new Car();

            car_1.Input();
            car_2.Input();
            car_3.Input();

            Console.Write("\nEnter color: ");
            string new_color = Convert.ToString(Console.ReadLine());

            if(car_1.color == "white")
            {
                car_1.color = new_color;
            }
            if(car_2.color == "white")
            {
                car_2.color = new_color;
            }
            if (car_3.color == "white")
            {
                car_3.color = new_color;
            }

            car_1.NewPrice();
            car_2.NewPrice();
            car_3.NewPrice();

            car_1.Print();
            car_2.Print();
            car_3.Print();
        }
    }
}
