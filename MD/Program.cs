using System;

namespace MD
{
    class Program
    {
        static void Main(string[] args)
        {
            Pow(5,3);
        }




        public static void Pow(int a, int pow)
        {
            int b = a;
            int c;
            int n = 1;
            do
            {
                c = b * a;
                b = c;
                n++;
            }
            while (n < pow);

            Console.WriteLine("Result: " + c);
        }
    }
}
