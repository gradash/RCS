using Day9_Objects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace day9_carmenu
{
    class Menu
    {

        public List<Car> car = new List<Car>();

        public void showlist()
        {
            Console.Clear();
            Console.WriteLine("Auto saraktsts:");
            if (car.Count == 0)
            {
                Console.WriteLine("Saraksta neka nau");
            }
            for (int i = 0; i < car.Count; i++)
            {
                Console.WriteLine((i + 1) + " " + car[i].PrintInfo());
            }
            Console.ReadKey();

        }


        public void addElement()
        {
            Console.WriteLine("Car color:");
            string color = Console.ReadLine();
            Console.WriteLine("Car brand:");
            string brand = Console.ReadLine();
            Console.WriteLine("Car model:");
            string model = Console.ReadLine();

            Console.Clear();
            
            car.Add(new Car(color, brand, model));
        }

       


    }
}
