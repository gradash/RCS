using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace day15
{

    
    class Program
    {
        static readonly string newcars_filename = "C:\\Users\\grada\\source\\repos\\RCS\\day15\\new_cars.json";
        static readonly string soldcars_filename = "C:\\Users\\grada\\source\\repos\\RCS\\day15\\sold_cars.json";
        static void Main(string[] args)
        {



            Console.WriteLine("Choose menu item");
            Console.WriteLine("1 Show cars");
            Console.WriteLine("2 Add car");
            Console.WriteLine("3 Mark car as sold");
            Console.WriteLine("4 Show sold cars");


            char menu = Convert.ToChar(Console.ReadLine());

            switch (menu)
            {
                case '1':
                    //show cars
                    List<Car> newcars = JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText(newcars_filename));
                    foreach (Car st in newcars)
                    {
                        st.printInfo();
                    }
                    break;

                case '2':
                    //add car (add car to newcars json)

                    char choose;
                    do
                    {
                        Console.WriteLine("Enter car brand:");
                        string brand = Console.ReadLine();
                        Console.WriteLine("Enter car model:");
                        string model = Console.ReadLine();
                        Console.WriteLine("Enter car color:");
                        string color = Console.ReadLine();

                        Car car = new Car(brand, model, color);

                        String jsonString = JsonConvert.SerializeObject(car);


                        FileIO.WriteToFile(jsonString, newcars_filename);

                        Console.WriteLine("Add more ?: y/n");
                        choose = Convert.ToChar(Console.ReadLine());

                    } while (choose != 'n');


                    break;

                case '3':
                    //mark as sold (mark and write to soldcars json)



                    break;

                case '4':
                    //show sold
                    List<Car> soldcars = JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText(soldcars_filename));
                    foreach (Car st in soldcars)
                    {
                        st.printInfo();
                    }
                    break;

  

            }

}
}

}







        

