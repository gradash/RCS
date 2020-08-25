using System;

namespace Day2_variables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();


            Console.WriteLine("Enter age: ");
            string age = Console.ReadLine();
            int convertInt = Convert.ToInt32(age);
            

            Console.WriteLine("Hello " + name+" !");
            Console.WriteLine(convertInt);
            Console.ReadKey();
        }
    }
}
