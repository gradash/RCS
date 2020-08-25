using System;

namespace homework_sum_sub
{
    class Program
    {

        interface ISumSub
        {

            public static int num1 = Convert.ToInt32(Console.ReadLine());
            public static int num2 = Convert.ToInt32(Console.ReadLine());
            public static int sum = ISumSub.num1 + ISumSub.num2;
            public static int sub = ISumSub.num1 - ISumSub.num2;

        }


        static void Main(string[] args)
        { 
           
            
         Console.WriteLine("Write number 1: ");
            int n1 = ISumSub.num1;

         Console.WriteLine("Write number 2: ");
            int n2 = ISumSub.num2;

            int sum = ISumSub.num1 + ISumSub.num2;
            int sub = ISumSub.num1 - ISumSub.num2;

                Console.WriteLine("Sum of " + ISumSub.num1 + " and " + ISumSub.num2 + " is " + sum);
                Console.WriteLine("Sum of " + ISumSub.num1 + " and " + ISumSub.num2 + " is " + sub);




            Console.ReadKey();
        }
    }
}

