using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text.Json;

namespace day15
{
    class Program
    {
        string filename = "C:\\Users\\grada\\source\\repos\\RCS\\day15\\cars.txt";
        static void Main(string[] args)
        {


            List<Car> car = new List<Car>();


            

            String jsonString = JsonConvert.SerializeObject();


            Console.WriteLine(jsonString);


            // here write file



            //lasa no faila
            List<Car> lstRec = JsonConvert.DeserializeObject<List<Car>>(jsonString);

            foreach (Car st in lstRec)
            {
                st.printInfo();
            }





            char menu = Convert.ToChar(Console.ReadLine());

            switch (menu)
            {
                case '1':
                    //show cars
                    break;

                case '2':
                    //add car
                    break;

                case '3':
                    //mark as sold
                    break;

                case '4':
                    //show sold
                    break;

  

            }







        }
    }
}
