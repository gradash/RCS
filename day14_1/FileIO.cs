using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace day11_1_student_files
{
    class FileIO
    {

        public static List<string> ReadStudentLst(String filename)
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

        public static void WriteStudentToFile(String student, String filename)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename, true);


                    sw.WriteLine(student);


                sw.Close();
}
            catch
            {
                Console.WriteLine("Neizdevas ierakstit faila!");
            }
        }


    }
}