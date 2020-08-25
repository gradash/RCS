using System;

namespace day6
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraySample();
            //WhileSum();
        }


        static void ArraySample()
        {


            string[] arr = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter something:");
                string userPrinted = Convert.ToString(Console.ReadLine());
                arr[i] = userPrinted;
                               
                
            }

            Console.WriteLine("More than 5 symbols:");
            for (int i = 0; i < 10; i++)
            {

                if (arr[i].Length > 5)
                {
                    Console.WriteLine(arr[i]);
                }

            }
        }




        static void WhileSum()
        {


            

            string yesno;
            int tempSum = 0;
            do
            {
                Console.WriteLine("Enter number: ");
                int whileSum = Convert.ToInt32(Console.ReadLine());
                tempSum += whileSum;

                Console.WriteLine("Again? y/n");
                yesno = Convert.ToString(Console.ReadLine());
            }
            while (yesno != "n") ;
            Console.WriteLine("Result: {0}", tempSum);


        }



    }
}
