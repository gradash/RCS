using System;
using System.Collections.Generic;
using System.Text;

namespace Day9_Objects
{
    class Car
    {
        public String color;
        public String brand;
        public String model;

        public Car(String color, String brand, String model)
        {
            this.color = color;
            this.brand = brand;
            this.model = model;
        }
        public string PrintInfo()
        {
            return(color + " " + brand + " " + model);
        }

    }
}