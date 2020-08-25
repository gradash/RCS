using System;
using System.Security.Cryptography.X509Certificates;

namespace RCS_25._07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ievadiet pirmo skaitli: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet otro skaitli: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ievadiet treso skaitli: ");
            int c = Convert.ToInt32(Console.ReadLine());

            int result = Uzdevums7(a, b, c);
            Console.WriteLine("Lielakais skaitlis: " + result);
        }


        /*
        1) Uztaisīt metodi, kas kā parametru paņem 3 int tipa  skaitļus.
        2) Ar return atgriezt lielāko.
        */

        static int Uzdevums7(int a, int b, int c)
        {
            if (a > b && a > c)
            {
                return a;
            }
            else if (b > a && b > c)
            {
                return b;
            }
            else
            {
                return c;
            }
            
            
        

        }


    }
}
 