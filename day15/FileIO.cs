using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;


namespace day15
{
    class FileIO
    {

        public static List<string> ReadfromFile(String filename)
        {
            
            List<string> students = new List<string>();
            try
            {
                StreamReader sr = new StreamReader(filename);

   
                var fileContents = sr.ReadLine();

                while (fileContents != null)
                {
                    students.Add(fileContents);
                    fileContents = sr.ReadLine();
                }


                sr.Close();
            }

            catch
            {
                Console.WriteLine("Neizdevas atvert failu!");
                Environment.Exit(0);
            }

            return students;
        }


        //

        public static void WriteToFile(String cars, String filename)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename, true);


                    foreach (var x in cars)
                {
                    sw.WriteLine();
                }


                sw.Close();
}
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }


    }
}
