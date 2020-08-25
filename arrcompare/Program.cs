using System;
using System.Linq;

namespace arrcompare
{
    class Program
    {
        static void Main(string[] args)
        {
            // two arrays
            int[] arr = new int[] { 99, 87, 56, 45 };
            int[] brr = new int[] { 99, 87, 5, 45 };

            // compare
            Console.WriteLine(arr.SequenceEqual(brr));
        }
    }
}
