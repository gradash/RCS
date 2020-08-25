using System;

namespace bubblesort
{


    class MySort
    {
        static void Main(string[] args)
        {

            //fill array with random numbers
            Console.Write("cik liels massivs ?: ");
            int arrayLength = Convert.ToInt32(Console.ReadLine());

            Random r = new Random();
            int[] arr = new int[arrayLength];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0,arrayLength);
            }
            //output unsorted
            Console.WriteLine("Unsorted:");
            foreach (int p in arr)
                Console.Write(p + " ");


            Console.WriteLine();


            //bubble sort
            int temp;
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            //sorted output
            Console.WriteLine("Sorted:");
            foreach (int p in arr)
                Console.Write(p + " ");
            Console.Read();
            
        }
    }
}