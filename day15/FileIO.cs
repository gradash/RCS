using System;
using System.Collections.Generic;
using System.IO;
using System.Text;


namespace day15
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

        public static void WriteStudentToFile(ListView listView, String filename)
        {
            try
            {
                StreamWriter sw = new StreamWriter(filename, true);


                    foreach (ListViewItem list in listView.Items)
                {
                    sw.WriteLine(list.Text);
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
