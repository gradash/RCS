using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace RCS_2707
{
    class Program
    {
        static void Main(string[] args)
        {

            //Calculator();
            //LoopSample();
            //LoopSample1();
            //Task3();
            //Task4();
            ExtraTask4();


        }

        static void ExtraTask4()
        {


            {
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }

                for (int i = 4; i > 0; i--)
                {
                    for (int j = 1; j <= i; j++)
                        Console.Write("*");
                    Console.WriteLine();
                }
            }

        }






            static void Task3()
        {
            Console.WriteLine("ievadiet ciparu");
            int x = Convert.ToInt32(Console.ReadLine());
            int min = x;
            int max = x;

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("ievadiet ciparu");
                x = Convert.ToInt32(Console.ReadLine());

                if (x > max)
                {
                    max = x;
                }

                else if (x < min)
                {
                    min = x;
                }

            }
            Console.WriteLine("smaller " + min);
            Console.WriteLine("bigger " + max);
        }







        static void LoopSample()
        {

            int sum = 0;
            for (int x = 1; x <= 10; x++)
            {
                sum += x;
                
            }
            Console.WriteLine("Result is {0} ", sum);

        }

        static void LoopSample1()
        {

            int sum = 0;
            for (int x = 1; x <= 6; x++)
            {
                Console.WriteLine("ievadiet " + x + " ciparu");
                sum = Convert.ToInt32(Console.ReadLine()) + sum;

            }
            Console.WriteLine("Result is {0} ", sum);

        }








        static void Calculator()
        {


            char yesno;
            do
            {
                Console.WriteLine("Enter 1st number: ");
                double n1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter math sign (+ - * /): ");
                char sign = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("Enter 2nd number: ");
                double n2 = Convert.ToDouble(Console.ReadLine());
                

                switch (sign)
                {
                    case '+':
                        Console.WriteLine("Result: {0} ", n1 + n2);
                        break;
                    case '-':
                        Console.WriteLine("Result: {0} ", n1 - n2);
                        break;
                    case '*':
                        Console.WriteLine("Result: {0} ", n1 * n2);
                        break;
                    case '/':
                        Console.WriteLine("Result: {0} ", n1 / n2);
                        break;
                    default:
                        Console.WriteLine("Unknown matn sign, awaiting:  + - * /");
                        break;

                }

                Console.WriteLine("Again? y/n");
                yesno = Convert.ToChar(Console.ReadLine());
            } 
            while (yesno == 'y');



        }

    }
}
