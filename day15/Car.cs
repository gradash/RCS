using System;
using System.Collections.Generic;
using System.Text;

namespace day15
{
    class Car

    {

        public string mark;
        public string model;
        public string color;


        public Car(string mark, string model, string color)
        {

            this.mark = mark;
            this.model = model;
            this.color = color;
            
        }




        public void printInfo()
        {
            Console.WriteLine(mark);
            Console.WriteLine(model);
            Console.WriteLine(color);
        }







    }
}