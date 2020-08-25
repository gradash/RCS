using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = ReturnNum();
            int num2 = ReturnNum();

            int result = num1 + num2;
            Console.WriteLine(result);


        }


        static int ReturnNum()
        {

            int number = Convert.ToInt32(Console.ReadLine());
            
            return number;
        }

    



    }


}